using System;
using System.ComponentModel;
using DevExpress.XtraEditors;


namespace WindowsFormsApplication154 {

    [ToolboxItem(true)]
    public class CustomTextEdit : TextEdit {
        static CustomTextEdit() {
            RepositoryItemCustomTextEdit.RegisterCustomTextEdit();
        }

        public CustomTextEdit() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomTextEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemCustomTextEdit;
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemCustomTextEdit.CustomEditName;
            }
        }
    }
}
