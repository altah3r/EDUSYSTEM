Public Class StudentUC
    Private Shared _Inestant As StudentUC
    Public Shared ReadOnly Property Inestant As StudentUC
        Get
            If _Inestant Is Nothing Then
                _Inestant = New StudentUC()
            End If
            Return _Inestant
        End Get

    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmStudent.ShowDialog()
    End Sub

    Private Sub TxtSearchSubCategory_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
