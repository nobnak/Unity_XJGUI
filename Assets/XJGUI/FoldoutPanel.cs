﻿using System;
using UnityEngine;

namespace XJGUI
{
    public class FoldoutPanel : PanelGUI<bool>
    {
        #region Field

        private static GUIStyle ButtonStyle;

        #endregion Field

        #region Method

        public override bool Show(params Action[] guiActions)
        {
            if (FoldoutPanel.ButtonStyle == null)
            {
                FoldoutPanel.ButtonStyle = new GUIStyle(GUI.skin.label);
            }

            FoldoutPanel.ButtonStyle.fontStyle = base.boldTitle ? FontStyle.Bold : FontStyle.Normal;

            // NOTE:
            // (value = true  && button = true)  => false
            // (value = true  && button = false) => true
            // (value = false && button = true)  => true
            // (value = false && button = false) => false

            string buttonContent = (base.Value ? "\u25BC " : "\u25BA ") + base.Title;

            base.Value = !(base.Value == GUILayout.Button(buttonContent, FoldoutPanel.ButtonStyle));

            if (base.Value)
            {
                XJGUILayout.VerticalLayout(()=>
                {
                    for (int i = 0; i < guiActions.Length; i++)
                    {
                        guiActions[i]();
                    }
                });
            }

            return base.Value;
        }

        #endregion Method
    }
}