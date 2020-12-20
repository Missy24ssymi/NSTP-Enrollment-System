<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprogram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprogram))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.levelcmbbox = New System.Windows.Forms.ComboBox()
        Me.codebox = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.descriptionbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.closebtn = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 10)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NSTP PROGRAM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PROGRAM CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DESCRIPTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LEVEL"
        '
        'levelcmbbox
        '
        Me.levelcmbbox.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelcmbbox.FormattingEnabled = True
        Me.levelcmbbox.Items.AddRange(New Object() {"1ST YEAR COLLEGE", "2ND YEAR COLLEGE", "3RD YEAR COLLEGE", "4TH YEAR COLLEGE"})
        Me.levelcmbbox.Location = New System.Drawing.Point(235, 204)
        Me.levelcmbbox.Name = "levelcmbbox"
        Me.levelcmbbox.Size = New System.Drawing.Size(642, 28)
        Me.levelcmbbox.TabIndex = 7
        '
        'codebox
        '
        Me.codebox.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codebox.Location = New System.Drawing.Point(235, 119)
        Me.codebox.Multiline = True
        Me.codebox.Name = "codebox"
        Me.codebox.Size = New System.Drawing.Size(642, 32)
        Me.codebox.TabIndex = 8
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.FlatAppearance.BorderSize = 0
        Me.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebtn.ForeColor = System.Drawing.Color.Black
        Me.savebtn.Location = New System.Drawing.Point(454, 245)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(137, 56)
        Me.savebtn.TabIndex = 10
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.LimeGreen
        Me.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatebtn.FlatAppearance.BorderSize = 0
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebtn.ForeColor = System.Drawing.Color.Black
        Me.updatebtn.Location = New System.Drawing.Point(597, 245)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(137, 56)
        Me.updatebtn.TabIndex = 11
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'cancelbtn
        '
        Me.cancelbtn.BackColor = System.Drawing.Color.LimeGreen
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.FlatAppearance.BorderSize = 0
        Me.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbtn.ForeColor = System.Drawing.Color.Black
        Me.cancelbtn.Location = New System.Drawing.Point(740, 245)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(137, 56)
        Me.cancelbtn.TabIndex = 12
        Me.cancelbtn.Text = "CANCEL"
        Me.cancelbtn.UseVisualStyleBackColor = False
        '
        'descriptionbox
        '
        Me.descriptionbox.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionbox.Location = New System.Drawing.Point(235, 161)
        Me.descriptionbox.Multiline = True
        Me.descriptionbox.Name = "descriptionbox"
        Me.descriptionbox.Size = New System.Drawing.Size(642, 32)
        Me.descriptionbox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(669, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dont forget to on your Capslock"
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
        Me.closebtn.Location = New System.Drawing.Point(785, 18)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(136, 29)
        Me.closebtn.TabIndex = 3
        Me.closebtn.TabStop = True
        Me.closebtn.Text = "       CLOSE"
        '
        'frmprogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descriptionbox)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.codebox)
        Me.Controls.Add(Me.levelcmbbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmprogram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmprogram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents closebtn As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents levelcmbbox As ComboBox
    Friend WithEvents codebox As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents descriptionbox As TextBox
    Friend WithEvents Label5 As Label
End Class
