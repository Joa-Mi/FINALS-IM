<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminlogin))
        Me.Back1 = New System.Windows.Forms.Button()
        Me.RoundedPanel1 = New InformationManagement.RoundedPanel()
        Me.txtPassword = New InformationManagement.RoundedTextBox()
        Me.txtUsername = New InformationManagement.RoundedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminlog = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back1
        '
        Me.Back1.BackColor = System.Drawing.Color.White
        Me.Back1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Back1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Back1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back1.ForeColor = System.Drawing.Color.Red
        Me.Back1.Location = New System.Drawing.Point(15, 14)
        Me.Back1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back1.Name = "Back1"
        Me.Back1.Size = New System.Drawing.Size(99, 34)
        Me.Back1.TabIndex = 9
        Me.Back1.Text = "Back"
        Me.Back1.UseVisualStyleBackColor = False
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RoundedPanel1.Controls.Add(Me.txtPassword)
        Me.RoundedPanel1.Controls.Add(Me.txtUsername)
        Me.RoundedPanel1.Controls.Add(Me.Label1)
        Me.RoundedPanel1.Controls.Add(Me.adminlog)
        Me.RoundedPanel1.Controls.Add(Me.Label2)
        Me.RoundedPanel1.Controls.Add(Me.Label3)
        Me.RoundedPanel1.CornerRadius = 24
        Me.RoundedPanel1.Location = New System.Drawing.Point(401, 134)
        Me.RoundedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(411, 362)
        Me.RoundedPanel1.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderRadius = 6
        Me.txtPassword.FocusBorderColor = System.Drawing.Color.Red
        Me.txtPassword.Location = New System.Drawing.Point(77, 217)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.MinimumSize = New System.Drawing.Size(67, 25)
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.Size = New System.Drawing.Size(241, 37)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.TextBoxBackColor = System.Drawing.Color.White
        Me.txtPassword.TextColor = System.Drawing.Color.Black
        Me.txtPassword.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BorderRadius = 6
        Me.txtUsername.FocusBorderColor = System.Drawing.Color.Red
        Me.txtUsername.Location = New System.Drawing.Point(77, 111)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MinimumSize = New System.Drawing.Size(67, 25)
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Size = New System.Drawing.Size(241, 37)
        Me.txtUsername.TabIndex = 9
        Me.txtUsername.TextBoxBackColor = System.Drawing.Color.White
        Me.txtUsername.TextColor = System.Drawing.Color.Black
        Me.txtUsername.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(152, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin"
        '
        'adminlog
        '
        Me.adminlog.BackColor = System.Drawing.Color.White
        Me.adminlog.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.adminlog.FlatAppearance.BorderSize = 0
        Me.adminlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminlog.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminlog.ForeColor = System.Drawing.Color.Red
        Me.adminlog.Location = New System.Drawing.Point(143, 292)
        Me.adminlog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adminlog.Name = "adminlog"
        Me.adminlog.Size = New System.Drawing.Size(131, 32)
        Me.adminlog.TabIndex = 8
        Me.adminlog.Text = "Login"
        Me.adminlog.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(72, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(72, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password :"
        '
        'Adminlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Back1
        Me.ClientSize = New System.Drawing.Size(1193, 550)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.Controls.Add(Me.Back1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Adminlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents adminlog As Button
    Friend WithEvents Back1 As Button
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents txtPassword As RoundedTextBox
    Friend WithEvents txtUsername As RoundedTextBox
End Class
