<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Vehicle_databaseDataSet1 = New WindowsApplication1.vehicle_databaseDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicle_databaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hire Self Driven "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(487, 51)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cars on Rent in Punjab"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(29, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Making hiring a car in Punjab easy. Grab special deals today!"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(613, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(166, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add Cars"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(613, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(166, 36)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Delete Cars"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(613, 311)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(166, 36)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Upcoming Booking"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Location = New System.Drawing.Point(613, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(166, 36)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Update Cars Detail"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(613, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(166, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Booking History"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Location = New System.Drawing.Point(613, 395)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(166, 36)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Book a Car"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(613, 131)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button7.Size = New System.Drawing.Size(166, 36)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Search Cars"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(741, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 18)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 94
        Me.PictureBox7.TabStop = False
        '
        'Vehicle_databaseDataSet1
        '
        Me.Vehicle_databaseDataSet1.DataSetName = "vehicle_databaseDataSet"
        Me.Vehicle_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(664, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "About"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(833, 479)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vehicle_databaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Vehicle_databaseDataSet1 As WindowsApplication1.vehicle_databaseDataSet
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
