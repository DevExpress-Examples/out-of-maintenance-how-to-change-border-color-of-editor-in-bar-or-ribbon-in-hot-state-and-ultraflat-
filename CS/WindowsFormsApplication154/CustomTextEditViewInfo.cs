using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication154 {
    public class CustomTextEditViewInfo : TextEditViewInfo {
        public CustomTextEditViewInfo(RepositoryItem item) : base(item) {
        }
        protected override BorderPainter GetBorderPainterCore() {
            if (this.BorderStyle == DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat) {
                return new CustomUltraFlatBorderPainter();
            }
            return base.GetBorderPainterCore();
        }
    }
}
