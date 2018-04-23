using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Drawing;


namespace WindowsFormsApplication154 {
    [UserRepositoryItem("RegisterCustomTextEdit")]
    public class RepositoryItemCustomTextEdit : RepositoryItemTextEdit {
        static RepositoryItemCustomTextEdit() {
            RegisterCustomTextEdit();
        }

        public const string CustomEditName = "CustomTextEdit";

        public RepositoryItemCustomTextEdit() {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterCustomTextEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomTextEdit), typeof(RepositoryItemCustomTextEdit), typeof(CustomTextEditViewInfo), new TextEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomTextEdit source = item as RepositoryItemCustomTextEdit;
                if (source == null) return;
                //
            } finally {
                EndUpdate();
            }
        }
    }

}
