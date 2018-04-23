Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing


Namespace WindowsFormsApplication154
    <UserRepositoryItem("RegisterCustomTextEdit")> _
    Public Class RepositoryItemCustomTextEdit
        Inherits RepositoryItemTextEdit

        Shared Sub New()
            RegisterCustomTextEdit()
        End Sub

        Public Const CustomEditName As String = "CustomTextEdit"

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomTextEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomTextEdit), GetType(RepositoryItemCustomTextEdit), GetType(CustomTextEditViewInfo), New TextEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomTextEdit = TryCast(item, RepositoryItemCustomTextEdit)
                If source Is Nothing Then
                    Return
                End If
                '
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class

End Namespace
