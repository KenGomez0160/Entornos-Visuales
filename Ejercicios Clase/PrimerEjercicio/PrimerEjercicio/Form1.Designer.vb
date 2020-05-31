<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.valor1 = New System.Windows.Forms.Label()
        Me.valor2 = New System.Windows.Forms.Label()
        Me.TxtValor1 = New System.Windows.Forms.TextBox()
        Me.TxtValor2 = New System.Windows.Forms.TextBox()
        Me.suma = New System.Windows.Forms.Label()
        Me.TxtSuma = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtResta = New System.Windows.Forms.TextBox()
        Me.TxtMulti = New System.Windows.Forms.TextBox()
        Me.TxtDivicion = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'valor1
        '
        Me.valor1.AutoSize = True
        Me.valor1.Location = New System.Drawing.Point(72, 54)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(40, 13)
        Me.valor1.TabIndex = 0
        Me.valor1.Text = "Valor 1"
        '
        'valor2
        '
        Me.valor2.AutoSize = True
        Me.valor2.Location = New System.Drawing.Point(72, 129)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(40, 13)
        Me.valor2.TabIndex = 1
        Me.valor2.Text = "Valor 2"
        '
        'TxtValor1
        '
        Me.TxtValor1.Location = New System.Drawing.Point(138, 54)
        Me.TxtValor1.Name = "TxtValor1"
        Me.TxtValor1.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor1.TabIndex = 2
        '
        'TxtValor2
        '
        Me.TxtValor2.Location = New System.Drawing.Point(138, 129)
        Me.TxtValor2.Name = "TxtValor2"
        Me.TxtValor2.Size = New System.Drawing.Size(100, 20)
        Me.TxtValor2.TabIndex = 3
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Location = New System.Drawing.Point(365, 104)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(35, 13)
        Me.suma.TabIndex = 4
        Me.suma.Text = "Resta"
        '
        'TxtSuma
        '
        Me.TxtSuma.Location = New System.Drawing.Point(442, 54)
        Me.TxtSuma.Name = "TxtSuma"
        Me.TxtSuma.Size = New System.Drawing.Size(100, 20)
        Me.TxtSuma.TabIndex = 5
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(138, 324)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(127, 67)
        Me.BtnCalcular.TabIndex = 6
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(365, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Multiplicacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Divicion"
        '
        'TxtResta
        '
        Me.TxtResta.Location = New System.Drawing.Point(442, 104)
        Me.TxtResta.Name = "TxtResta"
        Me.TxtResta.Size = New System.Drawing.Size(100, 20)
        Me.TxtResta.TabIndex = 10
        '
        'TxtMulti
        '
        Me.TxtMulti.Location = New System.Drawing.Point(442, 160)
        Me.TxtMulti.Name = "TxtMulti"
        Me.TxtMulti.Size = New System.Drawing.Size(100, 20)
        Me.TxtMulti.TabIndex = 11
        '
        'TxtDivicion
        '
        Me.TxtDivicion.Location = New System.Drawing.Point(442, 219)
        Me.TxtDivicion.Name = "TxtDivicion"
        Me.TxtDivicion.Size = New System.Drawing.Size(100, 20)
        Me.TxtDivicion.TabIndex = 12
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(432, 324)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 67)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(283, 324)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(127, 67)
        Me.BtnLimpiar.TabIndex = 14
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtDivicion)
        Me.Controls.Add(Me.TxtMulti)
        Me.Controls.Add(Me.TxtResta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtSuma)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.TxtValor2)
        Me.Controls.Add(Me.TxtValor1)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents valor1 As Label
    Friend WithEvents valor2 As Label
    Friend WithEvents TxtValor1 As TextBox
    Friend WithEvents TxtValor2 As TextBox
    Friend WithEvents suma As Label
    Friend WithEvents TxtSuma As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtResta As TextBox
    Friend WithEvents TxtMulti As TextBox
    Friend WithEvents TxtDivicion As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
End Class
