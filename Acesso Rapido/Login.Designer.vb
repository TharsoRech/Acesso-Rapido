<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits Wisder.W3Common.WMetroControl.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NovaSenha = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Senhaatual = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Senha = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel1 = New Wisder.W3Common.WMetroControl.Controls.MetroPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(10, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 32)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(265, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Mudar senha:"
        '
        'NovaSenha
        '
        Me.NovaSenha.Lines = New String(-1) {}
        Me.NovaSenha.Location = New System.Drawing.Point(263, 177)
        Me.NovaSenha.MaxLength = 32767
        Me.NovaSenha.Name = "NovaSenha"
        Me.NovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.NovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NovaSenha.SelectedText = ""
        Me.NovaSenha.Size = New System.Drawing.Size(188, 23)
        Me.NovaSenha.TabIndex = 30
        Me.NovaSenha.UseSelectable = True
        Me.NovaSenha.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(133, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 32)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Entrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Senhaatual
        '
        Me.Senhaatual.Lines = New String(-1) {}
        Me.Senhaatual.Location = New System.Drawing.Point(263, 119)
        Me.Senhaatual.MaxLength = 32767
        Me.Senhaatual.Name = "Senhaatual"
        Me.Senhaatual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Senhaatual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Senhaatual.SelectedText = ""
        Me.Senhaatual.Size = New System.Drawing.Size(172, 23)
        Me.Senhaatual.TabIndex = 28
        Me.Senhaatual.UseSelectable = True
        Me.Senhaatual.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Senha:"
        '
        'Senha
        '
        Me.Senha.Lines = New String(-1) {}
        Me.Senha.Location = New System.Drawing.Point(10, 172)
        Me.Senha.MaxLength = 32767
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Senha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Senha.SelectedText = ""
        Me.Senha.Size = New System.Drawing.Size(216, 23)
        Me.Senha.TabIndex = 25
        Me.Senha.UseSelectable = True
        Me.Senha.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(265, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nova senha:"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(243, 54)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(10, 206)
        Me.MetroPanel1.TabIndex = 32
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(259, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Senha atual:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(263, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 32)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Alterar senha"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 60)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Você precisa ser administrador " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para executar essa ação,insira a senha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abaixo," &
    "ou fale com o suporte para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mais informaçoes"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NovaSenha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Senhaatual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Senha)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Public WithEvents NovaSenha As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Public WithEvents Senhaatual As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Public WithEvents Senha As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroPanel1 As Wisder.W3Common.WMetroControl.Controls.MetroPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
End Class
