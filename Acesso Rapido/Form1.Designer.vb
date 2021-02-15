<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroContextMenu1 = New Wisder.W3Common.WMetroControl.Controls.MetroContextMenu(Me.components)
        Me.NovaPastaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Navegador = New System.Windows.Forms.Panel()
        Me.MetroPanel1 = New Wisder.W3Common.WMetroControl.Controls.MetroPanel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Pesquisartexto = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CurrentFolder = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MetroContextMenu1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaPastaToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(137, 26)
        '
        'NovaPastaToolStripMenuItem
        '
        Me.NovaPastaToolStripMenuItem.Image = CType(resources.GetObject("NovaPastaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovaPastaToolStripMenuItem.Name = "NovaPastaToolStripMenuItem"
        Me.NovaPastaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NovaPastaToolStripMenuItem.Text = "Nova Pasta "
        '
        'Navegador
        '
        Me.Navegador.AutoScroll = True
        Me.Navegador.AutoScrollMinSize = New System.Drawing.Size(20, 20)
        Me.Navegador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Navegador.ContextMenuStrip = Me.MetroContextMenu1
        Me.Navegador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Navegador.Location = New System.Drawing.Point(20, 60)
        Me.Navegador.Name = "Navegador"
        Me.Navegador.Size = New System.Drawing.Size(1108, 587)
        Me.Navegador.TabIndex = 1
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.White
        Me.MetroPanel1.Controls.Add(Me.Button6)
        Me.MetroPanel1.Controls.Add(Me.Pesquisartexto)
        Me.MetroPanel1.Controls.Add(Me.Button5)
        Me.MetroPanel1.Controls.Add(Me.Button3)
        Me.MetroPanel1.Controls.Add(Me.Button2)
        Me.MetroPanel1.Controls.Add(Me.Button4)
        Me.MetroPanel1.Controls.Add(Me.Button1)
        Me.MetroPanel1.Controls.Add(Me.CurrentFolder)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.ForeColor = System.Drawing.Color.Black
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1108, 35)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.UseCustomForeColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(732, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 35)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Pesquisar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Pesquisartexto
        '
        Me.Pesquisartexto.BackColor = System.Drawing.Color.White
        Me.Pesquisartexto.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pesquisartexto.FontSize = Wisder.W3Common.WMetroControl.MetroTextBoxSize.Tall
        Me.Pesquisartexto.Lines = New String(-1) {}
        Me.Pesquisartexto.Location = New System.Drawing.Point(584, 0)
        Me.Pesquisartexto.MaxLength = 32767
        Me.Pesquisartexto.Name = "Pesquisartexto"
        Me.Pesquisartexto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Pesquisartexto.PromptText = "Localizar.."
        Me.Pesquisartexto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Pesquisartexto.SelectedText = ""
        Me.Pesquisartexto.Size = New System.Drawing.Size(148, 35)
        Me.Pesquisartexto.TabIndex = 8
        Me.Pesquisartexto.UseCustomBackColor = True
        Me.Pesquisartexto.UseSelectable = True
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(509, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 35)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Atualizar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseCompatibleTextRendering = True
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(406, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Nova Pasta"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(288, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Adicionar atalho"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(217, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Acima"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Voltar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CurrentFolder
        '
        Me.CurrentFolder.AutoSize = True
        Me.CurrentFolder.BackColor = System.Drawing.Color.Transparent
        Me.CurrentFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CurrentFolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.CurrentFolder.Enabled = False
        Me.CurrentFolder.FlatAppearance.BorderSize = 0
        Me.CurrentFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrentFolder.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentFolder.Location = New System.Drawing.Point(0, 0)
        Me.CurrentFolder.Name = "CurrentFolder"
        Me.CurrentFolder.Size = New System.Drawing.Size(141, 35)
        Me.CurrentFolder.TabIndex = 4
        Me.CurrentFolder.Text = "Inicio"
        Me.CurrentFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CurrentFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CurrentFolder.UseCompatibleTextRendering = True
        Me.CurrentFolder.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "698927-icon-94-folder-512 (2).png")
        Me.ImageList1.Images.SetKeyName(1, "Folder.png")
        Me.ImageList1.Images.SetKeyName(2, "free-12-512.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 667)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.Navegador)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Acesso Rápido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroContextMenu1 As Wisder.W3Common.WMetroControl.Controls.MetroContextMenu
    Friend WithEvents NovaPastaToolStripMenuItem As ToolStripMenuItem
    Public WithEvents Navegador As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents CurrentFolder As Button
    Public WithEvents Button2 As Button
    Public WithEvents Button3 As Button
    Public WithEvents Button4 As Button
    Public WithEvents MetroPanel1 As Wisder.W3Common.WMetroControl.Controls.MetroPanel
    Public WithEvents Button5 As Button
    Friend WithEvents Pesquisartexto As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Button6 As Button
End Class
