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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.TextISV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDescuento = New System.Windows.Forms.TextBox()
        Me.TextSubTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextPunitario = New System.Windows.Forms.TextBox()
        Me.TextCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboOpciones = New System.Windows.Forms.ComboBox()
        Me.CheckAplicarISV = New System.Windows.Forms.CheckBox()
        Me.ComboTiposDescuentos = New System.Windows.Forms.ComboBox()
        Me.CheckAplicarDescuetno = New System.Windows.Forms.CheckBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox2.Controls.Add(Me.TextTotal)
        Me.GroupBox2.Controls.Add(Me.TextISV)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextDescuento)
        Me.GroupBox2.Controls.Add(Me.TextSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(426, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 279)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de Factura"
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(94, 236)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.ReadOnly = True
        Me.TextTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextTotal.TabIndex = 8
        '
        'TextISV
        '
        Me.TextISV.Location = New System.Drawing.Point(94, 173)
        Me.TextISV.Name = "TextISV"
        Me.TextISV.ReadOnly = True
        Me.TextISV.Size = New System.Drawing.Size(100, 20)
        Me.TextISV.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ISV "
        '
        'TextDescuento
        '
        Me.TextDescuento.Location = New System.Drawing.Point(93, 103)
        Me.TextDescuento.Name = "TextDescuento"
        Me.TextDescuento.ReadOnly = True
        Me.TextDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TextDescuento.TabIndex = 4
        '
        'TextSubTotal
        '
        Me.TextSubTotal.Location = New System.Drawing.Point(93, 40)
        Me.TextSubTotal.Name = "TextSubTotal"
        Me.TextSubTotal.ReadOnly = True
        Me.TextSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextSubTotal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SubTotal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'TextPunitario
        '
        Me.TextPunitario.Location = New System.Drawing.Point(93, 40)
        Me.TextPunitario.Name = "TextPunitario"
        Me.TextPunitario.Size = New System.Drawing.Size(100, 20)
        Me.TextPunitario.TabIndex = 3
        '
        'TextCantidad
        '
        Me.TextCantidad.Location = New System.Drawing.Point(93, 103)
        Me.TextCantidad.Name = "TextCantidad"
        Me.TextCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TextCantidad.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Controls.Add(Me.ComboOpciones)
        Me.GroupBox1.Controls.Add(Me.CheckAplicarISV)
        Me.GroupBox1.Controls.Add(Me.ComboTiposDescuentos)
        Me.GroupBox1.Controls.Add(Me.CheckAplicarDescuetno)
        Me.GroupBox1.Controls.Add(Me.TextCantidad)
        Me.GroupBox1.Controls.Add(Me.TextPunitario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 337)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'ComboOpciones
        '
        Me.ComboOpciones.FormattingEnabled = True
        Me.ComboOpciones.Location = New System.Drawing.Point(32, 273)
        Me.ComboOpciones.Name = "ComboOpciones"
        Me.ComboOpciones.Size = New System.Drawing.Size(121, 21)
        Me.ComboOpciones.TabIndex = 8
        Me.ComboOpciones.Text = "2 Opciones"
        '
        'CheckAplicarISV
        '
        Me.CheckAplicarISV.AutoSize = True
        Me.CheckAplicarISV.Location = New System.Drawing.Point(32, 232)
        Me.CheckAplicarISV.Name = "CheckAplicarISV"
        Me.CheckAplicarISV.Size = New System.Drawing.Size(78, 17)
        Me.CheckAplicarISV.TabIndex = 7
        Me.CheckAplicarISV.Text = "Aplicar ISV"
        Me.CheckAplicarISV.UseVisualStyleBackColor = True
        '
        'ComboTiposDescuentos
        '
        Me.ComboTiposDescuentos.FormattingEnabled = True
        Me.ComboTiposDescuentos.Location = New System.Drawing.Point(32, 189)
        Me.ComboTiposDescuentos.Name = "ComboTiposDescuentos"
        Me.ComboTiposDescuentos.Size = New System.Drawing.Size(121, 21)
        Me.ComboTiposDescuentos.TabIndex = 6
        Me.ComboTiposDescuentos.Text = "Tipos de descuentos"
        '
        'CheckAplicarDescuetno
        '
        Me.CheckAplicarDescuetno.AutoSize = True
        Me.CheckAplicarDescuetno.Location = New System.Drawing.Point(32, 153)
        Me.CheckAplicarDescuetno.Name = "CheckAplicarDescuetno"
        Me.CheckAplicarDescuetno.Size = New System.Drawing.Size(113, 17)
        Me.CheckAplicarDescuetno.TabIndex = 5
        Me.CheckAplicarDescuetno.Text = "Aplicar Descuento"
        Me.CheckAplicarDescuetno.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(617, 337)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 59)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(372, 337)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(110, 59)
        Me.BtnCalcular.TabIndex = 8
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(490, 337)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(110, 59)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(764, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Sencilla"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextTotal As TextBox
    Friend WithEvents TextISV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextDescuento As TextBox
    Friend WithEvents TextSubTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextPunitario As TextBox
    Friend WithEvents TextCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboOpciones As ComboBox
    Friend WithEvents CheckAplicarISV As CheckBox
    Friend WithEvents ComboTiposDescuentos As ComboBox
    Friend WithEvents CheckAplicarDescuetno As CheckBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnNuevo As Button
End Class
