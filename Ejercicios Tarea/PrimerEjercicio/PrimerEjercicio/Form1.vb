Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multi As Integer
        Dim divicion As Double

        valor1 = Val(TxtValor1.Text)
        valor2 = Val(TxtValor2.Text)

        suma = valor1 + valor2
        resta = valor1 - valor2
        multi = valor1 * valor2
        divicion = valor1 / valor2

        TxtSuma.Text = suma
        TxtResta.Text = resta
        TxtMulti.Text = multi
        TxtDivicion.Text = divicion

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtValor1.Clear()
        TxtValor2.Clear()
        TxtSuma.Clear()
        TxtResta.Clear()
        TxtMulti.Clear()
        TxtDivicion.Clear()



    End Sub
End Class
