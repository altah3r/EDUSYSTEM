Imports Educational_System.services

Public Class FrmLogin

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsername.Text) AndAlso String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("يجب ادخال جميع الحقول")
            Exit Sub
        End If
        Try
            Dim _LoginService As New LoginService
            Dim result = _LoginService.loginUser(txtUsername.Text, txtPassword.Text)
            If result = True Then
                Me.Hide()
                MainFrm.ShowDialog()
                Me.Close()
            Else
                MsgBox("كلمة المرور او اسم المستخدم خطا")
            End If
        Catch ex As Exception
            MsgBox("هناك مشكلة في السيرفر")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PICBClose.Click
        Application.Exit()
    End Sub
End Class
