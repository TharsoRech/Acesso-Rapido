<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdicionarAtalho
    Inherits Wisder.W3Common.WMetroControl.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdicionarAtalho))
        Me.ShellView1 = New GongSolutions.Shell.ShellView()
        Me.FileDialogToolbar1 = New GongSolutions.Shell.FileDialogToolbar()
        Me.MetroButton1 = New Wisder.W3Common.WMetroControl.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ShellView1
        '
        Me.ShellView1.CurrentFolder = New GongSolutions.Shell.ShellItem("shell:///MyComputerFolder")
        Me.ShellView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShellView1.Location = New System.Drawing.Point(20, 61)
        Me.ShellView1.Name = "ShellView1"
        Me.ShellView1.Size = New System.Drawing.Size(598, 337)
        Me.ShellView1.StatusBar = Nothing
        Me.ShellView1.TabIndex = 0
        Me.ShellView1.View = GongSolutions.Shell.ShellViewStyle.Details
        '
        'FileDialogToolbar1
        '
        Me.FileDialogToolbar1.AutoSize = True
        Me.FileDialogToolbar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FileDialogToolbar1.Location = New System.Drawing.Point(20, 30)
        Me.FileDialogToolbar1.Name = "FileDialogToolbar1"
        Me.FileDialogToolbar1.SelectedFolder = New GongSolutions.Shell.ShellItem("shell:///MyComputerFolder")
        Me.FileDialogToolbar1.ShellView = Me.ShellView1
        Me.FileDialogToolbar1.Size = New System.Drawing.Size(598, 31)
        Me.FileDialogToolbar1.TabIndex = 3
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MetroButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroButton1.Location = New System.Drawing.Point(20, 398)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(598, 45)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Adicionar"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseVisualStyleBackColor = False
        '
        'AdicionarAtalho
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(638, 463)
        Me.Controls.Add(Me.ShellView1)
        Me.Controls.Add(Me.FileDialogToolbar1)
        Me.Controls.Add(Me.MetroButton1)
        Me.DisplayHeader = False
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdicionarAtalho"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileDialogToolbar1 As GongSolutions.Shell.FileDialogToolbar
    Friend WithEvents MetroButton1 As Wisder.W3Common.WMetroControl.Controls.MetroButton
    Public WithEvents ShellView1 As GongSolutions.Shell.ShellView
End Class
