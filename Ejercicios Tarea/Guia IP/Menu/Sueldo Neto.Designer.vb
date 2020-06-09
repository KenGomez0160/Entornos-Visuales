<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sueldo_Neto
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
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtImpuestoAnual = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSueldoAnual = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSueldoNeto = New System.Windows.Forms.TextBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtSueldoMensual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DimGray
        Me.BtnNuevo.Enabled = False
        Me.BtnNuevo.Location = New System.Drawing.Point(175, 166)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(109, 57)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.TxtImpuestoAnual)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtSueldoAnual)
        Me.Panel2.Location = New System.Drawing.Point(106, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 100)
        Me.Panel2.TabIndex = 23
        '
        'TxtImpuestoAnual
        '
        Me.TxtImpuestoAnual.Location = New System.Drawing.Point(343, 38)
        Me.TxtImpuestoAnual.Name = "TxtImpuestoAnual"
        Me.TxtImpuestoAnual.ReadOnly = True
        Me.TxtImpuestoAnual.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuestoAnual.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Impuesto Anual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Sueldo anual"
        '
        'TxtSueldoAnual
        '
        Me.TxtSueldoAnual.Location = New System.Drawing.Point(92, 35)
        Me.TxtSueldoAnual.Name = "TxtSueldoAnual"
        Me.TxtSueldoAnual.ReadOnly = True
        Me.TxtSueldoAnual.Size = New System.Drawing.Size(100, 20)
        Me.TxtSueldoAnual.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtSueldoNeto)
        Me.Panel1.Controls.Add(Me.TxtImpuesto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(452, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 191)
        Me.Panel1.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sueldo Neto"
        '
        'TxtSueldoNeto
        '
        Me.TxtSueldoNeto.Location = New System.Drawing.Point(106, 131)
        Me.TxtSueldoNeto.Name = "TxtSueldoNeto"
        Me.TxtSueldoNeto.ReadOnly = True
        Me.TxtSueldoNeto.Size = New System.Drawing.Size(100, 20)
        Me.TxtSueldoNeto.TabIndex = 9
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Location = New System.Drawing.Point(106, 38)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuesto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Impuesto(SAR)"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.DimGray
        Me.BtnCalcular.Location = New System.Drawing.Point(60, 166)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(109, 57)
        Me.BtnCalcular.TabIndex = 21
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'TxtSueldoMensual
        '
        Me.TxtSueldoMensual.Location = New System.Drawing.Point(146, 118)
        Me.TxtSueldoMensual.Name = "TxtSueldoMensual"
        Me.TxtSueldoMensual.Size = New System.Drawing.Size(100, 20)
        Me.TxtSueldoMensual.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sueldo Mensual"
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.Location = New System.Drawing.Point(146, 42)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmpleado.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Empleado"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Red
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 12)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 64
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Sueldo_Neto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(749, 387)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtSueldoMensual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sueldo_Neto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sueldo_Neto"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtImpuestoAnual As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSueldoAnual As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSueldoNeto As TextBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtSueldoMensual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegresar As Button
End Class
