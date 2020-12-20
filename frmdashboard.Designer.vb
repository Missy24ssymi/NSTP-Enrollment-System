<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.yearbtn = New System.Windows.Forms.Button()
        Me.sectionbtn = New System.Windows.Forms.Button()
        Me.programbtn = New System.Windows.Forms.Button()
        Me.entrybtn = New System.Windows.Forms.Button()
        Me.dashboardbtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, -12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1486, 808)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.logoutbtn)
        Me.Panel3.Controls.Add(Me.yearbtn)
        Me.Panel3.Controls.Add(Me.sectionbtn)
        Me.Panel3.Controls.Add(Me.programbtn)
        Me.Panel3.Controls.Add(Me.entrybtn)
        Me.Panel3.Controls.Add(Me.dashboardbtn)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 808)
        Me.Panel3.TabIndex = 0
        '
        'logoutbtn
        '
        Me.logoutbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutbtn.FlatAppearance.BorderSize = 0
        Me.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutbtn.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logoutbtn.Image = CType(resources.GetObject("logoutbtn.Image"), System.Drawing.Image)
        Me.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.logoutbtn.Location = New System.Drawing.Point(0, 735)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Padding = New System.Windows.Forms.Padding(0, 0, 14, 0)
        Me.logoutbtn.Size = New System.Drawing.Size(332, 73)
        Me.logoutbtn.TabIndex = 15
        Me.logoutbtn.Text = "    LOG OUT"
        Me.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.logoutbtn.UseVisualStyleBackColor = False
        '
        'yearbtn
        '
        Me.yearbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.yearbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.yearbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.yearbtn.FlatAppearance.BorderSize = 0
        Me.yearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearbtn.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.yearbtn.Image = CType(resources.GetObject("yearbtn.Image"), System.Drawing.Image)
        Me.yearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.yearbtn.Location = New System.Drawing.Point(0, 530)
        Me.yearbtn.Name = "yearbtn"
        Me.yearbtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.yearbtn.Size = New System.Drawing.Size(332, 50)
        Me.yearbtn.TabIndex = 14
        Me.yearbtn.Text = "      ACADEMIC YEAR"
        Me.yearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.yearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.yearbtn.UseVisualStyleBackColor = False
        '
        'sectionbtn
        '
        Me.sectionbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sectionbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sectionbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.sectionbtn.FlatAppearance.BorderSize = 0
        Me.sectionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sectionbtn.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sectionbtn.Image = CType(resources.GetObject("sectionbtn.Image"), System.Drawing.Image)
        Me.sectionbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sectionbtn.Location = New System.Drawing.Point(0, 480)
        Me.sectionbtn.Name = "sectionbtn"
        Me.sectionbtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.sectionbtn.Size = New System.Drawing.Size(332, 50)
        Me.sectionbtn.TabIndex = 13
        Me.sectionbtn.Text = "      SECTION"
        Me.sectionbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sectionbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sectionbtn.UseVisualStyleBackColor = False
        '
        'programbtn
        '
        Me.programbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.programbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.programbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.programbtn.FlatAppearance.BorderSize = 0
        Me.programbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.programbtn.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.programbtn.Image = CType(resources.GetObject("programbtn.Image"), System.Drawing.Image)
        Me.programbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.programbtn.Location = New System.Drawing.Point(0, 430)
        Me.programbtn.Name = "programbtn"
        Me.programbtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.programbtn.Size = New System.Drawing.Size(332, 50)
        Me.programbtn.TabIndex = 12
        Me.programbtn.Text = "      PROGRAM"
        Me.programbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.programbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.programbtn.UseVisualStyleBackColor = False
        '
        'entrybtn
        '
        Me.entrybtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.entrybtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.entrybtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.entrybtn.FlatAppearance.BorderSize = 0
        Me.entrybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.entrybtn.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.entrybtn.Image = CType(resources.GetObject("entrybtn.Image"), System.Drawing.Image)
        Me.entrybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.entrybtn.Location = New System.Drawing.Point(0, 380)
        Me.entrybtn.Name = "entrybtn"
        Me.entrybtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.entrybtn.Size = New System.Drawing.Size(332, 50)
        Me.entrybtn.TabIndex = 10
        Me.entrybtn.Text = "      STUDENT ENTRY  "
        Me.entrybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.entrybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.entrybtn.UseVisualStyleBackColor = False
        '
        'dashboardbtn
        '
        Me.dashboardbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboardbtn.FlatAppearance.BorderSize = 0
        Me.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardbtn.Font = New System.Drawing.Font("Open Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dashboardbtn.Image = CType(resources.GetObject("dashboardbtn.Image"), System.Drawing.Image)
        Me.dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardbtn.Location = New System.Drawing.Point(0, 330)
        Me.dashboardbtn.Name = "dashboardbtn"
        Me.dashboardbtn.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.dashboardbtn.Size = New System.Drawing.Size(332, 50)
        Me.dashboardbtn.TabIndex = 11
        Me.dashboardbtn.Text = "      DASHBOARD"
        Me.dashboardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dashboardbtn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 330)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(41, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enrollment System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NSTPERS.My.Resources.Resources._130683894_527370944886244_8169402222384540289_n
        Me.PictureBox1.Location = New System.Drawing.Point(82, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans Semibold", 34.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(68, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 79)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NSTP"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(332, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1164, 825)
        Me.Panel2.TabIndex = 0
        '
        'frmdashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(1486, 796)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmdashboard"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoutbtn As Button
    Friend WithEvents yearbtn As Button
    Friend WithEvents sectionbtn As Button
    Friend WithEvents programbtn As Button
    Friend WithEvents entrybtn As Button
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
End Class
