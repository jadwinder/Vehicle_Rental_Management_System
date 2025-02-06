<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cars
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentACarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EconomicalCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUVsCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuxuryCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertibleCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentABikeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelfDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.RentACarToolStripMenuItem, Me.RentABikeToolStripMenuItem, Me.SelfDriveToolStripMenuItem, Me.TermsToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 28)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'RentACarToolStripMenuItem
        '
        Me.RentACarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.EconomicalCarsToolStripMenuItem, Me.SUVsCarsToolStripMenuItem, Me.LuxuryCarsToolStripMenuItem, Me.ConvertibleCarsToolStripMenuItem, Me.AllCarsToolStripMenuItem})
        Me.RentACarToolStripMenuItem.Name = "RentACarToolStripMenuItem"
        Me.RentACarToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.RentACarToolStripMenuItem.Text = "Rent a car"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'EconomicalCarsToolStripMenuItem
        '
        Me.EconomicalCarsToolStripMenuItem.Name = "EconomicalCarsToolStripMenuItem"
        Me.EconomicalCarsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.EconomicalCarsToolStripMenuItem.Text = "Economical Cars"
        '
        'SUVsCarsToolStripMenuItem
        '
        Me.SUVsCarsToolStripMenuItem.Name = "SUVsCarsToolStripMenuItem"
        Me.SUVsCarsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.SUVsCarsToolStripMenuItem.Text = "SUVs Cars"
        '
        'LuxuryCarsToolStripMenuItem
        '
        Me.LuxuryCarsToolStripMenuItem.Name = "LuxuryCarsToolStripMenuItem"
        Me.LuxuryCarsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.LuxuryCarsToolStripMenuItem.Text = "Luxury Cars"
        '
        'ConvertibleCarsToolStripMenuItem
        '
        Me.ConvertibleCarsToolStripMenuItem.Name = "ConvertibleCarsToolStripMenuItem"
        Me.ConvertibleCarsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.ConvertibleCarsToolStripMenuItem.Text = "Convertible Cars"
        '
        'AllCarsToolStripMenuItem
        '
        Me.AllCarsToolStripMenuItem.Name = "AllCarsToolStripMenuItem"
        Me.AllCarsToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.AllCarsToolStripMenuItem.Text = "All Cars"
        '
        'RentABikeToolStripMenuItem
        '
        Me.RentABikeToolStripMenuItem.Name = "RentABikeToolStripMenuItem"
        Me.RentABikeToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.RentABikeToolStripMenuItem.Text = "Rent a bike"
        '
        'SelfDriveToolStripMenuItem
        '
        Me.SelfDriveToolStripMenuItem.Name = "SelfDriveToolStripMenuItem"
        Me.SelfDriveToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.SelfDriveToolStripMenuItem.Text = "Self drive"
        '
        'TermsToolStripMenuItem
        '
        Me.TermsToolStripMenuItem.Name = "TermsToolStripMenuItem"
        Me.TermsToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.TermsToolStripMenuItem.Text = "Terms"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.ContactToolStripMenuItem.Text = "Contact "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 28.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(270, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Economical Cars"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(71, 134)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 17)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Economical Cars"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(296, 134)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(85, 17)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "SUVs Cars"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(487, 134)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(94, 17)
        Me.LinkLabel3.TabIndex = 4
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Luxury Cars"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel4.Location = New System.Drawing.Point(684, 134)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(128, 17)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Convertible Cars"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(455, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(357, 263)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(826, -2)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(18, 446)
        Me.VScrollBar1.TabIndex = 6
        '
        'cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 460)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "cars"
        Me.Text = "cars"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentACarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EconomicalCarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUVsCarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LuxuryCarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertibleCarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllCarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentABikeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelfDriveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TermsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
End Class
