Imports DevExpress.Utils.Drawing
Imports System.Drawing


Namespace WindowsFormsApplication154
    Public Class CustomUltraFlatBorderPainter
        Inherits UltraFlatBorderPainter

        Public Sub New()
            MyBase.New()
        End Sub
        Protected Overrides Sub DrawSelected(ByVal e As ObjectInfoArgs)
            Dim ee As BorderObjectInfoArgs = TryCast(e, BorderObjectInfoArgs)
            Dim pen As Brush = e.Cache.GetSolidBrush(ee.BackAppearance.BorderColor)
            e.Cache.Paint.DrawRectangle(e.Graphics, pen, e.Bounds)
        End Sub
    End Class
End Namespace
