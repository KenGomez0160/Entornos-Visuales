Public Class Numeros_Acumulados
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim cantidad As Integer
        Dim numeros As Integer

        Dim pares, impares, positivos, negativos As Integer
        Dim total As Integer

        cantidad = Val(TxtCantidad.Text)
        pares = Val(TxtPares.Text)
        impares = Val(TxtImpares.Text)
        positivos = Val(TxtPositivos.Text)
        negativos = Val(TxtNegativos.Text)
        total = Val(TxtTotal.Text)
        For i = 1 To cantidad Step 1
            numeros = InputBox("Ingrese numeros  " & i, ", Ingresar")
            ComboNumeros.Items.Add(numeros)

            If numeros Mod 2 = 0 Then

                pares += 1
                TxtPares.Text = (pares)
            Else
                impares += 1
                TxtImpares.Text = (impares)

            End If
            If numeros < 0 Then
                negativos += 1
                TxtNegativos.Text = (negativos)
            Else
                positivos += 1
                TxtPositivos.Text = (positivos)
            End If
            total += i
            TxtTotal.Text = (total)
            TxtIngresados.Text = (cantidad)
        Next
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        MenuOpciones.Show()
    End Sub
End Class