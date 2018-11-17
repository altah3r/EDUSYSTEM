Public Class MainUC
    Private Shared _Inestant As MainUC
    Public Shared ReadOnly Property Inestant As MainUC

        Get
            If _Inestant Is Nothing Then
                _Inestant = New MainUC()
            End If
            Return _Inestant
        End Get

    End Property

    Private Sub MainUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy")

    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles tableLayoutPanel1.Paint

    End Sub
End Class
