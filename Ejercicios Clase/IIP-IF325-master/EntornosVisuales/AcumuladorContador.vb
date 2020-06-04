Public Class AcumuladorContador
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Try
            Dim precio, total, totalPagar, orden As Integer
            orden = txtPedido.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                'Acumulador: guarda los valores ingresados previmente
                totalPagar = totalPagar + precio
                totalPagar += precio
            Next
            total = totalPagar / orden
            txtTotal.Text = totalPagar
            txtTotalIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPedido.Clear()
        txtTotal.Clear()
        txtTotalIndividual.Clear()
    End Sub
End Class