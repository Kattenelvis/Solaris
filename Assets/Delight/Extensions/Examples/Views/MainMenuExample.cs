#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
#endregion

namespace Delight
{
    public partial class MainMenuExample
    {
        public void PlayClick()
        {
            Play?.Invoke(this, null);
        }

        public void ShowOptions()
        {
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
