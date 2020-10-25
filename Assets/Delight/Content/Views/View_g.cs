// Internal view logic generated from "View.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class View
    {
        #region Constructors

        static View()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(ViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(LoadModeProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<Delight.LoadMode> LoadModeProperty = new DependencyProperty<Delight.LoadMode>("LoadMode");
        /// <summary>Enum flags indicating when and how the view should be loaded by the framework. Can be changed when e.g. the view is to be loaded on-demand.</summary>
        public Delight.LoadMode LoadMode
        {
            get { return LoadModeProperty.GetValue(this); }
            set { LoadModeProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class ViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return View;
            }
        }

        private static Template _view;
        public static Template View
        {
            get
            {
#if UNITY_EDITOR
                if (_view == null || _view.CurrentVersion != Template.Version)
#else
                if (_view == null)
#endif
                {
                    _view = new Template(null);
#if UNITY_EDITOR
                    _view.Name = "View";
                    _view.LineNumber = 0;
                    _view.LinePosition = 0;
#endif
                }
                return _view;
            }
        }

        #endregion
    }

    #endregion
}
