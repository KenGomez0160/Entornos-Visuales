<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.CheckSuma = New System.Windows.Forms.CheckBox()
        Me.CheckResta = New System.Windows.Forms.CheckBox()
        Me.CheckMulti = New System.Windows.Forms.CheckBox()
        Me.CheckDivicion = New System.Windows.Forms.CheckBox()
        Me.CheckRaiz = New System.Windows.Forms.CheckBox()
        Me.CheckPotencia = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextValor1 = New System.Windows.Forms.TextBox()
        Me.TextValor2 = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TextResultado = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckSuma
        '
        Me.CheckSuma.AutoSize = True
        Me.CheckSuma.Location = New System.Drawing.Point(40, 15)
        Me.CheckSuma.Name = "CheckSuma"
        Me.CheckSuma.Size = New System.Drawing.Size(53, 17)
        Me.CheckSuma.TabIndex = 0
        Me.CheckSuma.Text = "Suma"
        Me.CheckSuma.UseVisualStyleBackColor = True
        '
        'CheckResta
        '
        Me.CheckResta.AutoSize = True
        Me.CheckResta.Location = New System.Drawing.Point(40, 55)
        Me.CheckResta.Name = "CheckResta"
        Me.CheckResta.Size = New System.Drawing.Size(54, 17)
        Me.CheckResta.TabIndex = 1
        Me.CheckResta.Text = "Resta"
        Me.CheckResta.UseVisualStyleBackColor = True
        '
        'CheckMulti
        '
        Me.CheckMulti.AutoSize = True
        Me.CheckMulti.Location = New System.Drawing.Point(40, 95)
        Me.CheckMulti.Name = "CheckMulti"
        Me.CheckMulti.Size = New System.Drawing.Size(90, 17)
        Me.CheckMulti.TabIndex = 2
        Me.CheckMulti.Text = "Multiplicacion"
        Me.CheckMulti.UseVisualStyleBackColor = True
        '
        'CheckDivicion
        '
        Me.CheckDivicion.AutoSize = True
        Me.CheckDivicion.Location = New System.Drawing.Point(40, 138)
        Me.CheckDivicion.Name = "CheckDivicion"
        Me.CheckDivicion.Size = New System.Drawing.Size(64, 17)
        Me.CheckDivicion.TabIndex = 3
        Me.CheckDivicion.Text = "Divicion"
        Me.CheckDivicion.UseVisualStyleBackColor = True
        '
        'CheckRaiz
        '
        Me.CheckRaiz.AutoSize = True
        Me.CheckRaiz.Location = New System.Drawing.Point(40, 182)
        Me.CheckRaiz.Name = "CheckRaiz"
        Me.CheckRaiz.Size = New System.Drawing.Size(47, 17)
        Me.CheckRaiz.TabIndex = 4
        Me.CheckRaiz.Text = "Raiz"
        Me.CheckRaiz.UseVisualStyleBackColor = True
        '
        'CheckPotencia
        '
        Me.CheckPotencia.AutoSize = True
        Me.CheckPotencia.Location = New System.Drawing.Point(40, 231)
        Me.CheckPotencia.Name = "CheckPotencia"
        Me.CheckPotencia.Size = New System.Drawing.Size(68, 17)
        Me.CheckPotencia.TabIndex = 5
        Me.CheckPotencia.Text = "Potencia"
        Me.CheckPotencia.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.CheckSuma)
        Me.Panel1.Controls.Add(Me.CheckPotencia)
        Me.Panel1.Controls.Add(Me.CheckResta)
        Me.Panel1.Controls.Add(Me.CheckRaiz)
        Me.Panel1.Controls.Add(Me.CheckMulti)
        Me.Panel1.Controls.Add(Me.CheckDivicion)
        Me.Panel1.Location = New System.Drawing.Point(339, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 282)
        Me.Panel1.TabIndex = 6
        '
        'TextValor1
        '
        Me.TextValor1.Location = New System.Drawing.Point(163, 76)
        Me.TextValor1.Name = "TextValor1"
        Me.TextValor1.Size = New System.Drawing.Size(131, 20)
        Me.TextValor1.TabIndex = 7
        '
        'TextValor2
        '
        Me.TextValor2.Location = New System.Drawing.Point(163, 160)
        Me.TextValor2.Name = "TextValor2"
        Me.TextValor2.Size = New System.Drawing.Size(131, 20)
        Me.TextValor2.TabIndex = 8
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(330, 325)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(102, 40)
        Me.BtnSalir.TabIndex = 14
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TextResultado
        '
        Me.TextResultado.Location = New System.Drawing.Point(163, 250)
        Me.TextResultado.Name = "TextResultado"
        Me.TextResultado.Size = New System.Drawing.Size(131, 20)
        Me.TextResultado.TabIndex = 15
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(445, 325)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(94, 40)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(565, 407)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TextResultado)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TextValor2)
        Me.Controls.Add(Me.TextValor1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckSuma As CheckBox
    Friend WithEvents CheckResta As CheckBox
    Friend WithEvents CheckMulti As CheckBox
    Friend WithEvents CheckDivicion As CheckBox
    Friend WithEvents CheckRaiz As CheckBox
    Friend WithEvents CheckPotencia As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextValor1 As TextBox
    Friend WithEvents TextValor2 As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TextResultado As TextBox
    Friend WithEvents BtnLimpiar As Button
End Class
