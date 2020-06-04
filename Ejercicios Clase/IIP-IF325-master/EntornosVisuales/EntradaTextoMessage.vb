Public Class EntradaTextoMessage
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese numero", "Ingreso")
        txtValor.Text = valor
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double
        valor = Val(txtValor.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multiplicacion = valor * i
            division = (valor / i)
            cmbSuma.Items.Add(valor & " + " & i & "=" & suma)
            cmbResta.Items.Add(valor & "-" & i & "=" & resta)
            cmbMultiplicacion.Items.Add(valor & "x" & i & "=" & multiplicacion)
            cmbDivision.Items.Add(valor & "/" & i & "=" & division)
        Next
    End Sub

    Private Sub ErrorProviderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorProviderToolStripMenuItem.Click
        Validaciones.Show()
        Me.Hide()
    End Sub

    Private Sub SubFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubFormularioToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class