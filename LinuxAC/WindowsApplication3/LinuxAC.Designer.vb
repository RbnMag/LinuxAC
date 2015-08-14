<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinuxAC
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SideWinderTab1 = New WindowsApplication3.SideWinderTab()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SideWinderProgress1 = New WindowsApplication3.SideWinderProgress()
        Me.SideWinderAlert1 = New WindowsApplication3.SideWinderAlert()
        Me.SideWinderBlock1 = New WindowsApplication3.SideWinderBlock()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SideWinderBlock3 = New WindowsApplication3.SideWinderBlock()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SideWinderBlock2 = New WindowsApplication3.SideWinderBlock()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SideWinderTab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SideWinderBlock1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SideWinderBlock3.SuspendLayout()
        Me.SideWinderBlock2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'SideWinderTab1
        '
        Me.SideWinderTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.SideWinderTab1.Controls.Add(Me.TabPage1)
        Me.SideWinderTab1.Controls.Add(Me.TabPage2)
        Me.SideWinderTab1.Controls.Add(Me.TabPage3)
        Me.SideWinderTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideWinderTab1.ItemSize = New System.Drawing.Size(40, 170)
        Me.SideWinderTab1.Location = New System.Drawing.Point(0, 0)
        Me.SideWinderTab1.Multiline = True
        Me.SideWinderTab1.Name = "SideWinderTab1"
        Me.SideWinderTab1.SelectedIndex = 0
        Me.SideWinderTab1.Size = New System.Drawing.Size(778, 367)
        Me.SideWinderTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.SideWinderTab1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.SideWinderProgress1)
        Me.TabPage1.Controls.Add(Me.SideWinderAlert1)
        Me.TabPage1.Controls.Add(Me.SideWinderBlock1)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(174, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(600, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        '
        'SideWinderProgress1
        '
        Me.SideWinderProgress1.Location = New System.Drawing.Point(6, 291)
        Me.SideWinderProgress1.Maximum = 100
        Me.SideWinderProgress1.Minimum = 0
        Me.SideWinderProgress1.Name = "SideWinderProgress1"
        Me.SideWinderProgress1.Size = New System.Drawing.Size(588, 23)
        Me.SideWinderProgress1.TabIndex = 2
        Me.SideWinderProgress1.Text = "SideWinderProgress1"
        Me.SideWinderProgress1.Value = 0
        '
        'SideWinderAlert1
        '
        Me.SideWinderAlert1.Alert = WindowsApplication3.SideWinderAlert.Style.Notice
        Me.SideWinderAlert1.Centered = False
        Me.SideWinderAlert1.Field = False
        Me.SideWinderAlert1.Location = New System.Drawing.Point(6, 248)
        Me.SideWinderAlert1.Name = "SideWinderAlert1"
        Me.SideWinderAlert1.Size = New System.Drawing.Size(588, 37)
        Me.SideWinderAlert1.TabIndex = 1
        Me.SideWinderAlert1.Text = "Waiting..."
        '
        'SideWinderBlock1
        '
        Me.SideWinderBlock1.Controls.Add(Me.Button1)
        Me.SideWinderBlock1.Controls.Add(Me.Label5)
        Me.SideWinderBlock1.Controls.Add(Me.TextBox3)
        Me.SideWinderBlock1.Controls.Add(Me.Label4)
        Me.SideWinderBlock1.Controls.Add(Me.TextBox2)
        Me.SideWinderBlock1.Controls.Add(Me.Label3)
        Me.SideWinderBlock1.Controls.Add(Me.TextBox1)
        Me.SideWinderBlock1.Controls.Add(Me.Label2)
        Me.SideWinderBlock1.Location = New System.Drawing.Point(6, 8)
        Me.SideWinderBlock1.Name = "SideWinderBlock1"
        Me.SideWinderBlock1.Size = New System.Drawing.Size(588, 234)
        Me.SideWinderBlock1.TabIndex = 0
        Me.SideWinderBlock1.TabStop = False
        Me.SideWinderBlock1.Text = "SideWinderBlock1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(572, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(10, 153)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(572, 25)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Username:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(10, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(572, 25)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Host:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(572, 25)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Login Information"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.SideWinderBlock3)
        Me.TabPage2.Controls.Add(Me.SideWinderBlock2)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(174, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SSH"
        '
        'SideWinderBlock3
        '
        Me.SideWinderBlock3.Controls.Add(Me.RichTextBox1)
        Me.SideWinderBlock3.Location = New System.Drawing.Point(6, 176)
        Me.SideWinderBlock3.Name = "SideWinderBlock3"
        Me.SideWinderBlock3.Size = New System.Drawing.Size(586, 175)
        Me.SideWinderBlock3.TabIndex = 1
        Me.SideWinderBlock3.TabStop = False
        Me.SideWinderBlock3.Text = "SideWinderBlock3"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 7)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(574, 162)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'SideWinderBlock2
        '
        Me.SideWinderBlock2.Controls.Add(Me.Button3)
        Me.SideWinderBlock2.Controls.Add(Me.Button2)
        Me.SideWinderBlock2.Controls.Add(Me.ComboBox1)
        Me.SideWinderBlock2.Controls.Add(Me.Label7)
        Me.SideWinderBlock2.Controls.Add(Me.TextBox4)
        Me.SideWinderBlock2.Controls.Add(Me.Label6)
        Me.SideWinderBlock2.Location = New System.Drawing.Point(6, 8)
        Me.SideWinderBlock2.Name = "SideWinderBlock2"
        Me.SideWinderBlock2.Size = New System.Drawing.Size(586, 162)
        Me.SideWinderBlock2.TabIndex = 0
        Me.SideWinderBlock2.TabStop = False
        Me.SideWinderBlock2.Text = "SideWinderBlock2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(211, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Quick Run"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(574, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Execute Command"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Check Harddrive Space", "Process Activity", "System Information", "Who Is Logged In", "Uptime", "Display Processes", "CPU Load & Disk Activity", "Collect System Activity", "Multiprocessor Usage"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 97)
        Me.ComboBox1.MaxDropDownItems = 100
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 25)
        Me.ComboBox1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Custom Command:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 66)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(574, 25)
        Me.TextBox4.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Command Center"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(174, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(600, 359)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(123, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This tool was made by Snowfall."
        '
        'LinuxAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 367)
        Me.Controls.Add(Me.SideWinderTab1)
        Me.MaximizeBox = False
        Me.Name = "LinuxAC"
        Me.Text = "Linux Analytics Center"
        Me.SideWinderTab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SideWinderBlock1.ResumeLayout(False)
        Me.SideWinderBlock1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SideWinderBlock3.ResumeLayout(False)
        Me.SideWinderBlock2.ResumeLayout(False)
        Me.SideWinderBlock2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideWinderTab1 As SideWinderTab
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SideWinderProgress1 As SideWinderProgress
    Friend WithEvents SideWinderAlert1 As SideWinderAlert
    Friend WithEvents SideWinderBlock1 As SideWinderBlock
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents SideWinderBlock2 As SideWinderBlock
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents SideWinderBlock3 As SideWinderBlock
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
End Class
