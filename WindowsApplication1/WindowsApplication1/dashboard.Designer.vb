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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.MenuStrip1.SuspendLayout()
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
        Me.MenuStrip1.TabIndex = 1
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(37, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hire Self Driven "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(570, 59)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cars on Rent in Punjab"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(42, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Making hiring a car in Punjab easy. Grab special deals today!"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(846, 28)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(18, 367)
        Me.VScrollBar1.TabIndex = 5
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(864, 460)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
End Class
