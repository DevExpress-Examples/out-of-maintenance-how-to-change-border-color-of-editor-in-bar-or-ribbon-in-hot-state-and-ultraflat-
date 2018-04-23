Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors


Namespace WindowsFormsApplication154

    <ToolboxItem(True)> _
    Public Class CustomTextEdit
        Inherits TextEdit

        Shared Sub New()
            RepositoryItemCustomTextEdit.RegisterCustomTextEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomTextEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomTextEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomTextEdit.CustomEditName
            End Get
        End Property
    End Class
End Namespace
