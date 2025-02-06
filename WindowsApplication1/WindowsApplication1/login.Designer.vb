<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Login_button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 345)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TextBox1.Location = New System.Drawing.Point(487, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 29)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(484, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mobile number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(484, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TextBox2.Location = New System.Drawing.Point(487, 202)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(239, 29)
        Me.TextBox2.TabIndex = 4
        '
        'Login_button
        '
        Me.Login_button.BackColor = System.Drawing.SystemColors.Highlight
        Me.Login_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Login_button.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Login_button.Location = New System.Drawing.Point(487, 252)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(239, 27)
        Me.Login_button.TabIndex = 5
        Me.Login_button.Text = "Log in"
        Me.Login_button.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(486, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Don't have any account?"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Button3.Location = New System.Drawing.Point(487, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(237, 24)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Sign up"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 460)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Login_button)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Login_button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
