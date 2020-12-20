<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAY))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yearfrombox = New System.Windows.Forms.TextBox()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.aybox = New System.Windows.Forms.TextBox()
        Me.semesterbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.yeartobox = New System.Windows.Forms.TextBox()
        Me.closebtn = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(639, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Dont forget to on your Capslock"
        '
        'yearfrombox
        '
        Me.yearfrombox.Font = New System.Drawing.Font("Stencil", 10.2!)
        Me.yearfrombox.Location = New System.Drawing.Point(235, 169)
        Me.yearfrombox.Multiline = True
        Me.yearfrombox.Name = "yearfrombox"
        Me.yearfrombox.Size = New System.Drawing.Size(633, 32)
        Me.yearfrombox.TabIndex = 39
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.LimeGreen
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.FlatAppearance.BorderSize = 0
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.ForeColor = System.Drawing.Color.Black
        Me.cancelbtn.Location = New System.Drawing.Point(731, 299)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(137, 56)
        Me.cancelbtn.TabIndex = 38
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.FlatAppearance.BorderSize = 0
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.ForeColor = System.Drawing.Color.Black
        Me.savebtn.Location = New System.Drawing.Point(588, 299)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(137, 56)
        Me.savebtn.TabIndex = 36
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'aybox
        '
        Me.aybox.Enabled = False
        Me.aybox.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aybox.Location = New System.Drawing.Point(235, 127)
        Me.aybox.Multiline = True
        Me.aybox.Name = "aybox"
        Me.aybox.Size = New System.Drawing.Size(633, 32)
        Me.aybox.TabIndex = 35
        '
        'semesterbox
        '
        Me.semesterbox.FormattingEnabled = True
        Me.semesterbox.Items.AddRange(New Object() {"1ST SEMESTER", "2ND SEMESTER", "SUMMER"})
        Me.semesterbox.Location = New System.Drawing.Point(235, 254)
        Me.semesterbox.Name = "semesterbox"
        Me.semesterbox.Size = New System.Drawing.Size(633, 24)
        Me.semesterbox.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "YEAR TO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "YEAR FROM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ACADEMIC YEAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 45)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ACADEMIC YEAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 10)
        Me.Panel1.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(42, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "SEMESTER"
        '
        'yeartobox
        '
        Me.yeartobox.Enabled = False
        Me.yeartobox.Font = New System.Drawing.Font("Stencil", 10.2!)
        Me.yeartobox.Location = New System.Drawing.Point(235, 209)
        Me.yeartobox.Multiline = True
        Me.yeartobox.Name = "yeartobox"
        Me.yeartobox.Size = New System.Drawing.Size(633, 32)
        Me.yeartobox.TabIndex = 42
        '
        'closebtn
        '
        Me.closebtn.AutoSize = True
        Me.closebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closebtn.Image = CType(resources.GetObject("closebtn.Image"), System.Drawing.Image)
        Me.closebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closebtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.closebtn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.closebtn.Location = New System.Drawing.Point(783, 26)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(136, 29)
        Me.closebtn.TabIndex = 30
        Me.closebtn.TabStop = True
        Me.closebtn.Text = "       CLOSE"
        '
        'frmAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.yeartobox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.yearfrombox)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.aybox)
        Me.Controls.Add(Me.semesterbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents yearfrombox As TextBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents aybox As TextBox
    Friend WithEvents semesterbox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents closebtn As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents yeartobox As TextBox
End Class
