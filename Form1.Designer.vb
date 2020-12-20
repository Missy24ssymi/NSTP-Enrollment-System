<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usernamebox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.passwordbox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.loginbtn)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.usernamebox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 417)
        Me.Panel1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Open Sans", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox1.Location = New System.Drawing.Point(414, 255)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(174, 30)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'passwordbox
        '
        Me.passwordbox.BackColor = System.Drawing.Color.MidnightBlue
        Me.passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordbox.Font = New System.Drawing.Font("Open Sans", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordbox.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.passwordbox.Location = New System.Drawing.Point(297, 202)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(291, 37)
        Me.passwordbox.TabIndex = 12
        Me.passwordbox.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(801, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.LimeGreen
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Open Sans Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.loginbtn.Location = New System.Drawing.Point(315, 306)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(195, 64)
        Me.loginbtn.TabIndex = 9
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NSTPERS.My.Resources.Resources._69_512
        Me.PictureBox2.Location = New System.Drawing.Point(228, 194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(228, 245)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 3)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NSTPERS.My.Resources.Resources.account_circle_white_192x192
        Me.PictureBox1.Location = New System.Drawing.Point(228, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'usernamebox
        '
        Me.usernamebox.BackColor = System.Drawing.Color.MidnightBlue
        Me.usernamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usernamebox.Font = New System.Drawing.Font("Open Sans", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamebox.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.usernamebox.Location = New System.Drawing.Point(297, 137)
        Me.usernamebox.Name = "usernamebox"
        Me.usernamebox.Size = New System.Drawing.Size(291, 37)
        Me.usernamebox.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(228, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 3)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NSTP ENROLLMENT SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(843, 422)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents loginbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernamebox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
