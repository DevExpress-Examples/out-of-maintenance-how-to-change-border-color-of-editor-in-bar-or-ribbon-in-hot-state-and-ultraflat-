Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication154
    Public Class CustomTextEditViewInfo
        Inherits TextEditViewInfo

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub
        Protected Overrides Function GetBorderPainterCore() As BorderPainter
            If Me.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat Then
                Return New CustomUltraFlatBorderPainter()
            End If
            Return MyBase.GetBorderPainterCore()
        End Function
    End Class
End Namespace
