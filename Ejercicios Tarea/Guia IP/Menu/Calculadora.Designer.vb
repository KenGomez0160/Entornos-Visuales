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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Historial = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRespuesta = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnDividir = New System.Windows.Forms.Button()
        Me.BtnMultiplicar = New System.Windows.Forms.Button()
        Me.BtnResta = New System.Windows.Forms.Button()
        Me.BtnSumar = New System.Windows.Forms.Button()
        Me.BtnPunto = New System.Windows.Forms.Button()
        Me.BtnValides = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Historial)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(313, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(142, 180)
        Me.Panel1.TabIndex = 61
        '
        'Historial
        '
        Me.Historial.FormattingEnabled = True
        Me.Historial.Location = New System.Drawing.Point(3, 23)
        Me.Historial.Name = "Historial"
        Me.Historial.Size = New System.Drawing.Size(120, 147)
        Me.Historial.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Historial"
        '
        'BtnRespuesta
        '
        Me.BtnRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRespuesta.Location = New System.Drawing.Point(241, 146)
        Me.BtnRespuesta.Name = "BtnRespuesta"
        Me.BtnRespuesta.Size = New System.Drawing.Size(66, 74)
        Me.BtnRespuesta.TabIndex = 60
        Me.BtnRespuesta.Text = "="
        Me.BtnRespuesta.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(241, 66)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(66, 74)
        Me.BtnLimpiar.TabIndex = 59
        Me.BtnLimpiar.Text = "Clear"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnDividir
        '
        Me.BtnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDividir.Location = New System.Drawing.Point(186, 66)
        Me.BtnDividir.Name = "BtnDividir"
        Me.BtnDividir.Size = New System.Drawing.Size(49, 34)
        Me.BtnDividir.TabIndex = 58
        Me.BtnDividir.Text = "/"
        Me.BtnDividir.UseVisualStyleBackColor = True
        '
        'BtnMultiplicar
        '
        Me.BtnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiplicar.Location = New System.Drawing.Point(186, 106)
        Me.BtnMultiplicar.Name = "BtnMultiplicar"
        Me.BtnMultiplicar.Size = New System.Drawing.Size(49, 34)
        Me.BtnMultiplicar.TabIndex = 57
        Me.BtnMultiplicar.Text = "*"
        Me.BtnMultiplicar.UseVisualStyleBackColor = True
        '
        'BtnResta
        '
        Me.BtnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResta.Location = New System.Drawing.Point(186, 146)
        Me.BtnResta.Name = "BtnResta"
        Me.BtnResta.Size = New System.Drawing.Size(49, 34)
        Me.BtnResta.TabIndex = 56
        Me.BtnResta.Text = "-"
        Me.BtnResta.UseVisualStyleBackColor = True
        '
        'BtnSumar
        '
        Me.BtnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSumar.Location = New System.Drawing.Point(186, 186)
        Me.BtnSumar.Name = "BtnSumar"
        Me.BtnSumar.Size = New System.Drawing.Size(49, 34)
        Me.BtnSumar.TabIndex = 55
        Me.BtnSumar.Text = "+"
        Me.BtnSumar.UseVisualStyleBackColor = True
        '
        'BtnPunto
        '
        Me.BtnPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPunto.Location = New System.Drawing.Point(131, 186)
        Me.BtnPunto.Name = "BtnPunto"
        Me.BtnPunto.Size = New System.Drawing.Size(49, 34)
        Me.BtnPunto.TabIndex = 54
        Me.BtnPunto.Text = "."
        Me.BtnPunto.UseVisualStyleBackColor = True
        '
        'BtnValides
        '
        Me.BtnValides.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValides.Location = New System.Drawing.Point(76, 186)
        Me.BtnValides.Name = "BtnValides"
        Me.BtnValides.Size = New System.Drawing.Size(49, 34)
        Me.BtnValides.TabIndex = 53
        Me.BtnValides.Text = "+/-"
        Me.BtnValides.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(21, 186)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(49, 34)
        Me.Button0.TabIndex = 52
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(131, 66)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(49, 34)
        Me.Button9.TabIndex = 51
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(76, 66)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 34)
        Me.Button8.TabIndex = 50
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(21, 66)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 34)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(131, 106)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 34)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(76, 106)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 34)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(21, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 34)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(131, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 34)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(76, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 34)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 34)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(21, 40)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(286, 20)
        Me.TxtResultado.TabIndex = 42
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Red
        Me.BtnRegresar.Location = New System.Drawing.Point(12, 11)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 62
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(482, 264)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRespuesta)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnDividir)
        Me.Controls.Add(Me.BtnMultiplicar)
        Me.Controls.Add(Me.BtnResta)
        Me.Controls.Add(Me.BtnSumar)
        Me.Controls.Add(Me.BtnPunto)
        Me.Controls.Add(Me.BtnValides)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtResultado)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Historial As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRespuesta As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnDividir As Button
    Friend WithEvents BtnMultiplicar As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnSumar As Button
    Friend WithEvents BtnPunto As Button
    Friend WithEvents BtnValides As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents BtnRegresar As Button
End Class
