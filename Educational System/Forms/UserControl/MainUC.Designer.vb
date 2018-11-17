<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUC))
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.panel6.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.panel5.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 50.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.Gray
        Me.lblDate.Location = New System.Drawing.Point(81, 153)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(305, 81)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "1-2-3019"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 40.0!)
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(277, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(152, 65)
        Me.label2.TabIndex = 0
        Me.label2.Text = "عنوان"
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.label2)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel6.Location = New System.Drawing.Point(0, 0)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(492, 69)
        Me.panel6.TabIndex = 0
        '
        'label7
        '
        Me.label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(37, 141)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(382, 22)
        Me.label7.TabIndex = 5
        Me.label7.Text = "اختصار احتصار اختصار اختصار اختصار اختصار اختصار"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(37, 110)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(382, 22)
        Me.label6.TabIndex = 4
        Me.label6.Text = "اختصار احتصار اختصار اختصار اختصار اختصار اختصار"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(37, 79)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(382, 22)
        Me.label5.TabIndex = 3
        Me.label5.Text = "اختصار احتصار اختصار اختصار اختصار اختصار اختصار"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(37, 48)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(382, 22)
        Me.label4.TabIndex = 2
        Me.label4.Text = "اختصار احتصار اختصار اختصار اختصار اختصار اختصار"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(37, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(382, 22)
        Me.label3.TabIndex = 1
        Me.label3.Text = "اختصار احتصار اختصار اختصار اختصار اختصار اختصار"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel7
        '
        Me.panel7.Controls.Add(Me.label7)
        Me.panel7.Controls.Add(Me.label6)
        Me.panel7.Controls.Add(Me.label5)
        Me.panel7.Controls.Add(Me.label4)
        Me.panel7.Controls.Add(Me.label3)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel7.Location = New System.Drawing.Point(0, 69)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(492, 216)
        Me.panel7.TabIndex = 1
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.panel7)
        Me.panel5.Controls.Add(Me.panel6)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel5.Location = New System.Drawing.Point(500, 286)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(492, 285)
        Me.panel5.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 50.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.Gray
        Me.lblTime.Location = New System.Drawing.Point(105, 53)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(252, 81)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "1:2:33 "
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(485, 276)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel4, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel5, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel8, 1, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.47735!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52265!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(995, 574)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.pictureBox2)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(3, 286)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(491, 285)
        Me.panel4.TabIndex = 2
        '
        'panel8
        '
        Me.panel8.Controls.Add(Me.lblDate)
        Me.panel8.Controls.Add(Me.lblTime)
        Me.panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel8.Location = New System.Drawing.Point(500, 3)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(492, 277)
        Me.panel8.TabIndex = 4
        '
        'MainUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "MainUC"
        Me.Size = New System.Drawing.Size(995, 574)
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.panel5.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents timer1 As Timer
    Private WithEvents lblDate As Label
    Private WithEvents label2 As Label
    Private WithEvents panel6 As Panel
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents panel7 As Panel
    Private WithEvents panel5 As Panel
    Private WithEvents lblTime As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents panel4 As Panel
    Private WithEvents panel8 As Panel
End Class
