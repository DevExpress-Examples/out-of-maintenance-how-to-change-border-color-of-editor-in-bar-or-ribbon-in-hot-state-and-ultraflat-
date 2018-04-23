using DevExpress.Utils.Drawing;
using System.Drawing;


namespace WindowsFormsApplication154 {
    public class CustomUltraFlatBorderPainter : UltraFlatBorderPainter {
        public CustomUltraFlatBorderPainter() : base() { }
        protected override void DrawSelected(ObjectInfoArgs e) {
            BorderObjectInfoArgs ee = e as BorderObjectInfoArgs;
            Brush pen = e.Cache.GetSolidBrush(ee.BackAppearance.BorderColor);
            e.Cache.Paint.DrawRectangle(e.Graphics, pen, e.Bounds);
        }
    }
}
