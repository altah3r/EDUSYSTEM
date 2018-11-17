<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClass))
        Me.DGVBoard = New System.Windows.Forms.DataGridView()
        Me.panelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnSaveCategory = New System.Windows.Forms.Button()
        Me.line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEx2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVBoard
        '
        Me.DGVBoard.AllowUserToAddRows = False
        Me.DGVBoard.AllowUserToDeleteRows = False
        Me.DGVBoard.AllowUserToResizeColumns = False
        Me.DGVBoard.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arabic Typesetting", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVBoard.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVBoard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGVBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBoard.BackgroundColor = System.Drawing.Color.White
        Me.DGVBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arabic Typesetting", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVBoard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVBoard.ColumnHeadersHeight = 30
        Me.DGVBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column3})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arabic Typesetting", 14.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVBoard.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGVBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVBoard.GridColor = System.Drawing.Color.Silver
        Me.DGVBoard.Location = New System.Drawing.Point(12, 107)
        Me.DGVBoard.MultiSelect = False
        Me.DGVBoard.Name = "DGVBoard"
        Me.DGVBoard.ReadOnly = True
        Me.DGVBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVBoard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arabic Typesetting", 14.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVBoard.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVBoard.RowHeadersVisible = False
        Me.DGVBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.DGVBoard.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVBoard.RowTemplate.Height = 30
        Me.DGVBoard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBoard.Size = New System.Drawing.Size(340, 309)
        Me.DGVBoard.TabIndex = 66
        '
        'panelEx2
        '
        Me.panelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelEx2.Controls.Add(Me.label1)
        Me.panelEx2.Controls.Add(Me.pictureBox1)
        Me.panelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx2.Location = New System.Drawing.Point(1, 0)
        Me.panelEx2.Name = "panelEx2"
        Me.panelEx2.Size = New System.Drawing.Size(362, 34)
        Me.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Teal
        Me.panelEx2.Style.BackColor2.Color = System.Drawing.Color.Teal
        Me.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx2.Style.GradientAngle = 90
        Me.panelEx2.TabIndex = 65
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(5, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "الفصل الدراسي"
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(331, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(27, 28)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'label4
        '
        Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.label4.Location = New System.Drawing.Point(259, 59)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(98, 17)
        Me.label4.TabIndex = 73
        Me.label4.Text = "الفصل الدراسي"
        '
        'btnSaveCategory
        '
        Me.btnSaveCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveCategory.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSaveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnSaveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCategory.Font = New System.Drawing.Font("Arabic Typesetting", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveCategory.Location = New System.Drawing.Point(13, 47)
        Me.btnSaveCategory.Name = "btnSaveCategory"
        Me.btnSaveCategory.Size = New System.Drawing.Size(71, 34)
        Me.btnSaveCategory.TabIndex = 72
        Me.btnSaveCategory.Text = "حفظ"
        Me.btnSaveCategory.UseVisualStyleBackColor = False
        '
        'line3
        '
        Me.line3.AutoSize = True
        Me.line3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.line3.ForeColor = System.Drawing.Color.LightGray
        Me.line3.Location = New System.Drawing.Point(1, 430)
        Me.line3.Name = "line3"
        Me.line3.Size = New System.Drawing.Size(362, 1)
        Me.line3.TabIndex = 71
        Me.line3.Text = "line3"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(46, 81)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(218, 21)
        Me.lblName.TabIndex = 68
        Me.lblName.Text = "يجب ادخال السنة الدراسية"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblName.Visible = False
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtYear.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYear.Border.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYear.Border.BackColorGradientAngle = 5
        Me.txtYear.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.txtYear.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtYear.Border.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder
        Me.txtYear.Border.BorderBottomWidth = 2
        Me.txtYear.Border.BorderColor = System.Drawing.Color.White
        Me.txtYear.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtYear.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtYear.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtYear.Border.Class = "TextBoxBorder"
        Me.txtYear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtYear.Border.UseMnemonic = True
        Me.txtYear.DisabledBackColor = System.Drawing.Color.Transparent
        Me.txtYear.FocusHighlightColor = System.Drawing.Color.White
        Me.txtYear.FocusHighlightEnabled = True
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.txtYear.Location = New System.Drawing.Point(88, 47)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.PreventEnterBeep = True
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtYear.Size = New System.Drawing.Size(168, 34)
        Me.txtYear.TabIndex = 67
        '
        'line1
        '
        Me.line1.AutoSize = True
        Me.line1.Dock = System.Windows.Forms.DockStyle.Right
        Me.line1.ForeColor = System.Drawing.Color.LightGray
        Me.line1.Location = New System.Drawing.Point(363, 0)
        Me.line1.Name = "line1"
        Me.line1.Size = New System.Drawing.Size(1, 431)
        Me.line1.TabIndex = 70
        Me.line1.Text = "line1"
        Me.line1.VerticalLine = True
        '
        'line2
        '
        Me.line2.AutoSize = True
        Me.line2.Dock = System.Windows.Forms.DockStyle.Left
        Me.line2.ForeColor = System.Drawing.Color.LightGray
        Me.line2.Location = New System.Drawing.Point(0, 0)
        Me.line2.Name = "line2"
        Me.line2.Size = New System.Drawing.Size(1, 431)
        Me.line2.TabIndex = 69
        Me.line2.Text = "line2"
        Me.line2.VerticalLine = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arabic Typesetting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.FillWeight = 68.85001!
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "ت.ر"
        Me.Column1.MinimumWidth = 46
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "الفصل الدراسي"
        Me.Column2.MinimumWidth = 230
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "تفعيل"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 50
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "ClassId"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'FrmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 431)
        Me.Controls.Add(Me.DGVBoard)
        Me.Controls.Add(Me.panelEx2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btnSaveCategory)
        Me.Controls.Add(Me.line3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.line1)
        Me.Controls.Add(Me.line2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmClass"
        CType(Me.DGVBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEx2.ResumeLayout(False)
        Me.panelEx2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DGVBoard As DataGridView
    Private WithEvents panelEx2 As DevComponents.DotNetBar.PanelEx
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents btnSaveCategory As Button
    Private WithEvents line3 As DevComponents.DotNetBar.Controls.Line
    Private WithEvents lblName As Label
    Private WithEvents txtYear As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents line1 As DevComponents.DotNetBar.Controls.Line
    Private WithEvents line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
