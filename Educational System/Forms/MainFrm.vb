Imports DevComponents.DotNetBar.Controls

Public Class MainFrm


    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlClickSubject.Visible = True
        pnlclickCountVedios.Visible = False
        pnlClickTime.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlClickSubject.Visible = False
        pnlclickCountVedios.Visible = False
        pnlClickTime.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlClickSubject.Visible = False
        pnlclickCountVedios.Visible = True
        pnlClickTime.Visible = False
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub LabelX3_Click(sender As Object, e As EventArgs) Handles LabelX3.Click
        Me.Hide()
        FrmControlPanel.ShowDialog()
        Me.Close()
    End Sub
End Class