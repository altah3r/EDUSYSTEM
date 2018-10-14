Public Class MainFrm



    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Me.Close()
        Form1.Close()


    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim P = New Panel()
        P.Width = 200
        P.Height = 300
        P.Name = "NAME1"
        P.BackColor = Color.AliceBlue


        FlowLayoutPanel1.Controls.Add(P)
        Dim btn = New Button
        btn.Name = "NAME1"
        btn.BackColor = Color.AliceBlue
        P.Controls.Add(btn)









    End Sub




End Class