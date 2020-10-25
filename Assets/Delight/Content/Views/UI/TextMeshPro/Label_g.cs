#if DELIGHT_MODULE_TEXTMESHPRO

// Internal view logic generated from "Label.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class Label : UIView
    {
        #region Constructors

        public Label(View parent, View layoutParent = null, string id = null, Template template = null, bool deferInitialization = false) :
            base(parent, layoutParent, id, template ?? LabelTemplates.Default, deferInitialization)
        {
            if (deferInitialization)
                return;

            this.AfterInitializeInternal();
        }

        public Label() : this(null)
        {
        }

        static Label()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(LabelTemplates.Default, dependencyProperties);

            dependencyProperties.Add(TextMeshProUGUIProperty);
            dependencyProperties.Add(MaxWidthProperty);
            dependencyProperties.Add(AutoSizeProperty);
            dependencyProperties.Add(AutoSizeTextContainerProperty);
            dependencyProperties.Add(MaskOffsetProperty);
            dependencyProperties.Add(TextProperty);
            dependencyProperties.Add(IsRightToLeftTextProperty);
            dependencyProperties.Add(FontProperty);
            dependencyProperties.Add(FontSharedMaterialProperty);
            dependencyProperties.Add(FontSharedMaterialsProperty);
            dependencyProperties.Add(FontMaterialProperty);
            dependencyProperties.Add(FontMaterialsProperty);
            dependencyProperties.Add(FontColorProperty);
            dependencyProperties.Add(TextMeshProUGUIAlphaProperty);
            dependencyProperties.Add(EnableVertexGradientProperty);
            dependencyProperties.Add(ColorGradientProperty);
            dependencyProperties.Add(ColorGradientPresetProperty);
            dependencyProperties.Add(SpriteAssetProperty);
            dependencyProperties.Add(TintAllSpritesProperty);
            dependencyProperties.Add(OverrideColorTagsProperty);
            dependencyProperties.Add(FaceColorProperty);
            dependencyProperties.Add(OutlineColorProperty);
            dependencyProperties.Add(OutlineWidthProperty);
            dependencyProperties.Add(FontSizeProperty);
            dependencyProperties.Add(FontWeightProperty);
            dependencyProperties.Add(EnableAutoSizingProperty);
            dependencyProperties.Add(FontSizeMinProperty);
            dependencyProperties.Add(FontSizeMaxProperty);
            dependencyProperties.Add(FontStyleProperty);
            dependencyProperties.Add(TextAlignmentProperty);
            dependencyProperties.Add(CharacterSpacingProperty);
            dependencyProperties.Add(WordSpacingProperty);
            dependencyProperties.Add(LineSpacingProperty);
            dependencyProperties.Add(LineSpacingAdjustmentProperty);
            dependencyProperties.Add(ParagraphSpacingProperty);
            dependencyProperties.Add(CharacterWidthAdjustmentProperty);
            dependencyProperties.Add(EnableWordWrappingProperty);
            dependencyProperties.Add(WordWrappingRatiosProperty);
            dependencyProperties.Add(OverflowModeProperty);
            dependencyProperties.Add(LinkedTextComponentProperty);
            dependencyProperties.Add(IsLinkedTextComponentProperty);
            dependencyProperties.Add(EnableKerningProperty);
            dependencyProperties.Add(ExtraPaddingProperty);
            dependencyProperties.Add(RichTextProperty);
            dependencyProperties.Add(ParseCtrlCharactersProperty);
            dependencyProperties.Add(IsOverlayProperty);
            dependencyProperties.Add(IsOrthographicProperty);
            dependencyProperties.Add(EnableCullingProperty);
            dependencyProperties.Add(IgnoreRectMaskCullingProperty);
            dependencyProperties.Add(IgnoreVisibilityProperty);
            dependencyProperties.Add(HorizontalMappingProperty);
            dependencyProperties.Add(VerticalMappingProperty);
            dependencyProperties.Add(MappingUvLineOffsetProperty);
            dependencyProperties.Add(RenderModeProperty);
            dependencyProperties.Add(GeometrySortingOrderProperty);
            dependencyProperties.Add(VertexBufferAutoSizeReductionProperty);
            dependencyProperties.Add(FirstVisibleCharacterProperty);
            dependencyProperties.Add(MaxVisibleCharactersProperty);
            dependencyProperties.Add(MaxVisibleWordsProperty);
            dependencyProperties.Add(MaxVisibleLinesProperty);
            dependencyProperties.Add(UseMaxVisibleDescenderProperty);
            dependencyProperties.Add(PageToDisplayProperty);
            dependencyProperties.Add(TextMarginProperty);
            dependencyProperties.Add(HavePropertiesChangedProperty);
            dependencyProperties.Add(IsUsingLegacyAnimationComponentProperty);
            dependencyProperties.Add(IsVolumetricTextProperty);
            dependencyProperties.Add(OnCullStateChangedProperty);
            dependencyProperties.Add(MaskableProperty);
            dependencyProperties.Add(IsMaskingGraphicProperty);
            dependencyProperties.Add(RaycastTargetProperty);
            dependencyProperties.Add(MaterialProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<TMPro.TextMeshProUGUI> TextMeshProUGUIProperty = new DependencyProperty<TMPro.TextMeshProUGUI>("TextMeshProUGUI");
        public TMPro.TextMeshProUGUI TextMeshProUGUI
        {
            get { return TextMeshProUGUIProperty.GetValue(this); }
            set { TextMeshProUGUIProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> MaxWidthProperty = new DependencyProperty<Delight.ElementSize>("MaxWidth");
        /// <summary>Used when AutoSize is true and extends the label to the maxsize then expands vertically.</summary>
        public Delight.ElementSize MaxWidth
        {
            get { return MaxWidthProperty.GetValue(this); }
            set { MaxWidthProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.AutoSize> AutoSizeProperty = new DependencyProperty<Delight.AutoSize>("AutoSize");
        /// <summary>Enum indicating if and how the label should automatically resize itself to the size of the text.</summary>
        public Delight.AutoSize AutoSize
        {
            get { return AutoSizeProperty.GetValue(this); }
            set { AutoSizeProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> AutoSizeTextContainerProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("AutoSizeTextContainer", x => x.TextMeshProUGUI, x => x.autoSizeTextContainer, (x, y) => x.autoSizeTextContainer = y);
        /// <summary>Boolean indicating if text container should be resized to text.</summary>
        public System.Boolean AutoSizeTextContainer
        {
            get { return AutoSizeTextContainerProperty.GetValue(this); }
            set { AutoSizeTextContainerProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Vector4, TMPro.TextMeshProUGUI, Label> MaskOffsetProperty = new MappedDependencyProperty<UnityEngine.Vector4, TMPro.TextMeshProUGUI, Label>("MaskOffset", x => x.TextMeshProUGUI, x => x.maskOffset, (x, y) => x.maskOffset = y);
        /// <summary>Offset of mask graphics.</summary>
        public UnityEngine.Vector4 MaskOffset
        {
            get { return MaskOffsetProperty.GetValue(this); }
            set { MaskOffsetProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.String, TMPro.TextMeshProUGUI, Label> TextProperty = new MappedDependencyProperty<System.String, TMPro.TextMeshProUGUI, Label>("Text", x => x.TextMeshProUGUI, x => x.text, (x, y) => x.text = y);
        /// <summary>A string containing the text to be displayed.</summary>
        public System.String Text
        {
            get { return TextProperty.GetValue(this); }
            set { TextProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsRightToLeftTextProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsRightToLeftText", x => x.TextMeshProUGUI, x => x.isRightToLeftText, (x, y) => x.isRightToLeftText = y);
        /// <summary>Boolean indicating if this text flows from right to left.</summary>
        public System.Boolean IsRightToLeftText
        {
            get { return IsRightToLeftTextProperty.GetValue(this); }
            set { IsRightToLeftTextProperty.SetValue(this, value); }
        }

        public readonly static MappedAssetDependencyProperty<TMP_FontAsset, TMPro.TextMeshProUGUI, Label> FontProperty = new MappedAssetDependencyProperty<TMP_FontAsset, TMPro.TextMeshProUGUI, Label>("Font", x => x.TextMeshProUGUI, (x, y) => x.font = y?.UnityObject);
        /// <summary>The font of the label. The value is the name of the font asset file without extension, e.g. "myfont".</summary>
        public TMP_FontAsset Font
        {
            get { return FontProperty.GetValue(this); }
            set { FontProperty.SetValue(this, value); }
        }

        public readonly static MappedAssetDependencyProperty<MaterialAsset, TMPro.TextMeshProUGUI, Label> FontSharedMaterialProperty = new MappedAssetDependencyProperty<MaterialAsset, TMPro.TextMeshProUGUI, Label>("FontSharedMaterial", x => x.TextMeshProUGUI, (x, y) => x.fontSharedMaterial = y?.UnityObject);
        /// <summary>Shared font material.</summary>
        public MaterialAsset FontSharedMaterial
        {
            get { return FontSharedMaterialProperty.GetValue(this); }
            set { FontSharedMaterialProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Material[], TMPro.TextMeshProUGUI, Label> FontSharedMaterialsProperty = new MappedDependencyProperty<UnityEngine.Material[], TMPro.TextMeshProUGUI, Label>("FontSharedMaterials", x => x.TextMeshProUGUI, x => x.fontSharedMaterials, (x, y) => x.fontSharedMaterials = y);
        /// <summary>Shared font materials.</summary>
        public UnityEngine.Material[] FontSharedMaterials
        {
            get { return FontSharedMaterialsProperty.GetValue(this); }
            set { FontSharedMaterialsProperty.SetValue(this, value); }
        }

        public readonly static MappedAssetDependencyProperty<MaterialAsset, TMPro.TextMeshProUGUI, Label> FontMaterialProperty = new MappedAssetDependencyProperty<MaterialAsset, TMPro.TextMeshProUGUI, Label>("FontMaterial", x => x.TextMeshProUGUI, (x, y) => x.fontMaterial = y?.UnityObject);
        /// <summary>Font material to be used.</summary>
        public MaterialAsset FontMaterial
        {
            get { return FontMaterialProperty.GetValue(this); }
            set { FontMaterialProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Material[], TMPro.TextMeshProUGUI, Label> FontMaterialsProperty = new MappedDependencyProperty<UnityEngine.Material[], TMPro.TextMeshProUGUI, Label>("FontMaterials", x => x.TextMeshProUGUI, x => x.fontMaterials, (x, y) => x.fontMaterials = y);
        /// <summary>Font materials to be used.</summary>
        public UnityEngine.Material[] FontMaterials
        {
            get { return FontMaterialsProperty.GetValue(this); }
            set { FontMaterialsProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Color, TMPro.TextMeshProUGUI, Label> FontColorProperty = new MappedDependencyProperty<UnityEngine.Color, TMPro.TextMeshProUGUI, Label>("FontColor", x => x.TextMeshProUGUI, x => x.color, (x, y) => x.color = y);
        /// <summary>Color of the font.</summary>
        public UnityEngine.Color FontColor
        {
            get { return FontColorProperty.GetValue(this); }
            set { FontColorProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> TextMeshProUGUIAlphaProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("TextMeshProUGUIAlpha", x => x.TextMeshProUGUI, x => x.alpha, (x, y) => x.alpha = y);
        /// <summary>Alpha value of the text.</summary>
        public System.Single TextMeshProUGUIAlpha
        {
            get { return TextMeshProUGUIAlphaProperty.GetValue(this); }
            set { TextMeshProUGUIAlphaProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> EnableVertexGradientProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("EnableVertexGradient", x => x.TextMeshProUGUI, x => x.enableVertexGradient, (x, y) => x.enableVertexGradient = y);
        /// <summary>Determines if Vertex Color Gradient should be used.</summary>
        public System.Boolean EnableVertexGradient
        {
            get { return EnableVertexGradientProperty.GetValue(this); }
            set { EnableVertexGradientProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.VertexGradient, TMPro.TextMeshProUGUI, Label> ColorGradientProperty = new MappedDependencyProperty<TMPro.VertexGradient, TMPro.TextMeshProUGUI, Label>("ColorGradient", x => x.TextMeshProUGUI, x => x.colorGradient, (x, y) => x.colorGradient = y);
        /// <summary>Sets the vertex colors for each of the 4 vertices of the character quads.</summary>
        public TMPro.VertexGradient ColorGradient
        {
            get { return ColorGradientProperty.GetValue(this); }
            set { ColorGradientProperty.SetValue(this, value); }
        }

        public readonly static MappedAssetDependencyProperty<TMP_ColorGradientAsset, TMPro.TextMeshProUGUI, Label> ColorGradientPresetProperty = new MappedAssetDependencyProperty<TMP_ColorGradientAsset, TMPro.TextMeshProUGUI, Label>("ColorGradientPreset", x => x.TextMeshProUGUI, (x, y) => x.colorGradientPreset = y?.UnityObject);
        /// <summary>Set the vertex colors of the 4 vertices of each character quads.</summary>
        public TMP_ColorGradientAsset ColorGradientPreset
        {
            get { return ColorGradientPresetProperty.GetValue(this); }
            set { ColorGradientPresetProperty.SetValue(this, value); }
        }

        public readonly static MappedAssetDependencyProperty<TMP_SpriteAsset, TMPro.TextMeshProUGUI, Label> SpriteAssetProperty = new MappedAssetDependencyProperty<TMP_SpriteAsset, TMPro.TextMeshProUGUI, Label>("SpriteAsset", x => x.TextMeshProUGUI, (x, y) => x.spriteAsset = y?.UnityObject);
        /// <summary>Default Sprite Asset used by the text object.</summary>
        public TMP_SpriteAsset SpriteAsset
        {
            get { return SpriteAssetProperty.GetValue(this); }
            set { SpriteAssetProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> TintAllSpritesProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("TintAllSprites", x => x.TextMeshProUGUI, x => x.tintAllSprites, (x, y) => x.tintAllSprites = y);
        /// <summary>Determines whether or not the sprite color is multiplies by the vertex color of the text.</summary>
        public System.Boolean TintAllSprites
        {
            get { return TintAllSpritesProperty.GetValue(this); }
            set { TintAllSpritesProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> OverrideColorTagsProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("OverrideColorTags", x => x.TextMeshProUGUI, x => x.overrideColorTags, (x, y) => x.overrideColorTags = y);
        /// <summary>This overrides the color tags forcing the vertex colors to be the default font color.</summary>
        public System.Boolean OverrideColorTags
        {
            get { return OverrideColorTagsProperty.GetValue(this); }
            set { OverrideColorTagsProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Color32, TMPro.TextMeshProUGUI, Label> FaceColorProperty = new MappedDependencyProperty<UnityEngine.Color32, TMPro.TextMeshProUGUI, Label>("FaceColor", x => x.TextMeshProUGUI, x => x.faceColor, (x, y) => x.faceColor = y);
        /// <summary>Sets the color of the _FaceColor property of the assigned material. Changing face color will result in an instance of the material.</summary>
        public UnityEngine.Color32 FaceColor
        {
            get { return FaceColorProperty.GetValue(this); }
            set { FaceColorProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Color32, TMPro.TextMeshProUGUI, Label> OutlineColorProperty = new MappedDependencyProperty<UnityEngine.Color32, TMPro.TextMeshProUGUI, Label>("OutlineColor", x => x.TextMeshProUGUI, x => x.outlineColor, (x, y) => x.outlineColor = y);
        /// <summary>Sets the _OutlineColor property of the assigned material. Changing outline color will result in an instance of the material.</summary>
        public UnityEngine.Color32 OutlineColor
        {
            get { return OutlineColorProperty.GetValue(this); }
            set { OutlineColorProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> OutlineWidthProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("OutlineWidth", x => x.TextMeshProUGUI, x => x.outlineWidth, (x, y) => x.outlineWidth = y);
        /// <summary>Sets the thickness of the outline of the font. Setting this value will result in an instance of the material.</summary>
        public System.Single OutlineWidth
        {
            get { return OutlineWidthProperty.GetValue(this); }
            set { OutlineWidthProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> FontSizeProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("FontSize", x => x.TextMeshProUGUI, x => x.fontSize, (x, y) => x.fontSize = y);
        /// <summary>The point size of the font.</summary>
        public System.Single FontSize
        {
            get { return FontSizeProperty.GetValue(this); }
            set { FontSizeProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.FontWeight, TMPro.TextMeshProUGUI, Label> FontWeightProperty = new MappedDependencyProperty<TMPro.FontWeight, TMPro.TextMeshProUGUI, Label>("FontWeight", x => x.TextMeshProUGUI, x => x.fontWeight, (x, y) => x.fontWeight = y);
        /// <summary>Control the weight of the font if an alternative font asset is assigned for the given weight in the font asset editor.</summary>
        public TMPro.FontWeight FontWeight
        {
            get { return FontWeightProperty.GetValue(this); }
            set { FontWeightProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> EnableAutoSizingProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("EnableAutoSizing", x => x.TextMeshProUGUI, x => x.enableAutoSizing, (x, y) => x.enableAutoSizing = y);
        /// <summary>Enable text auto-sizing.</summary>
        public System.Boolean EnableAutoSizing
        {
            get { return EnableAutoSizingProperty.GetValue(this); }
            set { EnableAutoSizingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> FontSizeMinProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("FontSizeMin", x => x.TextMeshProUGUI, x => x.fontSizeMin, (x, y) => x.fontSizeMin = y);
        /// <summary>Minimum point size of the font when text auto-sizing is enabled.</summary>
        public System.Single FontSizeMin
        {
            get { return FontSizeMinProperty.GetValue(this); }
            set { FontSizeMinProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> FontSizeMaxProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("FontSizeMax", x => x.TextMeshProUGUI, x => x.fontSizeMax, (x, y) => x.fontSizeMax = y);
        /// <summary>Maximum point size of the font when text auto-sizing is enabled.</summary>
        public System.Single FontSizeMax
        {
            get { return FontSizeMaxProperty.GetValue(this); }
            set { FontSizeMaxProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.FontStyles, TMPro.TextMeshProUGUI, Label> FontStyleProperty = new MappedDependencyProperty<TMPro.FontStyles, TMPro.TextMeshProUGUI, Label>("FontStyle", x => x.TextMeshProUGUI, x => x.fontStyle, (x, y) => x.fontStyle = y);
        /// <summary>Font style.</summary>
        public TMPro.FontStyles FontStyle
        {
            get { return FontStyleProperty.GetValue(this); }
            set { FontStyleProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.TextAlignmentOptions, TMPro.TextMeshProUGUI, Label> TextAlignmentProperty = new MappedDependencyProperty<TMPro.TextAlignmentOptions, TMPro.TextMeshProUGUI, Label>("TextAlignment", x => x.TextMeshProUGUI, x => x.alignment, (x, y) => x.alignment = y);
        /// <summary>Determines the alignment of the text.</summary>
        public TMPro.TextAlignmentOptions TextAlignment
        {
            get { return TextAlignmentProperty.GetValue(this); }
            set { TextAlignmentProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> CharacterSpacingProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("CharacterSpacing", x => x.TextMeshProUGUI, x => x.characterSpacing, (x, y) => x.characterSpacing = y);
        /// <summary>Determines the spacing between characters in the text.</summary>
        public System.Single CharacterSpacing
        {
            get { return CharacterSpacingProperty.GetValue(this); }
            set { CharacterSpacingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> WordSpacingProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("WordSpacing", x => x.TextMeshProUGUI, x => x.wordSpacing, (x, y) => x.wordSpacing = y);
        /// <summary>The amount of additional spacing between words.</summary>
        public System.Single WordSpacing
        {
            get { return WordSpacingProperty.GetValue(this); }
            set { WordSpacingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> LineSpacingProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("LineSpacing", x => x.TextMeshProUGUI, x => x.lineSpacing, (x, y) => x.lineSpacing = y);
        /// <summary>The amount of additional spacing to add between each lines of text.</summary>
        public System.Single LineSpacing
        {
            get { return LineSpacingProperty.GetValue(this); }
            set { LineSpacingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> LineSpacingAdjustmentProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("LineSpacingAdjustment", x => x.TextMeshProUGUI, x => x.lineSpacingAdjustment, (x, y) => x.lineSpacingAdjustment = y);
        /// <summary>The amount of potential line spacing adjustment before text auto sizing kicks in.</summary>
        public System.Single LineSpacingAdjustment
        {
            get { return LineSpacingAdjustmentProperty.GetValue(this); }
            set { LineSpacingAdjustmentProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> ParagraphSpacingProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("ParagraphSpacing", x => x.TextMeshProUGUI, x => x.paragraphSpacing, (x, y) => x.paragraphSpacing = y);
        /// <summary>The amount of additional spacing to add between each lines of text.</summary>
        public System.Single ParagraphSpacing
        {
            get { return ParagraphSpacingProperty.GetValue(this); }
            set { ParagraphSpacingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> CharacterWidthAdjustmentProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("CharacterWidthAdjustment", x => x.TextMeshProUGUI, x => x.characterWidthAdjustment, (x, y) => x.characterWidthAdjustment = y);
        /// <summary>Percentage the width of characters can be adjusted before text auto-sizing begins to reduce the point size.</summary>
        public System.Single CharacterWidthAdjustment
        {
            get { return CharacterWidthAdjustmentProperty.GetValue(this); }
            set { CharacterWidthAdjustmentProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> EnableWordWrappingProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("EnableWordWrapping", x => x.TextMeshProUGUI, x => x.enableWordWrapping, (x, y) => x.enableWordWrapping = y);
        /// <summary>Controls whether or not word wrapping is applied. When disabled, the text will be displayed on a single line.</summary>
        public System.Boolean EnableWordWrapping
        {
            get { return EnableWordWrappingProperty.GetValue(this); }
            set { EnableWordWrappingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> WordWrappingRatiosProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("WordWrappingRatios", x => x.TextMeshProUGUI, x => x.wordWrappingRatios, (x, y) => x.wordWrappingRatios = y);
        /// <summary>Controls the blending between using character and word spacing to fill-in the space for justified text.</summary>
        public System.Single WordWrappingRatios
        {
            get { return WordWrappingRatiosProperty.GetValue(this); }
            set { WordWrappingRatiosProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.TextOverflowModes, TMPro.TextMeshProUGUI, Label> OverflowModeProperty = new MappedDependencyProperty<TMPro.TextOverflowModes, TMPro.TextMeshProUGUI, Label>("OverflowMode", x => x.TextMeshProUGUI, x => x.overflowMode, (x, y) => x.overflowMode = y);
        /// <summary>Controls the text overflow mode.</summary>
        public TMPro.TextOverflowModes OverflowMode
        {
            get { return OverflowModeProperty.GetValue(this); }
            set { OverflowModeProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.TMP_Text, TMPro.TextMeshProUGUI, Label> LinkedTextComponentProperty = new MappedDependencyProperty<TMPro.TMP_Text, TMPro.TextMeshProUGUI, Label>("LinkedTextComponent", x => x.TextMeshProUGUI, x => x.linkedTextComponent, (x, y) => x.linkedTextComponent = y);
        /// <summary>The linked text component used for flowing the text from one text component to another.</summary>
        public TMPro.TMP_Text LinkedTextComponent
        {
            get { return LinkedTextComponentProperty.GetValue(this); }
            set { LinkedTextComponentProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsLinkedTextComponentProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsLinkedTextComponent", x => x.TextMeshProUGUI, x => x.isLinkedTextComponent, (x, y) => x.isLinkedTextComponent = y);
        /// <summary>Indicates whether this text component is linked to another.</summary>
        public System.Boolean IsLinkedTextComponent
        {
            get { return IsLinkedTextComponentProperty.GetValue(this); }
            set { IsLinkedTextComponentProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> EnableKerningProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("EnableKerning", x => x.TextMeshProUGUI, x => x.enableKerning, (x, y) => x.enableKerning = y);
        /// <summary>Determines if kerning is enabled or disabled.</summary>
        public System.Boolean EnableKerning
        {
            get { return EnableKerningProperty.GetValue(this); }
            set { EnableKerningProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> ExtraPaddingProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("ExtraPadding", x => x.TextMeshProUGUI, x => x.extraPadding, (x, y) => x.extraPadding = y);
        /// <summary>Adds extra padding around each character. This may be necessary when the displayed text is very small to prevent clipping.</summary>
        public System.Boolean ExtraPadding
        {
            get { return ExtraPaddingProperty.GetValue(this); }
            set { ExtraPaddingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> RichTextProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("RichText", x => x.TextMeshProUGUI, x => x.richText, (x, y) => x.richText = y);
        /// <summary>Enables or disables rich text tags.</summary>
        public System.Boolean RichText
        {
            get { return RichTextProperty.GetValue(this); }
            set { RichTextProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> ParseCtrlCharactersProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("ParseCtrlCharacters", x => x.TextMeshProUGUI, x => x.parseCtrlCharacters, (x, y) => x.parseCtrlCharacters = y);
        /// <summary>Enables or Disables parsing of CTRL characters in input text.</summary>
        public System.Boolean ParseCtrlCharacters
        {
            get { return ParseCtrlCharactersProperty.GetValue(this); }
            set { ParseCtrlCharactersProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsOverlayProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsOverlay", x => x.TextMeshProUGUI, x => x.isOverlay, (x, y) => x.isOverlay = y);
        /// <summary>Sets the RenderQueue along with Ztest to force the text to be drawn last and on top of scene elements.</summary>
        public System.Boolean IsOverlay
        {
            get { return IsOverlayProperty.GetValue(this); }
            set { IsOverlayProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsOrthographicProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsOrthographic", x => x.TextMeshProUGUI, x => x.isOrthographic, (x, y) => x.isOrthographic = y);
        /// <summary>Boolean indicating if this graphic is orthographic.</summary>
        public System.Boolean IsOrthographic
        {
            get { return IsOrthographicProperty.GetValue(this); }
            set { IsOrthographicProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> EnableCullingProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("EnableCulling", x => x.TextMeshProUGUI, x => x.enableCulling, (x, y) => x.enableCulling = y);
        /// <summary>Sets the culling on the shaders. Note changing this value will result in an instance of the material.</summary>
        public System.Boolean EnableCulling
        {
            get { return EnableCullingProperty.GetValue(this); }
            set { EnableCullingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IgnoreRectMaskCullingProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IgnoreRectMaskCulling", x => x.TextMeshProUGUI, x => x.ignoreRectMaskCulling, (x, y) => x.ignoreRectMaskCulling = y);
        /// <summary>Controls whether or not the text object will be culled when using a 2D Rect Mask.</summary>
        public System.Boolean IgnoreRectMaskCulling
        {
            get { return IgnoreRectMaskCullingProperty.GetValue(this); }
            set { IgnoreRectMaskCullingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IgnoreVisibilityProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IgnoreVisibility", x => x.TextMeshProUGUI, x => x.ignoreVisibility, (x, y) => x.ignoreVisibility = y);
        /// <summary>Forces objects that are not visible to get refreshed.</summary>
        public System.Boolean IgnoreVisibility
        {
            get { return IgnoreVisibilityProperty.GetValue(this); }
            set { IgnoreVisibilityProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.TextureMappingOptions, TMPro.TextMeshProUGUI, Label> HorizontalMappingProperty = new MappedDependencyProperty<TMPro.TextureMappingOptions, TMPro.TextMeshProUGUI, Label>("HorizontalMapping", x => x.TextMeshProUGUI, x => x.horizontalMapping, (x, y) => x.horizontalMapping = y);
        /// <summary>Controls how the face and outline textures will be applied to the text object.</summary>
        public TMPro.TextureMappingOptions HorizontalMapping
        {
            get { return HorizontalMappingProperty.GetValue(this); }
            set { HorizontalMappingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.TextureMappingOptions, TMPro.TextMeshProUGUI, Label> VerticalMappingProperty = new MappedDependencyProperty<TMPro.TextureMappingOptions, TMPro.TextMeshProUGUI, Label>("VerticalMapping", x => x.TextMeshProUGUI, x => x.verticalMapping, (x, y) => x.verticalMapping = y);
        /// <summary>Controls how the face and outline textures will be applied to the text object.</summary>
        public TMPro.TextureMappingOptions VerticalMapping
        {
            get { return VerticalMappingProperty.GetValue(this); }
            set { VerticalMappingProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label> MappingUvLineOffsetProperty = new MappedDependencyProperty<System.Single, TMPro.TextMeshProUGUI, Label>("MappingUvLineOffset", x => x.TextMeshProUGUI, x => x.mappingUvLineOffset, (x, y) => x.mappingUvLineOffset = y);
        /// <summary>Controls the horizontal offset of the UV of the texture mapping mode for each line of the text object.</summary>
        public System.Single MappingUvLineOffset
        {
            get { return MappingUvLineOffsetProperty.GetValue(this); }
            set { MappingUvLineOffsetProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.TextRenderFlags, TMPro.TextMeshProUGUI, Label> RenderModeProperty = new MappedDependencyProperty<TMPro.TextRenderFlags, TMPro.TextMeshProUGUI, Label>("RenderMode", x => x.TextMeshProUGUI, x => x.renderMode, (x, y) => x.renderMode = y);
        /// <summary>Determines if the Mesh will be rendered.</summary>
        public TMPro.TextRenderFlags RenderMode
        {
            get { return RenderModeProperty.GetValue(this); }
            set { RenderModeProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<TMPro.VertexSortingOrder, TMPro.TextMeshProUGUI, Label> GeometrySortingOrderProperty = new MappedDependencyProperty<TMPro.VertexSortingOrder, TMPro.TextMeshProUGUI, Label>("GeometrySortingOrder", x => x.TextMeshProUGUI, x => x.geometrySortingOrder, (x, y) => x.geometrySortingOrder = y);
        /// <summary>Determines the sorting order of the geometry of the text object.</summary>
        public TMPro.VertexSortingOrder GeometrySortingOrder
        {
            get { return GeometrySortingOrderProperty.GetValue(this); }
            set { GeometrySortingOrderProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> VertexBufferAutoSizeReductionProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("VertexBufferAutoSizeReduction", x => x.TextMeshProUGUI, x => x.vertexBufferAutoSizeReduction, (x, y) => x.vertexBufferAutoSizeReduction = y);
        /// <summary>Determines if the data structures allocated to contain the geometry of the text object will be reduced in size if the number of characters required to display the text is reduced by more than 256 characters.</summary>
        public System.Boolean VertexBufferAutoSizeReduction
        {
            get { return VertexBufferAutoSizeReductionProperty.GetValue(this); }
            set { VertexBufferAutoSizeReductionProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label> FirstVisibleCharacterProperty = new MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label>("FirstVisibleCharacter", x => x.TextMeshProUGUI, x => x.firstVisibleCharacter, (x, y) => x.firstVisibleCharacter = y);
        /// <summary>The first character which should be made visible in conjunction with the Text Overflow Linked mode.</summary>
        public System.Int32 FirstVisibleCharacter
        {
            get { return FirstVisibleCharacterProperty.GetValue(this); }
            set { FirstVisibleCharacterProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label> MaxVisibleCharactersProperty = new MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label>("MaxVisibleCharacters", x => x.TextMeshProUGUI, x => x.maxVisibleCharacters, (x, y) => x.maxVisibleCharacters = y);
        /// <summary>Allows to control how many characters are visible from the input.</summary>
        public System.Int32 MaxVisibleCharacters
        {
            get { return MaxVisibleCharactersProperty.GetValue(this); }
            set { MaxVisibleCharactersProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label> MaxVisibleWordsProperty = new MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label>("MaxVisibleWords", x => x.TextMeshProUGUI, x => x.maxVisibleWords, (x, y) => x.maxVisibleWords = y);
        /// <summary>Allows to control how many words are visible from the input.</summary>
        public System.Int32 MaxVisibleWords
        {
            get { return MaxVisibleWordsProperty.GetValue(this); }
            set { MaxVisibleWordsProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label> MaxVisibleLinesProperty = new MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label>("MaxVisibleLines", x => x.TextMeshProUGUI, x => x.maxVisibleLines, (x, y) => x.maxVisibleLines = y);
        /// <summary>Allows control over how many lines of text are displayed.</summary>
        public System.Int32 MaxVisibleLines
        {
            get { return MaxVisibleLinesProperty.GetValue(this); }
            set { MaxVisibleLinesProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> UseMaxVisibleDescenderProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("UseMaxVisibleDescender", x => x.TextMeshProUGUI, x => x.useMaxVisibleDescender, (x, y) => x.useMaxVisibleDescender = y);
        /// <summary>Determines if the text's vertical alignment will be adjusted based on visible descender of the text.</summary>
        public System.Boolean UseMaxVisibleDescender
        {
            get { return UseMaxVisibleDescenderProperty.GetValue(this); }
            set { UseMaxVisibleDescenderProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label> PageToDisplayProperty = new MappedDependencyProperty<System.Int32, TMPro.TextMeshProUGUI, Label>("PageToDisplay", x => x.TextMeshProUGUI, x => x.pageToDisplay, (x, y) => x.pageToDisplay = y);
        /// <summary>Controls which page of text is shown.</summary>
        public System.Int32 PageToDisplay
        {
            get { return PageToDisplayProperty.GetValue(this); }
            set { PageToDisplayProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.Vector4, TMPro.TextMeshProUGUI, Label> TextMarginProperty = new MappedDependencyProperty<UnityEngine.Vector4, TMPro.TextMeshProUGUI, Label>("TextMargin", x => x.TextMeshProUGUI, x => x.margin, (x, y) => x.margin = y);
        /// <summary>Determines the margin of the text.</summary>
        public UnityEngine.Vector4 TextMargin
        {
            get { return TextMarginProperty.GetValue(this); }
            set { TextMarginProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> HavePropertiesChangedProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("HavePropertiesChanged", x => x.TextMeshProUGUI, x => x.havePropertiesChanged, (x, y) => x.havePropertiesChanged = y);
        /// <summary>Property tracking if any of the text properties have changed. Flag is set before the text is regenerated.</summary>
        public System.Boolean HavePropertiesChanged
        {
            get { return HavePropertiesChangedProperty.GetValue(this); }
            set { HavePropertiesChangedProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsUsingLegacyAnimationComponentProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsUsingLegacyAnimationComponent", x => x.TextMeshProUGUI, x => x.isUsingLegacyAnimationComponent, (x, y) => x.isUsingLegacyAnimationComponent = y);
        /// <summary>Property to handle legacy animation component.</summary>
        public System.Boolean IsUsingLegacyAnimationComponent
        {
            get { return IsUsingLegacyAnimationComponentProperty.GetValue(this); }
            set { IsUsingLegacyAnimationComponentProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsVolumetricTextProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsVolumetricText", x => x.TextMeshProUGUI, x => x.isVolumetricText, (x, y) => x.isVolumetricText = y);
        /// <summary>Determines if the geometry of the characters will be quads or volumetric (cubes).</summary>
        public System.Boolean IsVolumetricText
        {
            get { return IsVolumetricTextProperty.GetValue(this); }
            set { IsVolumetricTextProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<UnityEngine.UI.MaskableGraphic.CullStateChangedEvent, TMPro.TextMeshProUGUI, Label> OnCullStateChangedProperty = new MappedDependencyProperty<UnityEngine.UI.MaskableGraphic.CullStateChangedEvent, TMPro.TextMeshProUGUI, Label>("OnCullStateChanged", x => x.TextMeshProUGUI, x => x.onCullStateChanged, (x, y) => x.onCullStateChanged = y);
        /// <summary>Called when cull state changes.</summary>
        public UnityEngine.UI.MaskableGraphic.CullStateChangedEvent OnCullStateChanged
        {
            get { return OnCullStateChangedProperty.GetValue(this); }
            set { OnCullStateChangedProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> MaskableProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("Maskable", x => x.TextMeshProUGUI, x => x.maskable, (x, y) => x.maskable = y);
        /// <summary>Boolean indicating if graphic is maskable.</summary>
        public System.Boolean Maskable
        {
            get { return MaskableProperty.GetValue(this); }
            set { MaskableProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> IsMaskingGraphicProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("IsMaskingGraphic", x => x.TextMeshProUGUI, x => x.isMaskingGraphic, (x, y) => x.isMaskingGraphic = y);
        /// <summary>Boolean indicating if this is a masking graphic.</summary>
        public System.Boolean IsMaskingGraphic
        {
            get { return IsMaskingGraphicProperty.GetValue(this); }
            set { IsMaskingGraphicProperty.SetValue(this, value); }
        }

        public readonly static MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label> RaycastTargetProperty = new MappedDependencyProperty<System.Boolean, TMPro.TextMeshProUGUI, Label>("RaycastTarget", x => x.TextMeshProUGUI, x => x.raycastTarget, (x, y) => x.raycastTarget = y);
        /// <summary>Boolean indicating if the graphic should be considered a target for raycasting.</summary>
        public System.Boolean RaycastTarget
        {
            get { return RaycastTargetProperty.GetValue(this); }
            set { RaycastTargetProperty.SetValue(this, value); }
        }

        public readonly static MappedAssetDependencyProperty<MaterialAsset, TMPro.TextMeshProUGUI, Label> MaterialProperty = new MappedAssetDependencyProperty<MaterialAsset, TMPro.TextMeshProUGUI, Label>("Material", x => x.TextMeshProUGUI, (x, y) => x.material = y?.UnityObject);
        /// <summary>Material used by graphic.</summary>
        public MaterialAsset Material
        {
            get { return MaterialProperty.GetValue(this); }
            set { MaterialProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class LabelTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return Label;
            }
        }

        private static Template _label;
        public static Template Label
        {
            get
            {
#if UNITY_EDITOR
                if (_label == null || _label.CurrentVersion != Template.Version)
#else
                if (_label == null)
#endif
                {
                    _label = new Template(UIViewTemplates.UIView);
#if UNITY_EDITOR
                    _label.Name = "Label";
                    _label.LineNumber = 0;
                    _label.LinePosition = 0;
#endif
                    Delight.Label.TextAlignmentProperty.SetDefault(_label, TMPro.TextAlignmentOptions.Left);
                    Delight.Label.WidthProperty.SetDefault(_label, new ElementSize(120f, ElementSizeUnit.Pixels));
                    Delight.Label.HeightProperty.SetDefault(_label, new ElementSize(40f, ElementSizeUnit.Pixels));
                    Delight.Label.FontColorProperty.SetDefault(_label, new UnityEngine.Color(0f, 0f, 0f, 1f));
                    Delight.Label.FontSizeProperty.SetDefault(_label, 24f);
                    Delight.Label.FontSizeProperty.SetDefault(_label, 16f);
                }
                return _label;
            }
        }

        #endregion
    }

    #endregion
}

#endif
