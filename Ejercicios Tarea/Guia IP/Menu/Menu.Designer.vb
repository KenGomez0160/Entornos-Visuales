<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuOpciones
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListaDeProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EcuacionesCuadraticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasMensualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumerosAcumuladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SueldoNetoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeProyectosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListaDeProyectosToolStripMenuItem
        '
        Me.ListaDeProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.EcuacionesCuadraticasToolStripMenuItem, Me.VentasMensualesToolStripMenuItem, Me.NumerosAcumuladosToolStripMenuItem, Me.SueldoNetoToolStripMenuItem})
        Me.ListaDeProyectosToolStripMenuItem.Name = "ListaDeProyectosToolStripMenuItem"
        Me.ListaDeProyectosToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ListaDeProyectosToolStripMenuItem.Text = "Lista De Proyectos"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'EcuacionesCuadraticasToolStripMenuItem
        '
        Me.EcuacionesCuadraticasToolStripMenuItem.Name = "EcuacionesCuadraticasToolStripMenuItem"
        Me.EcuacionesCuadraticasToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EcuacionesCuadraticasToolStripMenuItem.Text = "Ecuaciones Cuadraticas"
        '
        'VentasMensualesToolStripMenuItem
        '
        Me.VentasMensualesToolStripMenuItem.Name = "VentasMensualesToolStripMenuItem"
        Me.VentasMensualesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.VentasMensualesToolStripMenuItem.Text = "Ventas Mensuales"
        '
        'NumerosAcumuladosToolStripMenuItem
        '
        Me.NumerosAcumuladosToolStripMenuItem.Name = "NumerosAcumuladosToolStripMenuItem"
        Me.NumerosAcumuladosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.NumerosAcumuladosToolStripMenuItem.Text = "Numeros Acumulados"
        '
        'SueldoNetoToolStripMenuItem
        '
        Me.SueldoNetoToolStripMenuItem.Name = "SueldoNetoToolStripMenuItem"
        Me.SueldoNetoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SueldoNetoToolStripMenuItem.Text = "Sueldo Neto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MenuOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuOpciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListaDeProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EcuacionesCuadraticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasMensualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumerosAcumuladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SueldoNetoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
