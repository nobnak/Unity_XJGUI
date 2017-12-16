﻿using UnityEngine;

namespace XJGUI
{
    public class BoolGUI : ElementGUI<bool>
    {
        #region Method

        public override bool Show()
        {
            XJGUILayout.HorizontalLayout(()=>
            {
                base.ShowTitle(base.title == null);

                GUILayout.FlexibleSpace();

                base.Value = GUILayout.Toggle(base.Value, "");
            });

            return base.Value;
        }

        #endregion Method
    }
}