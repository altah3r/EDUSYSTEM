<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PicMinimize = New System.Windows.Forms.PictureBox()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Line4 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlMainPage = New System.Windows.Forms.Panel()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PicMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PnlMainPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PicMinimize)
        Me.Panel2.Controls.Add(Me.PicClose)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1072, 38)
        Me.Panel2.TabIndex = 0
        '
        'PicMinimize
        '
        Me.PicMinimize.BackColor = System.Drawing.Color.White
        Me.PicMinimize.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicMinimize.Image = CType(resources.GetObject("PicMinimize.Image"), System.Drawing.Image)
        Me.PicMinimize.Location = New System.Drawing.Point(40, 0)
        Me.PicMinimize.Name = "PicMinimize"
        Me.PicMinimize.Size = New System.Drawing.Size(40, 38)
        Me.PicMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMinimize.TabIndex = 3
        Me.PicMinimize.TabStop = False
        '
        'PicClose
        '
        Me.PicClose.BackColor = System.Drawing.Color.White
        Me.PicClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.PicClose.Image = CType(resources.GetObject("PicClose.Image"), System.Drawing.Image)
        Me.PicClose.Location = New System.Drawing.Point(0, 0)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(40, 38)
        Me.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicClose.TabIndex = 2
        Me.PicClose.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblUsername)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(832, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 38)
        Me.Panel4.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(44, 4)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUsername.Size = New System.Drawing.Size(87, 24)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "أسم المستخدم"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1032, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Line4)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.PnlMainPage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1072, 56)
        Me.Panel3.TabIndex = 1
        '
        'Line4
        '
        Me.Line4.Location = New System.Drawing.Point(160, 9)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(10, 34)
        Me.Line4.TabIndex = 3
        Me.Line4.Text = "0"
        Me.Line4.VerticalLine = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Line3)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(166, 56)
        Me.Panel8.TabIndex = 2
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(-4, 10)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(10, 34)
        Me.Line3.TabIndex = 2
        Me.Line3.Text = "Line3"
        Me.Line3.VerticalLine = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 51)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(166, 5)
        Me.Panel9.TabIndex = 2
        Me.Panel9.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "تسجيل الخروج"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Line2)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(740, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(166, 56)
        Me.Panel5.TabIndex = 1
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(-4, 10)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(10, 34)
        Me.Line2.TabIndex = 2
        Me.Line2.Text = "Line2"
        Me.Line2.VerticalLine = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 51)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(166, 5)
        Me.Panel7.TabIndex = 2
        Me.Panel7.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "لوحة تحكم"
        '
        'PnlMainPage
        '
        Me.PnlMainPage.Controls.Add(Me.Line1)
        Me.PnlMainPage.Controls.Add(Me.Panel6)
        Me.PnlMainPage.Controls.Add(Me.Label1)
        Me.PnlMainPage.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlMainPage.Location = New System.Drawing.Point(906, 0)
        Me.PnlMainPage.Name = "PnlMainPage"
        Me.PnlMainPage.Size = New System.Drawing.Size(166, 56)
        Me.PnlMainPage.TabIndex = 0
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(-4, 10)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(10, 34)
        Me.Line1.TabIndex = 2
        Me.Line1.Text = "Line1"
        Me.Line1.VerticalLine = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 51)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(166, 5)
        Me.Panel6.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "الصفحة الرئسية"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1072, 720)
        Me.Panel1.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(100, 134)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(872, 548)
        Me.Panel14.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(872, 548)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 134)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(100, 548)
        Me.Panel13.TabIndex = 5
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(972, 134)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(100, 548)
        Me.Panel12.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 94)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1072, 40)
        Me.Panel11.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 682)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1072, 38)
        Me.Panel10.TabIndex = 2
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        CType(Me.PicMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PnlMainPage.ResumeLayout(False)
        Me.PnlMainPage.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PicMinimize As PictureBox
    Friend WithEvents PicClose As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PnlMainPage As Panel
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Line4 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
