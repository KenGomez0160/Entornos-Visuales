<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSolicitarPrecio = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboInstrumentos = New System.Windows.Forms.ComboBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.CheckGrupos = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckFrecuencia = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aqua
        Me.Panel1.Controls.Add(Me.btnSolicitarPrecio)
        Me.Panel1.Controls.Add(Me.TxtCantidad)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtTotalPagar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboInstrumentos)
        Me.Panel1.Location = New System.Drawing.Point(29, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 175)
        Me.Panel1.TabIndex = 0
        '
        'btnSolicitarPrecio
        '
        Me.btnSolicitarPrecio.Location = New System.Drawing.Point(90, 93)
        Me.btnSolicitarPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSolicitarPrecio.Name = "btnSolicitarPrecio"
        Me.btnSolicitarPrecio.Size = New System.Drawing.Size(91, 28)
        Me.btnSolicitarPrecio.TabIndex = 4
        Me.btnSolicitarPrecio.Text = "Solicitar Precios"
        Me.btnSolicitarPrecio.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(90, 50)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'TxtTotalPagar
        '
        Me.TxtTotalPagar.Location = New System.Drawing.Point(90, 138)
        Me.TxtTotalPagar.Name = "TxtTotalPagar"
        Me.TxtTotalPagar.ReadOnly = True
        Me.TxtTotalPagar.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalPagar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total a pagar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Instrumentos"
        '
        'ComboInstrumentos
        '
        Me.ComboInstrumentos.FormattingEnabled = True
        Me.ComboInstrumentos.Location = New System.Drawing.Point(90, 9)
        Me.ComboInstrumentos.Name = "ComboInstrumentos"
        Me.ComboInstrumentos.Size = New System.Drawing.Size(121, 21)
        Me.ComboInstrumentos.TabIndex = 0
        Me.ComboInstrumentos.Text = "Seleccione un instrumento"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Blue
        Me.BtnCalcular.Location = New System.Drawing.Point(3, 21)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(112, 65)
        Me.BtnCalcular.TabIndex = 1
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Location = New System.Drawing.Point(286, 21)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(112, 65)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Aqua
        Me.Panel2.Controls.Add(Me.TxtDescuento)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtTotal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(392, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 121)
        Me.Panel2.TabIndex = 3
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(90, 18)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescuento.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descuento"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(90, 78)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.BtnNuevo.Enabled = False
        Me.BtnNuevo.Location = New System.Drawing.Point(143, 21)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(112, 65)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'CheckGrupos
        '
        Me.CheckGrupos.AutoSize = True
        Me.CheckGrupos.Location = New System.Drawing.Point(6, 30)
        Me.CheckGrupos.Name = "CheckGrupos"
        Me.CheckGrupos.Size = New System.Drawing.Size(139, 17)
        Me.CheckGrupos.TabIndex = 5
        Me.CheckGrupos.Text = "Descuento para Grupos"
        Me.CheckGrupos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.BtnCalcular)
        Me.Panel3.Controls.Add(Me.BtnNuevo)
        Me.Panel3.Controls.Add(Me.BtnSalir)
        Me.Panel3.Location = New System.Drawing.Point(236, 355)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 89)
        Me.Panel3.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Controls.Add(Me.CheckFrecuencia)
        Me.GroupBox1.Controls.Add(Me.CheckGrupos)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 114)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuentos "
        '
        'CheckFrecuencia
        '
        Me.CheckFrecuencia.AutoSize = True
        Me.CheckFrecuencia.Location = New System.Drawing.Point(6, 73)
        Me.CheckFrecuencia.Name = "CheckFrecuencia"
        Me.CheckFrecuencia.Size = New System.Drawing.Size(156, 17)
        Me.CheckFrecuencia.TabIndex = 8
        Me.CheckFrecuencia.Text = "Descuento Por Frecuencia "
        Me.CheckFrecuencia.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Image = Global.Venta_de_Instrumentos.My.Resources.Resources._231986_2807__1_
        Me.Label6.Location = New System.Drawing.Point(797, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Bienvenidos"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Venta_de_Instrumentos.My.Resources.Resources._231986_2807__1_
        Me.ClientSize = New System.Drawing.Size(698, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicales Fender"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalPagar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboInstrumentos As ComboBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSolicitarPrecio As Button
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckFrecuencia As CheckBox
    Friend WithEvents CheckGrupos As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
End Class
