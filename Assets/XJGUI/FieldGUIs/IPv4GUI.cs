﻿using System.Reflection;

namespace XJGUI.FieldGUIs
{
    public class IPv4GUI : FieldGUIComponent<string>
    {
        #region Constructor

        public IPv4GUI(object data, FieldInfo fieldInfo, FieldGUIInfo guiInfo)
            : base(data, fieldInfo, guiInfo)
        {
        }

        #endregion Constructor

        #region Method

        protected override void InitializeGUI()
        {
            base.gui = new XJGUI.IPv4GUI()
            {
                Value     = base.fieldInfo.GetValue(base.data).ToString(),
                Title     = base.guiInfo.Title,
                BoldTitle = base.guiInfo.BoldTitle,
            };
        }

        #endregion Method
    }
}