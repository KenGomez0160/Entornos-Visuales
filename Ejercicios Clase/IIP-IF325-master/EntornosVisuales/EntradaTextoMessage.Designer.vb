<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaTextoMessage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbSuma = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbResta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMultiplicacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDivision = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opcion2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubFormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondicionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(6, 21)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(78, 35)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(101, 34)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(102, 22)
        Me.txtValor.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(87, 29)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 26)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbSuma
        '
        Me.cmbSuma.FormattingEnabled = True
        Me.cmbSuma.Location = New System.Drawing.Point(11, 57)
        Me.cmbSuma.Name = "cmbSuma"
        Me.cmbSuma.Size = New System.Drawing.Size(121, 24)
        Me.cmbSuma.TabIndex = 4
        Me.cmbSuma.Tag = ""
        Me.cmbSuma.Text = "Mostrar suma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Resta"
        '
        'cmbResta
        '
        Me.cmbResta.FormattingEnabled = True
        Me.cmbResta.Location = New System.Drawing.Point(149, 57)
        Me.cmbResta.Name = "cmbResta"
        Me.cmbResta.Size = New System.Drawing.Size(121, 24)
        Me.cmbResta.TabIndex = 6
        Me.cmbResta.Text = "Mostrar Resta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Multiplicacion"
        '
        'cmbMultiplicacion
        '
        Me.cmbMultiplicacion.FormattingEnabled = True
        Me.cmbMultiplicacion.Location = New System.Drawing.Point(16, 132)
        Me.cmbMultiplicacion.Name = "cmbMultiplicacion"
        Me.cmbMultiplicacion.Size = New System.Drawing.Size(121, 24)
        Me.cmbMultiplicacion.TabIndex = 8
        Me.cmbMultiplicacion.Text = "Mostrar Multiplicacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Division"
        '
        'cmbDivision
        '
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(154, 132)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(121, 24)
        Me.cmbDivision.TabIndex = 10
        Me.cmbDivision.Text = "Mostrar Division"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSuma)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbResta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDivision)
        Me.GroupBox1.Controls.Add(Me.cmbMultiplicacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 175)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnIngresar)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 66)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar valor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 59)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.Opcion2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 28)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.Formulario2ToolStripMenuItem, Me.Formulario3ToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'Opcion2ToolStripMenuItem
        '
        Me.Opcion2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidacionesToolStripMenuItem})
        Me.Opcion2ToolStripMenuItem.Name = "Opcion2ToolStripMenuItem"
        Me.Opcion2ToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.Opcion2ToolStripMenuItem.Text = "Opcion 2"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'Formulario2ToolStripMenuItem
        '
        Me.Formulario2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubFormularioToolStripMenuItem})
        Me.Formulario2ToolStripMenuItem.Name = "Formulario2ToolStripMenuItem"
        Me.Formulario2ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Formulario2ToolStripMenuItem.Text = "Formulario 2"
        '
        'Formulario3ToolStripMenuItem
        '
        Me.Formulario3ToolStripMenuItem.Name = "Formulario3ToolStripMenuItem"
        Me.Formulario3ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Formulario3ToolStripMenuItem.Text = "Formulario 3"
        '
        'SubFormularioToolStripMenuItem
        '
        Me.SubFormularioToolStripMenuItem.Name = "SubFormularioToolStripMenuItem"
        Me.SubFormularioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SubFormularioToolStripMenuItem.Text = "Sub formulario"
        '
        'ValidacionesToolStripMenuItem
        '
        Me.ValidacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorProviderToolStripMenuItem, Me.CondicionalesToolStripMenuItem})
        Me.ValidacionesToolStripMenuItem.Name = "ValidacionesToolStripMenuItem"
        Me.ValidacionesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ValidacionesToolStripMenuItem.Text = "Validaciones"
        '
        'ErrorProviderToolStripMenuItem
        '
        Me.ErrorProviderToolStripMenuItem.Name = "ErrorProviderToolStripMenuItem"
        Me.ErrorProviderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ErrorProviderToolStripMenuItem.Text = "Error Provider"
        '
        'CondicionalesToolStripMenuItem
        '
        Me.CondicionalesToolStripMenuItem.Name = "CondicionalesToolStripMenuItem"
        Me.CondicionalesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CondicionalesToolStripMenuItem.Text = "Condicionales"
        '
        'EntradaTextoMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 468)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EntradaTextoMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EntradaTextoMessage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbSuma As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbResta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMultiplicacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDivision As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubFormularioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Opcion2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondicionalesToolStripMenuItem As ToolStripMenuItem
End Class
