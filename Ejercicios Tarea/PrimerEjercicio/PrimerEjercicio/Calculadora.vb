Public Class Calculadora
    Private Sub CheckSuma_CheckedChanged(sender As Object, e As EventArgs) Handles CheckSuma.CheckedChanged
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resultado As Integer


        valor1 = Val(TextValor1.Text)
        valor2 = Val(TextValor2.Text)

        resultado = valor1 + valor2

        TextResultado.Text = resultado

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub CheckResta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckResta.CheckedChanged
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resultado As Integer


        valor1 = Val(TextValor1.Text)
        valor2 = Val(TextValor2.Text)

        resultado = valor1 - valor2

        TextResultado.Text = resultado
    End Sub

    Private Sub CheckMulti_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMulti.CheckedChanged
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resultado As Integer


        valor1 = Val(TextValor1.Text)
        valor2 = Val(TextValor2.Text)

        resultado = valor1 * valor2

        TextResultado.Text = resultado
    End Sub

    Private Sub CheckDivicion_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDivicion.CheckedChanged
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resultado As Double


        valor1 = Val(TextValor1.Text)
        valor2 = Val(TextValor2.Text)

        resultado = valor1 / valor2

        TextResultado.Text = resultado
    End Sub

    Private Sub CheckRaiz_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRaiz.CheckedChanged
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resultado As Double


        valor1 = Val(TextValor1.Text)
        valor2 = Val(TextValor2.Text)

        resultado = Math.Sqrt(valor1)

        TextResultado.Text = resultado
    End Sub

    Private Sub CheckPotencia_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPotencia.CheckedChanged
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resultado As Integer


        valor1 = Val(TextValor1.Text)
        valor2 = Val(TextValor2.Text)

        resultado = valor1 ^ valor2


        TextResultado.Text = resultado
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TextValor1.Clear()
        TextValor2.Clear()
        TextResultado.Clear()


    End Sub
End Class