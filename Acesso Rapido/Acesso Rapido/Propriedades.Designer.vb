<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Propriedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Propriedades))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MetroTabControl1 = New Wisder.W3Common.WMetroControl.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Acessadoem = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Adicionadoem = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Caminho = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Descricao = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroTextBox1 = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(224, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Abrir Caminho"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.Padding = New System.Drawing.Point(6, 8)
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(529, 363)
        Me.MetroTabControl1.TabIndex = 13
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Acessadoem)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Adicionadoem)
        Me.TabPage1.Controls.Add(Me.Caminho)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Descricao)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(521, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Última vez Acessado em:"
        '
        'Acessadoem
        '
        Me.Acessadoem.Lines = New String(-1) {}
        Me.Acessadoem.Location = New System.Drawing.Point(26, 259)
        Me.Acessadoem.MaxLength = 32767
        Me.Acessadoem.Name = "Acessadoem"
        Me.Acessadoem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Acessadoem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Acessadoem.SelectedText = ""
        Me.Acessadoem.Size = New System.Drawing.Size(489, 23)
        Me.Acessadoem.TabIndex = 21
        Me.Acessadoem.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Criação:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(383, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 26)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Abrir caminho"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Adicionadoem
        '
        Me.Adicionadoem.Lines = New String(-1) {}
        Me.Adicionadoem.Location = New System.Drawing.Point(26, 193)
        Me.Adicionadoem.MaxLength = 32767
        Me.Adicionadoem.Name = "Adicionadoem"
        Me.Adicionadoem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Adicionadoem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Adicionadoem.SelectedText = ""
        Me.Adicionadoem.Size = New System.Drawing.Size(489, 23)
        Me.Adicionadoem.TabIndex = 18
        Me.Adicionadoem.UseSelectable = True
        '
        'Caminho
        '
        Me.Caminho.Lines = New String(-1) {}
        Me.Caminho.Location = New System.Drawing.Point(26, 120)
        Me.Caminho.MaxLength = 32767
        Me.Caminho.Name = "Caminho"
        Me.Caminho.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Caminho.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Caminho.SelectedText = ""
        Me.Caminho.Size = New System.Drawing.Size(489, 23)
        Me.Caminho.TabIndex = 17
        Me.Caminho.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Caminho:"
        '
        'Descricao
        '
        Me.Descricao.Lines = New String(-1) {}
        Me.Descricao.Location = New System.Drawing.Point(30, 58)
        Me.Descricao.MaxLength = 32767
        Me.Descricao.Name = "Descricao"
        Me.Descricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Descricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Descricao.SelectedText = ""
        Me.Descricao.Size = New System.Drawing.Size(485, 23)
        Me.Descricao.TabIndex = 15
        Me.Descricao.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descrição:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MetroTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(521, 317)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Propriedades"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(515, 311)
        Me.MetroTextBox1.TabIndex = 0
        Me.MetroTextBox1.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(20, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(529, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Propriedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Propriedades"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Propriedades"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Button3 As Button
    Friend WithEvents MetroTabControl1 As Wisder.W3Common.WMetroControl.Controls.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents Adicionadoem As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Caminho As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Public WithEvents Descricao As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Public WithEvents TabPage2 As TabPage
    Public WithEvents MetroTextBox1 As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Public WithEvents Acessadoem As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
End Class
