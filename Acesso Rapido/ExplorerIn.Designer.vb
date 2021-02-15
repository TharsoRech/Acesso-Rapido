<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExplorerIn
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ShellView1 = New GongSolutions.Shell.ShellView()
        Me.FileDialogToolbar1 = New GongSolutions.Shell.FileDialogToolbar()
        Me.SuspendLayout()
        '
        'ShellView1
        '
        Me.ShellView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShellView1.Location = New System.Drawing.Point(0, 31)
        Me.ShellView1.Name = "ShellView1"
        Me.ShellView1.Size = New System.Drawing.Size(1061, 708)
        Me.ShellView1.StatusBar = Nothing
        Me.ShellView1.TabIndex = 6
        Me.ShellView1.Text = "ShellView1"
        '
        'FileDialogToolbar1
        '
        Me.FileDialogToolbar1.AutoSize = True
        Me.FileDialogToolbar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FileDialogToolbar1.Location = New System.Drawing.Point(0, 0)
        Me.FileDialogToolbar1.Name = "FileDialogToolbar1"
        Me.FileDialogToolbar1.ShellView = Me.ShellView1
        Me.FileDialogToolbar1.Size = New System.Drawing.Size(1061, 31)
        Me.FileDialogToolbar1.TabIndex = 7
        '
        'ExplorerIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ShellView1)
        Me.Controls.Add(Me.FileDialogToolbar1)
        Me.Name = "ExplorerIn"
        Me.Size = New System.Drawing.Size(1061, 739)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ShellView1 As GongSolutions.Shell.ShellView
    Public WithEvents FileDialogToolbar1 As GongSolutions.Shell.FileDialogToolbar
End Class
