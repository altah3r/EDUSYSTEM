Public Class MainFrm
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))


    Private Sub PicClose_Click(sender As Object, e As EventArgs) Handles PicClose.Click
        Me.Close()
        Form1.Close()


    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Fillcource(50)


    End Sub

    Private Sub Fillcource(numb As Int32)

        Dim tempP As Panel
        Dim tempL As Label
        Dim tempI As PictureBox


        For index = 1 To numb

            tempP = New Panel()
            tempP.Margin = New System.Windows.Forms.Padding(15)
            tempP.Width = 400
            tempP.Height = 300
            tempP.Name = "NAME1"
            tempP.BackColor = Color.AliceBlue


            tempL = New Label()
            tempL.Text = "العيلوم للسنة التامنة"
            tempL.Dock = System.Windows.Forms.DockStyle.Top
            tempL.AutoSize = True
            tempL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            'tempL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
            'tempL.ForeColor = System.Drawing.Color.White
            tempL.RightToLeft = System.Windows.Forms.RightToLeft.Yes

            tempI = New PictureBox()
            tempI.Dock = System.Windows.Forms.DockStyle.Top
            tempI.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
            tempI.Size = New System.Drawing.Size(400, 180)
            'tempI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

            tempP.Controls.Add(tempL)
            tempP.Controls.Add(tempI)

            FlowLayoutPanel1.Controls.Add(tempP)

        Next

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class