Public Class Validar
    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        Dim valor As Int16

        If TxtNumero.Text = " " Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(TxtNumero) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TxtNumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(TxtNumero.Text)

            If valor = 0 Then
                MsgBox("Numero cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero Positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero Negativo")
            End If

        End If
    End Sub
End Class