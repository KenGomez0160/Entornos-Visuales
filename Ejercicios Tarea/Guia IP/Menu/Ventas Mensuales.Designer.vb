<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_Mensuales
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
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListSuperaronMedia = New System.Windows.Forms.ListBox()
        Me.TxtMedia = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListNombre = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListMensual = New System.Windows.Forms.ListBox()
        Me.BtnSolicitar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Enabled = False
        Me.BtnNuevo.Location = New System.Drawing.Point(205, 45)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(109, 40)
        Me.BtnNuevo.TabIndex = 16
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnMostrar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ListSuperaronMedia)
        Me.Panel2.Controls.Add(Me.TxtMedia)
        Me.Panel2.Location = New System.Drawing.Point(368, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 271)
        Me.Panel2.TabIndex = 14
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(7, 52)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 10
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Almacen que supero la media"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Media"
        '
        'ListSuperaronMedia
        '
        Me.ListSuperaronMedia.FormattingEnabled = True
        Me.ListSuperaronMedia.Location = New System.Drawing.Point(59, 99)
        Me.ListSuperaronMedia.Name = "ListSuperaronMedia"
        Me.ListSuperaronMedia.Size = New System.Drawing.Size(120, 160)
        Me.ListSuperaronMedia.TabIndex = 8
        '
        'TxtMedia
        '
        Me.TxtMedia.Location = New System.Drawing.Point(79, 17)
        Me.TxtMedia.Name = "TxtMedia"
        Me.TxtMedia.Size = New System.Drawing.Size(142, 20)
        Me.TxtMedia.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListMensual)
        Me.Panel1.Location = New System.Drawing.Point(39, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 236)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Almacenes"
        '
        'ListNombre
        '
        Me.ListNombre.FormattingEnabled = True
        Me.ListNombre.Location = New System.Drawing.Point(6, 43)
        Me.ListNombre.Name = "ListNombre"
        Me.ListNombre.Size = New System.Drawing.Size(115, 186)
        Me.ListNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ventas"
        '
        'ListMensual
        '
        Me.ListMensual.FormattingEnabled = True
        Me.ListMensual.Location = New System.Drawing.Point(166, 43)
        Me.ListMensual.Name = "ListMensual"
        Me.ListMensual.Size = New System.Drawing.Size(120, 186)
        Me.ListMensual.TabIndex = 2
        '
        'BtnSolicitar
        '
        Me.BtnSolicitar.Location = New System.Drawing.Point(39, 45)
        Me.BtnSolicitar.Name = "BtnSolicitar"
        Me.BtnSolicitar.Size = New System.Drawing.Size(106, 40)
        Me.BtnSolicitar.TabIndex = 12
        Me.BtnSolicitar.Text = "Solicitar"
        Me.BtnSolicitar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Red
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 12)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 65
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Ventas_Mensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(652, 406)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSolicitar)
        Me.Name = "Ventas_Mensuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas_Mensuales"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListSuperaronMedia As ListBox
    Friend WithEvents TxtMedia As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListNombre As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListMensual As ListBox
    Friend WithEvents BtnSolicitar As Button
    Friend WithEvents BtnRegresar As Button
End Class
