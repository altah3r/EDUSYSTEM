<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.groupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CmbSearchCategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtSearchSubCategory = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.panel1.SuspendLayout()
        Me.groupPanel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.groupPanel3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(964, 630)
        Me.panel1.TabIndex = 1
        '
        'groupPanel3
        '
        Me.groupPanel3.BackColor = System.Drawing.Color.White
        Me.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel3.Controls.Add(Me.TableLayoutPanel2)
        Me.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupPanel3.Location = New System.Drawing.Point(0, 0)
        Me.groupPanel3.Name = "groupPanel3"
        Me.groupPanel3.Size = New System.Drawing.Size(964, 92)
        '
        '
        '
        Me.groupPanel3.Style.BackColor = System.Drawing.Color.White
        Me.groupPanel3.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.groupPanel3.Style.BackColorGradientAngle = 90
        Me.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel3.Style.BorderBottomWidth = 1
        Me.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel3.Style.BorderLeftWidth = 1
        Me.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel3.Style.BorderRightWidth = 1
        Me.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel3.Style.BorderTopWidth = 1
        Me.groupPanel3.Style.CornerDiameter = 4
        Me.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.groupPanel3.TabIndex = 6
        Me.groupPanel3.Text = "بحث عن طالب"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.line2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(152, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(105, 65)
        Me.Panel6.TabIndex = 6
        '
        'line2
        '
        Me.line2.ForeColor = System.Drawing.Color.LightGray
        Me.line2.Location = New System.Drawing.Point(135, 17)
        Me.line2.Name = "line2"
        Me.line2.Size = New System.Drawing.Size(1, 30)
        Me.line2.TabIndex = 45
        Me.line2.Text = "line2"
        Me.line2.VerticalLine = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CmbSearchCategory)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(620, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(229, 65)
        Me.Panel4.TabIndex = 0
        '
        'CmbSearchCategory
        '
        Me.CmbSearchCategory.DisplayMember = "Text"
        Me.CmbSearchCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSearchCategory.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.CmbSearchCategory.ForeColor = System.Drawing.Color.Black
        Me.CmbSearchCategory.FormattingEnabled = True
        Me.CmbSearchCategory.ItemHeight = 28
        Me.CmbSearchCategory.Location = New System.Drawing.Point(9, 15)
        Me.CmbSearchCategory.Name = "CmbSearchCategory"
        Me.CmbSearchCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbSearchCategory.Size = New System.Drawing.Size(216, 34)
        Me.CmbSearchCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmbSearchCategory.TabIndex = 41
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(143, 65)
        Me.Panel5.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.line1)
        Me.Panel8.Controls.Add(Me.label2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(503, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(111, 65)
        Me.Panel8.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.label2.Location = New System.Drawing.Point(7, 23)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(83, 18)
        Me.label2.TabIndex = 38
        Me.label2.Text = "اسم الطالب"
        '
        'line1
        '
        Me.line1.ForeColor = System.Drawing.Color.LightGray
        Me.line1.Location = New System.Drawing.Point(100, 17)
        Me.line1.Name = "line1"
        Me.line1.Size = New System.Drawing.Size(1, 30)
        Me.line1.TabIndex = 39
        Me.line1.Text = "line1"
        Me.line1.VerticalLine = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.label1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(855, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(100, 65)
        Me.Panel9.TabIndex = 5
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.label1.Location = New System.Drawing.Point(3, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 18)
        Me.label1.TabIndex = 37
        Me.label1.Text = "بحث بالقسم"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.38396!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.61604!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel9, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(958, 71)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TxtSearchSubCategory
        '
        Me.TxtSearchSubCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearchSubCategory.BackColor = System.Drawing.Color.GhostWhite
        '
        '
        '
        Me.TxtSearchSubCategory.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtSearchSubCategory.Border.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TxtSearchSubCategory.Border.BackColorGradientAngle = 5
        Me.TxtSearchSubCategory.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.TxtSearchSubCategory.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtSearchSubCategory.Border.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder
        Me.TxtSearchSubCategory.Border.BorderBottomWidth = 2
        Me.TxtSearchSubCategory.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearchSubCategory.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtSearchSubCategory.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtSearchSubCategory.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TxtSearchSubCategory.Border.Class = "TextBoxBorder"
        Me.TxtSearchSubCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TxtSearchSubCategory.Border.UseMnemonic = True
        Me.TxtSearchSubCategory.DisabledBackColor = System.Drawing.Color.White
        Me.TxtSearchSubCategory.FocusHighlightColor = System.Drawing.Color.White
        Me.TxtSearchSubCategory.FocusHighlightEnabled = True
        Me.TxtSearchSubCategory.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.TxtSearchSubCategory.ForeColor = System.Drawing.Color.Black
        Me.TxtSearchSubCategory.Location = New System.Drawing.Point(3, 15)
        Me.TxtSearchSubCategory.Name = "TxtSearchSubCategory"
        Me.TxtSearchSubCategory.PreventEnterBeep = True
        Me.TxtSearchSubCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtSearchSubCategory.Size = New System.Drawing.Size(229, 34)
        Me.TxtSearchSubCategory.TabIndex = 40
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TxtSearchSubCategory)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(263, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(234, 65)
        Me.Panel7.TabIndex = 3
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(964, 630)
        Me.panel1.ResumeLayout(False)
        Me.groupPanel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents groupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel9 As Panel
    Private WithEvents label1 As Label
    Friend WithEvents Panel8 As Panel
    Private WithEvents line1 As DevComponents.DotNetBar.Controls.Line
    Private WithEvents label2 As Label
    Friend WithEvents Panel7 As Panel
    Private WithEvents TxtSearchSubCategory As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Private WithEvents CmbSearchCategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Panel6 As Panel
    Private WithEvents line2 As DevComponents.DotNetBar.Controls.Line
End Class
