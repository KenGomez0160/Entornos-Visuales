Public Class MenuOpciones
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Calculadora.Show()
    End Sub

    Private Sub EcuacionesCuadraticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuacionesCuadraticasToolStripMenuItem.Click
        Ecuaciones_Cuadraticas.Show()
    End Sub

    Private Sub VentasMensualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasMensualesToolStripMenuItem.Click
        Ventas_Mensuales.Show()
    End Sub

    Private Sub NumerosAcumuladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumerosAcumuladosToolStripMenuItem.Click
        Numeros_Acumulados.Show()
    End Sub

    Private Sub SueldoNetoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SueldoNetoToolStripMenuItem.Click
        Sueldo_Neto.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub
End Class
