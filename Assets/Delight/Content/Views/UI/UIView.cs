﻿#region Using Statements
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    /// <summary>
    /// Base class for UI views. Has properties for doing layout: Width, Height, Margin, Alignment and Offset.
    /// </summary>
    public partial class UIView
    {
        #region Methods

        /// <summary>
        /// Called before the view is loaded.
        /// </summary>
        protected override void BeforeLoad()
        {
            base.BeforeLoad();

            // initialize root canvas
            if (LayoutRoot == null)
            {
                var parentUIView = this.FindParent<UIView>(x => !x.IgnoreObject);
                if (parentUIView == null)
                {
                    // we are the root view
                    if (typeof(LayoutRoot).IsAssignableFrom(GetType()))
                    {
                        // we are the layout root
                        LayoutRoot = this as LayoutRoot;
                    }
                    else
                    {
                        // create new layout root
                        var layoutRoot = new LayoutRoot();
                        layoutRoot.Load();
                        LayoutRoot = layoutRoot;
                        LayoutParent = LayoutRoot;

                        if (!IgnoreObject)
                        {
                            GameObject.transform.SetParent(layoutRoot.GameObject.transform, false);
                        }
                    }
                }
                else
                {
                    // use the same layout root as parent UIView
                    LayoutRoot = parentUIView.LayoutRoot;
                }
            }

            if (IgnoreObject)
                return;

            // add rect transform
            var rectTransform = GameObject.GetComponent<RectTransform>();
            if (rectTransform == null)
            {
                rectTransform = GameObject.AddComponent<RectTransform>();
            }
            RectTransform = rectTransform;

            // if hidden while loading set canvas alpha to zero
            if (LoadMode.HasFlag(LoadMode.HiddenWhileLoading))
            {
                // to change alpha we need a canvas group attached
                if (CanvasGroup == null)
                {
                    var canvasGroup = GameObject.GetComponent<CanvasGroup>();
                    CanvasGroup = canvasGroup == null ? GameObject.AddComponent<CanvasGroup>() : canvasGroup;
                }

                CanvasGroup.alpha = 0;
            }
        }

        /// <summary>
        /// Called when a property has been changed. 
        /// </summary>
        public override void OnChanged(string property)
        {
            base.OnChanged(property);
            switch (property)
            {
                case nameof(Width):
                case nameof(Height):
                case nameof(OverrideWidth):
                case nameof(OverrideHeight):
                    SizeChanged();
                    break;

                case nameof(Margin):
                case nameof(Offset):
                case nameof(OffsetFromParent):
                case nameof(Pivot):
                case nameof(Scale):
                case nameof(Rotation):
                case nameof(Position):
                case nameof(Alignment):
                    OffsetChanged();
                    break;

                case nameof(Alpha):
                case nameof(RaycastBlockMode):
                case nameof(IsVisible):
                case nameof(IsInteractable):
                    VisibilityChanged();
                    break;

                case nameof(FastMaterial):
                    FastMaterialChanged();
                    break;
            }
        }

        /// <summary>
        /// Called after the view is loaded.
        /// </summary>
        protected override void AfterLoad()
        {
            base.AfterLoad();
            if (IgnoreObject)
                return;

            if (LoadMode.HasFlag(LoadMode.HiddenWhileLoading))
            {
                CanvasGroup.alpha = 1; // revert to default
            }

            // update layout and visibility
            VisibilityChanged();
            UpdateLayout(false);
        }

        /// <summary>
        /// Called after the view is unloaded.
        /// </summary>
        protected override void AfterUnload()
        {
            base.AfterUnload();
        }

        /// <summary>
        /// Called when size of the view has been changed.
        /// </summary>
        protected void SizeChanged()
        {
            if (IgnoreObject || DisableLayoutUpdate)
                return;

            //Debug.Log(String.Format("{0}.LayoutChanged()", Name));            
            LayoutRoot.RegisterChangeHandler(OnSizeChanged);
        }

        /// <summary>
        /// Called when size of the view has been changed.
        /// </summary>
        protected void OnSizeChanged()
        {
            if (IgnoreObject || DisableLayoutUpdate)
                return;

            UpdateLayout();
        }

        /// <summary>
        /// Called when a property affecting the offset of the view has been changed.
        /// </summary>
        protected void OffsetChanged()
        {
            if (IgnoreObject || DisableLayoutUpdate)
                return;

            UpdateRectTransform();
        }

        /// <summary>
        /// Called when after the top-most load is called. Used to update parents.
        /// </summary>
        protected override void AfterInitiatedLoad()
        {
            NotifyParentOfChildLayoutChanged();
            base.AfterInitiatedLoad();
        }

        /// <summary>
        /// Called when after the top-most unload is called. Used to update parents.
        /// </summary>
        protected override void AfterInitiatedUnload()
        {
            NotifyParentOfChildLayoutChanged();
            base.AfterInitiatedUnload();
        }

        /// <summary>
        /// Updates layout.
        /// </summary>
        public virtual bool UpdateLayout(bool notifyParent = true)
        {
            //Debug.Log(String.Format("{0}.UpdateLayout()", Name));

            UpdateRectTransform();

            if (notifyParent)
            {
                NotifyParentOfChildLayoutChanged();
            }

            return false;
        }

        /// <summary>
        /// Notifies parent that the layout of a child has been updated.
        /// </summary>
        protected void NotifyParentOfChildLayoutChanged()
        {
            // notify parent of layout update
            var uiViewParent = this.FindParent<UIView>();
            if (uiViewParent != null && uiViewParent.IsLoaded)
            {
                uiViewParent.ChildLayoutChanged();
            }
        }

        /// <summary>
        /// Called if a child has changed its layout. 
        /// </summary>
        protected virtual void ChildLayoutChanged()
        {
            // notify parents if this view is ignored
            if (BubbleNotifyChildLayoutChanged || IgnoreObject)
            {
                NotifyParentOfChildLayoutChanged();
            }
        }

        /// <summary>
        /// Updates rect transform. 
        /// </summary>
        private void UpdateRectTransform()
        {
            if (GameObject == null)
                return;

            if (!PivotProperty.IsUndefined(this))
            {
                RectTransform.pivot = Pivot;
            }

            if (!RotationProperty.IsUndefined(this))
            {
                RectTransform.localRotation = Rotation;
            }

            // update rectTransform
            // horizontal alignment and positioning
            var width = OverrideWidth ?? (Width ?? ElementSize.DefaultLayout);
            var height = OverrideHeight ?? (Height ?? ElementSize.DefaultLayout);

            float xMin = 0f;
            float xMax = 0f;
            float offsetMinX = 0f;
            float offsetMaxX = 0f;

            if (Alignment.HasFlag(ElementAlignment.Left))
            {
                xMin = 0f;
                xMax = width.Percent;
                offsetMinX = 0f;
                offsetMaxX = width.Pixels;
            }
            else if (Alignment.HasFlag(ElementAlignment.Right))
            {
                xMin = 1f - width.Percent;
                xMax = 1f;
                offsetMinX = -width.Pixels;
                offsetMaxX = 0f;
            }
            else
            {
                xMin = 0.5f - width.Percent / 2f;
                xMax = 0.5f + width.Percent / 2f;
                offsetMinX = -width.Pixels / 2f;
                offsetMaxX = width.Pixels / 2f;
            }

            // vertical alignment
            float yMin = 0f;
            float yMax = 0f;
            float offsetMinY = 0f;
            float offsetMaxY = 0f;

            if (Alignment.HasFlag(ElementAlignment.Top))
            {
                yMin = 1f - height.Percent;
                yMax = 1f;
                offsetMinY = -height.Pixels;
                offsetMaxY = 0f;
            }
            else if (Alignment.HasFlag(ElementAlignment.Bottom))
            {
                yMin = 0f;
                yMax = height.Percent;
                offsetMinY = 0f;
                offsetMaxY = height.Pixels;
            }
            else
            {
                yMin = 0.5f - height.Percent / 2f;
                yMax = 0.5f + height.Percent / 2f;
                offsetMinY = -height.Pixels / 2f;
                offsetMaxY = height.Pixels / 2f;
            }

            var margin = Margin ?? ElementMargin.Default;
            RectTransform.anchorMin = new Vector2(xMin + margin.Left.Percent, yMin + margin.Bottom.Percent);
            RectTransform.anchorMax = new Vector2(xMax - margin.Right.Percent, yMax - margin.Top.Percent);

            // positioning and margins
            var offset = Offset ?? ElementMargin.Default;
            var offsetFromParent = OffsetFromParent ?? ElementMargin.Default;
            RectTransform.offsetMin = new Vector2(
                offsetMinX + margin.Left.Pixels + offset.Left.Pixels - offset.Right.Pixels + offsetFromParent.Left.Pixels - offsetFromParent.Right.Pixels,
                offsetMinY + margin.Bottom.Pixels - offset.Top.Pixels + offset.Bottom.Pixels - offsetFromParent.Top.Pixels + offsetFromParent.Bottom.Pixels);
            RectTransform.offsetMax = new Vector2(
                offsetMaxX - margin.Right.Pixels + offset.Left.Pixels - offset.Right.Pixels + offsetFromParent.Left.Pixels - offsetFromParent.Right.Pixels,
                offsetMaxY - margin.Top.Pixels - offset.Top.Pixels + offset.Bottom.Pixels - offsetFromParent.Top.Pixels + offsetFromParent.Bottom.Pixels);

            RectTransform.anchoredPosition = new Vector2(
                RectTransform.offsetMin.x / 2.0f + RectTransform.offsetMax.x / 2.0f,
                RectTransform.offsetMin.y / 2.0f + RectTransform.offsetMax.y / 2.0f);

            if (!PositionProperty.IsUndefined(this))
            {
                RectTransform.localPosition = Position;
            }

            if (!ScaleProperty.IsUndefined(this))
            {
                RectTransform.localScale = Scale;
            }
        }

        /// <summary>
        /// Called when the visibility of the view has changed. 
        /// </summary>
        protected virtual void VisibilityChanged()
        {
            if (AlphaProperty.IsUndefined(this, UIViewTemplates.Default) &&
                IsVisibleProperty.IsUndefined(this, UIViewTemplates.Default) &&
                RaycastBlockModeProperty.IsUndefined(this, UIViewTemplates.Default) &&
                IsInteractableProperty.IsUndefined(this, UIViewTemplates.Default))
                return;

            // to change alpha, visibility and raycast we need a canvas group attached
            if (CanvasGroup == null)
            {
                var canvasGroup = GameObject.GetComponent<CanvasGroup>();
                CanvasGroup = canvasGroup == null ? GameObject.AddComponent<CanvasGroup>() : canvasGroup;
            }

            // set alpha value
            var alpha = AlphaProperty.IsUndefined(this) ? 1 : Alpha;
            CanvasGroup.alpha = IsVisible ? alpha : 0;

            // set raycast block mode
            if (RaycastBlockMode == RaycastBlockMode.Always)
            {
                CanvasGroup.blocksRaycasts = true;
            }
            else if (RaycastBlockMode == RaycastBlockMode.Never)
            {
                CanvasGroup.blocksRaycasts = false;
            }
            else
            {
                CanvasGroup.blocksRaycasts = (IsVisible && alpha > 0);
            }

            if (IsInteractableProperty.IsUndefined(this))
            {
                CanvasGroup.interactable = IsVisible && alpha > 0;
            }
            else
            {
                CanvasGroup.interactable = IsInteractable;
            }
        }

        /// <summary>
        /// Gets canvas group (adds it to the view if it doesn't exist).
        /// </summary>
        /// <returns></returns>
        public CanvasGroup GetCanvasGroup()
        {
            if (CanvasGroup == null)
            {
                if (GameObject == null)
                    return null;
                CanvasGroup = GameObject.AddComponent<CanvasGroup>();
            }

            return CanvasGroup;
        }

        /// <summary>
        /// Sets size of view in pixels.
        /// </summary>
        public void SetSize(float width, float height)
        {
            if (Width == null) Width = new ElementSize();
            if (Height == null) Height = new ElementSize();

            if (Width.Pixels != width)
                Width = new ElementSize(width);

            if (Height.Pixels != height)
                Height = new ElementSize(height);
        }

        /// <summary>
        /// Called whenever the UI fast default material has been loaded/changed.
        /// </summary>
        protected virtual void FastMaterialChanged()
        {
        }

        /// <summary>
        /// Tests if mouse is over this view. 
        /// </summary>
        public bool ContainsMouse(Vector3 mousePosition, bool testChildren = false, bool ignoreFullScreenViews = false)
        {
            // get root canvas
            UnityEngine.Canvas canvas = LayoutRoot.Canvas;

            // alpha transparent
            bool alphaTest = AlphaProperty.IsUndefined(this) ? true : Alpha > 0.99f;

            // for screen space overlay the camera should be null
            Camera worldCamera = canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera;
            if (RectTransformUtility.RectangleContainsScreenPoint(this.RectTransform, mousePosition, worldCamera)
                && (!ignoreFullScreenViews || !IsFullScreen)
                && GameObject.activeInHierarchy
                && alphaTest)
            {
                return true;
            }

            if (!testChildren)
                return false;

            foreach (var child in LayoutChildren)
            {
                UIView view = child as UIView;
                if (view == null)
                    continue;

                if (view.ContainsMouse(mousePosition, true, ignoreFullScreenViews))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Called when IsActive property has been changed.
        /// </summary>
        public override void IsActiveChanged(bool notifyParent = true)
        {
            base.IsActiveChanged(notifyParent);
            if (notifyParent)
            {
                NotifyParentOfChildLayoutChanged();
            }
        }

        /// <summary>
        /// Adjusts the size of the view to its content. 
        /// </summary>
        public bool AdjustSizeToContent()
        {
            bool hasNewSize = false;

            float maxWidth = -1f;
            float maxHeight = -1f;
            int childCount = LayoutChildren.Count;

            // get size of content and set content offsets and alignment
            for (int i = 0; i < childCount; ++i)
            {
                var childView = LayoutChildren[i] as UIView;
                if (childView == null || !childView.IsActive)
                    continue;

                var childWidth = childView.OverrideWidth ?? (childView.Width ?? ElementSize.DefaultLayout);
                var childHeight = childView.OverrideHeight ?? (childView.Height ?? ElementSize.DefaultLayout);

                // get size of content
                if (childWidth.Unit != ElementSizeUnit.Percents)
                {
                    maxWidth = childWidth.Pixels > maxWidth ? childWidth.Pixels : maxWidth;
                }

                if (childHeight.Unit != ElementSizeUnit.Percents)
                {
                    maxHeight = childHeight.Pixels > maxHeight ? childHeight.Pixels : maxHeight;
                }
            }

            // add margins
            var margin = Margin ?? ElementMargin.Default;

            if (maxWidth >= 0)
            {
                maxWidth += margin.Left.Pixels + margin.Right.Pixels;

                // adjust size to content unless it has been set
                var newWidth = new ElementSize(maxWidth);
                if (!newWidth.Equals(Width))
                {
                    Width = newWidth;
                    hasNewSize = true;
                }
            }

            if (maxHeight >= 0)
            {
                maxHeight += margin.Top.Pixels + margin.Bottom.Pixels;
                var newHeight = new ElementSize(maxHeight);
                if (!newHeight.Equals(Height))
                {
                    Height = newHeight;
                    hasNewSize = true;
                }
            }

            return hasNewSize;
        }

        /// <summary>
        /// Adjusts the size of the view to the size of another view. 
        /// </summary>
        public bool AdjustSizeToView(UIView targetView)
        {
            bool hasNewSize = false;
            float maxWidth = -1f;
            float maxHeight = -1f;

            // get size of content and set content offsets and alignment
            var targetWidth = targetView.OverrideWidth ?? (targetView.Width ?? ElementSize.DefaultLayout);
            var targetHeight = targetView.OverrideHeight ?? (targetView.Height ?? ElementSize.DefaultLayout);

            // get size of view
            if (targetWidth.Unit != ElementSizeUnit.Percents)
            {
                maxWidth = targetWidth.Pixels > maxWidth ? targetWidth.Pixels : maxWidth;
            }

            if (targetHeight.Unit != ElementSizeUnit.Percents)
            {
                maxHeight = targetHeight.Pixels > maxHeight ? targetHeight.Pixels : maxHeight;
            }

            // adjust size to view
            var margin = Margin ?? ElementMargin.Default;
            var newWidth = maxWidth >= 0 ? new ElementSize(maxWidth + margin.Left.Pixels + margin.Right.Pixels)
                : ElementSize.DefaultLayout;
            if (!newWidth.Equals(Width))
            {
                Width = newWidth;
                hasNewSize = true;
            }

            var newHeight = maxHeight >= 0 ? new ElementSize(maxHeight + margin.Top.Pixels + margin.Bottom.Pixels)
                : ElementSize.DefaultLayout;
            if (!newHeight.Equals(Height))
            {
                Height = newHeight;
                hasNewSize = true;
            }

            return hasNewSize;
        }

        /// <summary>
        /// Helper method for getting pixel width of a view.
        /// </summary>
        public static float GetPixelWidth(UIView view)
        {
            if (view == null || !view.IsActive) return 0;
            var width = view.OverrideWidth ?? view.Width;
            return width != null ? width.Pixels : 0;
        }

        /// <summary>
        /// Helper method for getting pixel width of a view.
        /// </summary>
        public static float GetPixelHeight(UIView view)
        {
            if (view == null || !view.IsActive) return 0;
            var height = view.OverrideHeight ?? view.Height;
            return height != null ? height.Pixels : 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets actual width of view in pixels. Useful when Width may be specified as percentage and you want actual pixel width.
        /// </summary>
        public float ActualWidth
        {
            get
            {
                if (RectTransform != null)
                {
                    return Mathf.Abs(RectTransform.rect.width);
                }
                else
                {
                    var width = OverrideWidth ?? Width;
                    return width != null && width.Unit == ElementSizeUnit.Pixels ? width.Pixels : 0;
                }
            }
        }

        /// <summary>
        /// Gets actual height of view in pixels. Useful when Height may be specified as percentage and you want actual pixel height.
        /// </summary>
        public float ActualHeight
        {
            get
            {
                if (RectTransform != null)
                {
                    return Mathf.Abs(RectTransform.rect.height);
                }
                else
                {
                    var height = OverrideHeight ?? Height;
                    return height != null && height.Unit == ElementSizeUnit.Pixels ? height.Pixels : 0;
                }
            }
        }

        /// <summary>
        /// Gets boolean indicating if view takes up the entire screen.
        /// </summary>
        public bool IsFullScreen
        {
            get
            {
                return RectTransform.rect.width >= Screen.width && RectTransform.rect.height >= Screen.height;
            }
        }

        #endregion
    }
}
