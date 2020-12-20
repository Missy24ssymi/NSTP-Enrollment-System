<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsection))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sectionbox = New System.Windows.Forms.TextBox()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.sectionidbox = New System.Windows.Forms.TextBox()
        Me.Pcodebox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closebtn = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(639, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Dont forget to on your Capslock"
        '
        'sectionbox
        '
        Me.sectionbox.Font = New System.Drawing.Font("Stencil", 10.2!)
        Me.sectionbox.Location = New System.Drawing.Point(235, 173)
        Me.sectionbox.Multiline = True
        Me.sectionbox.Name = "sectionbox"
        Me.sectionbox.Size = New System.Drawing.Size(633, 32)
        Me.sectionbox.TabIndex = 26
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.LimeGreen
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.FlatAppearance.BorderSize = 0
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.ForeColor = System.Drawing.Color.Black
        Me.cancelbtn.Location = New System.Drawing.Point(731, 250)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(137, 56)
        Me.cancelbtn.TabIndex = 25
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatebtn.FlatAppearance.BorderSize = 0
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebtn.ForeColor = System.Drawing.Color.Black
        Me.updatebtn.Location = New System.Drawing.Point(588, 250)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(137, 56)
        Me.updatebtn.TabIndex = 24
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.FlatAppearance.BorderSize = 0
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.ForeColor = System.Drawing.Color.Black
        Me.savebtn.Location = New System.Drawing.Point(445, 250)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(137, 56)
        Me.savebtn.TabIndex = 23
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'sectionidbox
        '
        Me.sectionidbox.Enabled = False
        Me.sectionidbox.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionidbox.Location = New System.Drawing.Point(235, 131)
        Me.sectionidbox.Multiline = True
        Me.sectionidbox.Name = "sectionidbox"
        Me.sectionidbox.Size = New System.Drawing.Size(633, 32)
        Me.sectionidbox.TabIndex = 22
        '
        'Pcodebox
        '
        Me.Pcodebox.FormattingEnabled = True
        Me.Pcodebox.Items.AddRange(New Object() {"1st YEAR", "2nd YEAR"})
        Me.Pcodebox.Location = New System.Drawing.Point(235, 216)
        Me.Pcodebox.Name = "Pcodebox"
        Me.Pcodebox.Size = New System.Drawing.Size(633, 28)
        Me.Pcodebox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "PROGRAM CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SECTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "STUDENT ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 45)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NSTP PROGRAM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 10)
        Me.Panel1.TabIndex = 15
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
        Me.closebtn.Location = New System.Drawing.Point(783, 30)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(136, 29)
        Me.closebtn.TabIndex = 17
        Me.closebtn.TabStop = True
        Me.closebtn.Text = "       CLOSE"
        '
        'frmsection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sectionbox)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.sectionidbox)
        Me.Controls.Add(Me.Pcodebox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmsection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents sectionbox As TextBox
    Friend WithEvents cancelbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents sectionidbox As TextBox
    Friend WithEvents Pcodebox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents closebtn As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
