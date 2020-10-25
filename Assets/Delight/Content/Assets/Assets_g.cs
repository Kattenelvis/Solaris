// Asset data and providers generated from asset content
#region Using Statements
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    #region Asset Bundles

    /// <summary>
    /// AssetBundle data provider. Contains references to all asset bundles in the project.
    /// </summary>
    public partial class AssetBundleData : BindableCollection<AssetBundle>
    {
        #region Fields

        public readonly AssetBundle Bundle1;
        public readonly AssetBundle Bundle2;

        #endregion

        #region Constructor

        public AssetBundleData()
        {
            Bundle1 = new AssetBundle { Id = "Bundle1", StorageMode = StorageMode.Remote };
            Bundle2 = new AssetBundle { Id = "Bundle2", StorageMode = StorageMode.Remote };

            Add(Bundle1);
            Add(Bundle2);
        }

        #endregion
    }

    #endregion

    #region Sprites

    /// <summary>
    /// Manages a UnityEngine.Sprite object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class SpriteAsset : AssetObject<UnityEngine.Sprite>
    {
        public static implicit operator SpriteAsset(UnityEngine.Sprite unityObject)
        {
            return new SpriteAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator SpriteAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Sprites[assetId];
        }
    }

    /// <summary>
    /// SpriteAsset data provider. Contains references to all sprites in the project.
    /// </summary>
    public partial class SpriteAssetData : BindableCollection<SpriteAsset>
    {
        #region Fields

        public readonly SpriteAsset CheckBox;
        public readonly SpriteAsset CheckBoxPressed;
        public readonly SpriteAsset CloseButton;
        public readonly SpriteAsset ComboBoxButton;
        public readonly SpriteAsset ComboBoxButtonPressed;
        public readonly SpriteAsset ContextMenuBg;
        public readonly SpriteAsset Delighticon;
        public readonly SpriteAsset DesignerGrid;
        public readonly SpriteAsset DesignerGrid2;
        public readonly SpriteAsset EditorGrid;
        public readonly SpriteAsset ExpanderArrowDown;
        public readonly SpriteAsset ExpanderArrowRight;
        public readonly SpriteAsset Eye16;
        public readonly SpriteAsset Eye64;
        public readonly SpriteAsset HamburgerMenuIcon;
        public readonly SpriteAsset HamburgerMenuIconPressed;
        public readonly SpriteAsset ListSelection;
        public readonly SpriteAsset Lock;
        public readonly SpriteAsset RadioButton;
        public readonly SpriteAsset RadioButtonPressed;
        public readonly SpriteAsset RainbowSquare;
        public readonly SpriteAsset RoundedSquare10_5px;
        public readonly SpriteAsset Selection;
        public readonly SpriteAsset TooltipArrow;
        public readonly SpriteAsset Frame1;
        public readonly SpriteAsset Frame2;
        public readonly SpriteAsset BigSprite;
        public readonly SpriteAsset Frame3;
        public readonly SpriteAsset Frame4;
        public readonly SpriteAsset LevelSelectBg;
        public readonly SpriteAsset LevelSelectItemBg;
        public readonly SpriteAsset LevelSelectPageButton;
        public readonly SpriteAsset LevelSelectPageButtonPressed;
        public readonly SpriteAsset LevelSelectRightArrow;
        public readonly SpriteAsset MainMenuDemoBackButton;
        public readonly SpriteAsset MainMenuDemoBackButtonPressed;
        public readonly SpriteAsset MainMenuDemoBg;
        public readonly SpriteAsset MainMenuDemoButton;
        public readonly SpriteAsset MainMenuDemoButtonPressed;
        public readonly SpriteAsset Stars0;
        public readonly SpriteAsset Stars1;
        public readonly SpriteAsset Stars2;
        public readonly SpriteAsset Stars3;

        #endregion

        #region Constructor

        public SpriteAssetData()
        {
            CheckBox = new SpriteAsset { Id = "CheckBox", IsResource = true, RelativePath = "Sprites/" };
            CheckBoxPressed = new SpriteAsset { Id = "CheckBoxPressed", IsResource = true, RelativePath = "Sprites/" };
            CloseButton = new SpriteAsset { Id = "CloseButton", IsResource = true, RelativePath = "Sprites/" };
            ComboBoxButton = new SpriteAsset { Id = "ComboBoxButton", IsResource = true, RelativePath = "Sprites/" };
            ComboBoxButtonPressed = new SpriteAsset { Id = "ComboBoxButtonPressed", IsResource = true, RelativePath = "Sprites/" };
            ContextMenuBg = new SpriteAsset { Id = "ContextMenuBg", IsResource = true, RelativePath = "Sprites/" };
            Delighticon = new SpriteAsset { Id = "delight-icon", IsResource = true, RelativePath = "Sprites/" };
            DesignerGrid = new SpriteAsset { Id = "DesignerGrid", IsResource = true, RelativePath = "Sprites/" };
            DesignerGrid2 = new SpriteAsset { Id = "DesignerGrid2", IsResource = true, RelativePath = "Sprites/" };
            EditorGrid = new SpriteAsset { Id = "EditorGrid", IsResource = true, RelativePath = "Sprites/" };
            ExpanderArrowDown = new SpriteAsset { Id = "ExpanderArrowDown", IsResource = true, RelativePath = "Sprites/" };
            ExpanderArrowRight = new SpriteAsset { Id = "ExpanderArrowRight", IsResource = true, RelativePath = "Sprites/" };
            Eye16 = new SpriteAsset { Id = "eye16", IsResource = true, RelativePath = "Sprites/" };
            Eye64 = new SpriteAsset { Id = "eye64", IsResource = true, RelativePath = "Sprites/" };
            HamburgerMenuIcon = new SpriteAsset { Id = "HamburgerMenuIcon", IsResource = true, RelativePath = "Sprites/" };
            HamburgerMenuIconPressed = new SpriteAsset { Id = "HamburgerMenuIconPressed", IsResource = true, RelativePath = "Sprites/" };
            ListSelection = new SpriteAsset { Id = "ListSelection", IsResource = true, RelativePath = "Sprites/" };
            Lock = new SpriteAsset { Id = "Lock", IsResource = true, RelativePath = "Sprites/" };
            RadioButton = new SpriteAsset { Id = "RadioButton", IsResource = true, RelativePath = "Sprites/" };
            RadioButtonPressed = new SpriteAsset { Id = "RadioButtonPressed", IsResource = true, RelativePath = "Sprites/" };
            RainbowSquare = new SpriteAsset { Id = "RainbowSquare", IsResource = true, RelativePath = "Sprites/" };
            RoundedSquare10_5px = new SpriteAsset { Id = "RoundedSquare10_5px", IsResource = true, RelativePath = "Sprites/" };
            Selection = new SpriteAsset { Id = "Selection", IsResource = true, RelativePath = "Sprites/" };
            TooltipArrow = new SpriteAsset { Id = "TooltipArrow", IsResource = true, RelativePath = "Sprites/" };
            Frame1 = new SpriteAsset { Id = "Frame1", AssetBundleId = "Bundle1", RelativePath = "" };
            Frame2 = new SpriteAsset { Id = "Frame2", AssetBundleId = "Bundle1", RelativePath = "" };
            BigSprite = new SpriteAsset { Id = "BigSprite", AssetBundleId = "Bundle2", RelativePath = "" };
            Frame3 = new SpriteAsset { Id = "Frame3", AssetBundleId = "Bundle2", RelativePath = "" };
            Frame4 = new SpriteAsset { Id = "Frame4", AssetBundleId = "Bundle2", RelativePath = "" };
            LevelSelectBg = new SpriteAsset { Id = "LevelSelectBg", IsResource = true, RelativePath = "" };
            LevelSelectItemBg = new SpriteAsset { Id = "LevelSelectItemBg", IsResource = true, RelativePath = "" };
            LevelSelectPageButton = new SpriteAsset { Id = "LevelSelectPageButton", IsResource = true, RelativePath = "" };
            LevelSelectPageButtonPressed = new SpriteAsset { Id = "LevelSelectPageButtonPressed", IsResource = true, RelativePath = "" };
            LevelSelectRightArrow = new SpriteAsset { Id = "LevelSelectRightArrow", IsResource = true, RelativePath = "" };
            MainMenuDemoBackButton = new SpriteAsset { Id = "MainMenuDemoBackButton", IsResource = true, RelativePath = "" };
            MainMenuDemoBackButtonPressed = new SpriteAsset { Id = "MainMenuDemoBackButtonPressed", IsResource = true, RelativePath = "" };
            MainMenuDemoBg = new SpriteAsset { Id = "MainMenuDemoBg", IsResource = true, RelativePath = "" };
            MainMenuDemoButton = new SpriteAsset { Id = "MainMenuDemoButton", IsResource = true, RelativePath = "" };
            MainMenuDemoButtonPressed = new SpriteAsset { Id = "MainMenuDemoButtonPressed", IsResource = true, RelativePath = "" };
            Stars0 = new SpriteAsset { Id = "Stars0", IsResource = true, RelativePath = "" };
            Stars1 = new SpriteAsset { Id = "Stars1", IsResource = true, RelativePath = "" };
            Stars2 = new SpriteAsset { Id = "Stars2", IsResource = true, RelativePath = "" };
            Stars3 = new SpriteAsset { Id = "Stars3", IsResource = true, RelativePath = "" };

            Add(CheckBox);
            Add(CheckBoxPressed);
            Add(CloseButton);
            Add(ComboBoxButton);
            Add(ComboBoxButtonPressed);
            Add(ContextMenuBg);
            Add(Delighticon);
            Add(DesignerGrid);
            Add(DesignerGrid2);
            Add(EditorGrid);
            Add(ExpanderArrowDown);
            Add(ExpanderArrowRight);
            Add(Eye16);
            Add(Eye64);
            Add(HamburgerMenuIcon);
            Add(HamburgerMenuIconPressed);
            Add(ListSelection);
            Add(Lock);
            Add(RadioButton);
            Add(RadioButtonPressed);
            Add(RainbowSquare);
            Add(RoundedSquare10_5px);
            Add(Selection);
            Add(TooltipArrow);
            Add(Frame1);
            Add(Frame2);
            Add(BigSprite);
            Add(Frame3);
            Add(Frame4);
            Add(LevelSelectBg);
            Add(LevelSelectItemBg);
            Add(LevelSelectPageButton);
            Add(LevelSelectPageButtonPressed);
            Add(LevelSelectRightArrow);
            Add(MainMenuDemoBackButton);
            Add(MainMenuDemoBackButtonPressed);
            Add(MainMenuDemoBg);
            Add(MainMenuDemoButton);
            Add(MainMenuDemoButtonPressed);
            Add(Stars0);
            Add(Stars1);
            Add(Stars2);
            Add(Stars3);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static SpriteAssetData Sprites = new SpriteAssetData();
    }

    #endregion

    #region Materials

    /// <summary>
    /// Manages a UnityEngine.Material object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class MaterialAsset : AssetObject<UnityEngine.Material>
    {
        public static implicit operator MaterialAsset(UnityEngine.Material unityObject)
        {
            return new MaterialAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator MaterialAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Materials[assetId];
        }
    }

    /// <summary>
    /// MaterialAsset data provider. Contains references to all materials in the project.
    /// </summary>
    public partial class MaterialAssetData : BindableCollection<MaterialAsset>
    {
        #region Fields

        public readonly MaterialAsset UIFastDefault;

        #endregion

        #region Constructor

        public MaterialAssetData()
        {
            UIFastDefault = new MaterialAsset { Id = "UI-Fast-Default", IsResource = true, RelativePath = "Materials/" };

            Add(UIFastDefault);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static MaterialAssetData Materials = new MaterialAssetData();
    }

    #endregion

    #region Fonts

    /// <summary>
    /// Manages a UnityEngine.Font object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class FontAsset : AssetObject<UnityEngine.Font>
    {
        public static implicit operator FontAsset(UnityEngine.Font unityObject)
        {
            return new FontAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator FontAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Fonts[assetId];
        }
    }

    /// <summary>
    /// FontAsset data provider. Contains references to all fonts in the project.
    /// </summary>
    public partial class FontAssetData : BindableCollection<FontAsset>
    {
        #region Fields

        public readonly FontAsset Ebrima;
        public readonly FontAsset InconsolataRegular;
        public readonly FontAsset SegoeUI;
        public readonly FontAsset AveriaSansLibreBold;

        #endregion

        #region Constructor

        public FontAssetData()
        {
            Ebrima = new FontAsset { Id = "Ebrima", IsResource = true, RelativePath = "Fonts/" };
            InconsolataRegular = new FontAsset { Id = "Inconsolata-Regular", IsResource = true, RelativePath = "Fonts/" };
            SegoeUI = new FontAsset { Id = "Segoe UI", IsResource = true, RelativePath = "Fonts/" };
            AveriaSansLibreBold = new FontAsset { Id = "AveriaSansLibre-Bold", IsResource = true, RelativePath = "" };

            Add(Ebrima);
            Add(InconsolataRegular);
            Add(SegoeUI);
            Add(AveriaSansLibreBold);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static FontAssetData Fonts = new FontAssetData();
    }

    #endregion

    #region TMP_FontAssets

    /// <summary>
    /// Manages a TMPro.TMP_FontAsset object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TMP_FontAsset : AssetObject<TMPro.TMP_FontAsset>
    {
        public static implicit operator TMP_FontAsset(TMPro.TMP_FontAsset unityObject)
        {
            return new TMP_FontAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TMP_FontAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.TMP_FontAssets[assetId];
        }
    }

    /// <summary>
    /// TMP_FontAsset data provider. Contains references to all tmp_fontassets in the project.
    /// </summary>
    public partial class TMP_FontAssetData : BindableCollection<TMP_FontAsset>
    {
        #region Fields

        public readonly TMP_FontAsset EbrimaSDF;
        public readonly TMP_FontAsset InconsolataRegularSDF;
        public readonly TMP_FontAsset SegoeUISDF;
        public readonly TMP_FontAsset AveriaSansLibreBoldSDF;

        #endregion

        #region Constructor

        public TMP_FontAssetData()
        {
            EbrimaSDF = new TMP_FontAsset { Id = "Ebrima SDF", IsResource = true, RelativePath = "Fonts/" };
            InconsolataRegularSDF = new TMP_FontAsset { Id = "Inconsolata-Regular SDF", IsResource = true, RelativePath = "Fonts/" };
            SegoeUISDF = new TMP_FontAsset { Id = "Segoe UI SDF", IsResource = true, RelativePath = "Fonts/" };
            AveriaSansLibreBoldSDF = new TMP_FontAsset { Id = "AveriaSansLibre-Bold SDF", IsResource = true, RelativePath = "" };

            Add(EbrimaSDF);
            Add(InconsolataRegularSDF);
            Add(SegoeUISDF);
            Add(AveriaSansLibreBoldSDF);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static TMP_FontAssetData TMP_FontAssets = new TMP_FontAssetData();
    }

    #endregion

    #region Shaders

    /// <summary>
    /// Manages a UnityEngine.Shader object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class ShaderAsset : AssetObject<UnityEngine.Shader>
    {
        public static implicit operator ShaderAsset(UnityEngine.Shader unityObject)
        {
            return new ShaderAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator ShaderAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Shaders[assetId];
        }
    }

    /// <summary>
    /// ShaderAsset data provider. Contains references to all shaders in the project.
    /// </summary>
    public partial class ShaderAssetData : BindableCollection<ShaderAsset>
    {
        #region Fields

        public readonly ShaderAsset UIFastDefault;

        #endregion

        #region Constructor

        public ShaderAssetData()
        {
            UIFastDefault = new ShaderAsset { Id = "UI-Fast-Default", IsResource = true, RelativePath = "Shaders/" };

            Add(UIFastDefault);
        }

        #endregion
    }

    public static partial class Assets
    {
        public static ShaderAssetData Shaders = new ShaderAssetData();
    }

    #endregion

    #region Textures

    /// <summary>
    /// Manages a UnityEngine.Texture object. Loads/unloads the asset on-demand as it's requested by views.
    /// </summary>
    public partial class TextureAsset : AssetObject<UnityEngine.Texture>
    {
        public static implicit operator TextureAsset(UnityEngine.Texture unityObject)
        {
            return new TextureAsset { UnityObject = unityObject, IsUnmanaged = true };
        }

        public static implicit operator TextureAsset(string assetId)
        {
            if (String.IsNullOrEmpty(assetId))
                return null;

            if (assetId.StartsWith("?"))
                assetId = assetId.Substring(1);

            return Assets.Textures[assetId];
        }
    }

    /// <summary>
    /// TextureAsset data provider. Contains references to all textures in the project.
    /// </summary>
    public partial class TextureAssetData : BindableCollection<TextureAsset>
    {
    }

    public static partial class Assets
    {
        public static TextureAssetData Textures = new TextureAssetData();
    }

    #endregion
}
