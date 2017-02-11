<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtChar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.txtBinary = New System.Windows.Forms.TextBox()
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.SendBin = New System.Windows.Forms.Button()
        Me.Buttonh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.RichTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.portComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.initButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.baudComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.get_new_port = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxExtData = New System.Windows.Forms.TextBox()
        Me.CheckBoxExtEnter = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExtSpecial = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtChar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtHex)
        Me.GroupBox1.Controls.Add(Me.txtBinary)
        Me.GroupBox1.Controls.Add(Me.txtDec)
        Me.GroupBox1.Controls.Add(Me.SendBin)
        Me.GroupBox1.Controls.Add(Me.Buttonh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EnterButton)
        Me.GroupBox1.Controls.Add(Me.inputTextBox)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.writeButton)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 470)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'txtChar
        '
        Me.txtChar.Location = New System.Drawing.Point(64, 292)
        Me.txtChar.MaxLength = 1
        Me.txtChar.Name = "txtChar"
        Me.txtChar.Size = New System.Drawing.Size(191, 20)
        Me.txtChar.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Char:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Hex:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Bin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Dec:"
        '
        'txtHex
        '
        Me.txtHex.Location = New System.Drawing.Point(64, 265)
        Me.txtHex.MaxLength = 2
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(191, 20)
        Me.txtHex.TabIndex = 47
        '
        'txtBinary
        '
        Me.txtBinary.Location = New System.Drawing.Point(64, 239)
        Me.txtBinary.MaxLength = 8
        Me.txtBinary.Name = "txtBinary"
        Me.txtBinary.Size = New System.Drawing.Size(191, 20)
        Me.txtBinary.TabIndex = 47
        '
        'txtDec
        '
        Me.txtDec.Location = New System.Drawing.Point(64, 213)
        Me.txtDec.MaxLength = 3
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(191, 20)
        Me.txtDec.TabIndex = 47
        '
        'SendBin
        '
        Me.SendBin.Location = New System.Drawing.Point(129, 328)
        Me.SendBin.Name = "SendBin"
        Me.SendBin.Size = New System.Drawing.Size(126, 23)
        Me.SendBin.TabIndex = 46
        Me.SendBin.Text = "Send Byte / Char"
        Me.SendBin.UseVisualStyleBackColor = True
        '
        'Buttonh
        '
        Me.Buttonh.Location = New System.Drawing.Point(9, 157)
        Me.Buttonh.Name = "Buttonh"
        Me.Buttonh.Size = New System.Drawing.Size(173, 25)
        Me.Buttonh.TabIndex = 23
        Me.Buttonh.Text = "Clear output window"
        Me.Buttonh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Input string:"
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(9, 126)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(173, 25)
        Me.EnterButton.TabIndex = 22
        Me.EnterButton.Text = "Send the Enter Character"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputTextBox.Location = New System.Drawing.Point(9, 37)
        Me.inputTextBox.Multiline = False
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.inputTextBox.Size = New System.Drawing.Size(247, 26)
        Me.inputTextBox.TabIndex = 37
        Me.inputTextBox.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(9, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(256, 20)
        Me.CheckBox1.TabIndex = 45
        Me.CheckBox1.Text = "Automatically  Send the input character"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'writeButton
        '
        Me.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.writeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.writeButton.Location = New System.Drawing.Point(261, 37)
        Me.writeButton.Margin = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(83, 26)
        Me.writeButton.TabIndex = 38
        Me.writeButton.Text = "Send"
        Me.writeButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Select COM Port:"
        '
        'portComboBox
        '
        Me.portComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.portComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portComboBox.FormattingEnabled = True
        Me.portComboBox.ItemHeight = 13
        Me.portComboBox.Location = New System.Drawing.Point(125, 25)
        Me.portComboBox.Name = "portComboBox"
        Me.portComboBox.Size = New System.Drawing.Size(108, 21)
        Me.portComboBox.TabIndex = 40
        Me.portComboBox.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Output:"
        '
        'initButton
        '
        Me.initButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.initButton.Enabled = False
        Me.initButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.initButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.initButton.Location = New System.Drawing.Point(245, 52)
        Me.initButton.Name = "initButton"
        Me.initButton.Size = New System.Drawing.Size(135, 35)
        Me.initButton.TabIndex = 34
        Me.initButton.Text = "Connect"
        Me.initButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 566)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Serial Communication media"
        '
        'baudComboBox
        '
        Me.baudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baudComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baudComboBox.FormattingEnabled = True
        Me.baudComboBox.ItemHeight = 13
        Me.baudComboBox.Location = New System.Drawing.Point(125, 52)
        Me.baudComboBox.Name = "baudComboBox"
        Me.baudComboBox.Size = New System.Drawing.Size(108, 21)
        Me.baudComboBox.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Select Baud Rate:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 611)
        Me.TabControl1.TabIndex = 47
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.get_new_port)
        Me.TabPage1.Controls.Add(Me.outputTextBox)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.baudComboBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.portComboBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.initButton)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(754, 585)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Work space"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'get_new_port
        '
        Me.get_new_port.Location = New System.Drawing.Point(245, 24)
        Me.get_new_port.Name = "get_new_port"
        Me.get_new_port.Size = New System.Drawing.Size(135, 23)
        Me.get_new_port.TabIndex = 47
        Me.get_new_port.Text = "Get new COM port list"
        Me.get_new_port.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.outputTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.outputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.outputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.outputTextBox.Location = New System.Drawing.Point(401, 38)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.Size = New System.Drawing.Size(347, 539)
        Me.outputTextBox.TabIndex = 39
        Me.outputTextBox.Text = ""
        Me.outputTextBox.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(754, 585)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxExtData)
        Me.GroupBox2.Controls.Add(Me.CheckBoxExtEnter)
        Me.GroupBox2.Controls.Add(Me.CheckBoxExtSpecial)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last byte of the input string"
        '
        'TextBoxExtData
        '
        Me.TextBoxExtData.Location = New System.Drawing.Point(138, 40)
        Me.TextBoxExtData.MaxLength = 2
        Me.TextBoxExtData.Name = "TextBoxExtData"
        Me.TextBoxExtData.Size = New System.Drawing.Size(36, 20)
        Me.TextBoxExtData.TabIndex = 2
        Me.TextBoxExtData.Tag = "Hex Value"
        '
        'CheckBoxExtEnter
        '
        Me.CheckBoxExtEnter.AutoSize = True
        Me.CheckBoxExtEnter.Location = New System.Drawing.Point(6, 19)
        Me.CheckBoxExtEnter.Name = "CheckBoxExtEnter"
        Me.CheckBoxExtEnter.Size = New System.Drawing.Size(147, 17)
        Me.CheckBoxExtEnter.TabIndex = 0
        Me.CheckBoxExtEnter.Text = "Send the string with Enter"
        Me.CheckBoxExtEnter.UseVisualStyleBackColor = True
        '
        'CheckBoxExtSpecial
        '
        Me.CheckBoxExtSpecial.AutoSize = True
        Me.CheckBoxExtSpecial.Location = New System.Drawing.Point(6, 42)
        Me.CheckBoxExtSpecial.Name = "CheckBoxExtSpecial"
        Me.CheckBoxExtSpecial.Size = New System.Drawing.Size(139, 17)
        Me.CheckBoxExtSpecial.TabIndex = 1
        Me.CheckBoxExtSpecial.Text = "Send a special value 0x"
        Me.CheckBoxExtSpecial.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(754, 585)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Credit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(259, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 24)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Aman Ullah"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(259, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(356, 100)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Student of United International University" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electrical and Electronic Engineering" & _
    " Department" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-mail: amanullah.en@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cell Phone: +880 1823 022586"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(259, 256)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(306, 20)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://www.facebook.com/amanullah.snet"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(782, 632)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial Port Connector Program. Presented by Aman Ullah"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Buttonh As System.Windows.Forms.Button
    Friend WithEvents EnterButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents portComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents initButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents baudComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents outputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents writeButton As System.Windows.Forms.Button
    Friend WithEvents inputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents get_new_port As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SendBin As System.Windows.Forms.Button
    Friend WithEvents txtDec As System.Windows.Forms.TextBox
    Friend WithEvents txtBinary As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxExtEnter As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxExtData As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxExtSpecial As System.Windows.Forms.CheckBox
    Friend WithEvents txtChar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
