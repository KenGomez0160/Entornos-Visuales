Public Class Ventas_Mensuales
    Dim almacen As String
    Dim mensual As Double
    Dim total As Double
    Dim media As Double
    Private Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click


        For i = 1 To 10 Step 1


            almacen = InputBox("Ingrese el nombre del almacen " & i, ", Ingresar")
            ListNombre.Items.Add(almacen)
            mensual = InputBox("Ingrese el valor mensual " & i, ", Ingresar")
            ListMensual.Items.Add(mensual)

            total += mensual
            media = (total) / 10


        Next i


        TxtMedia.Text = (media)
        BtnNuevo.Enabled = True
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        ListNombre.Items.Clear()
        ListMensual.Items.Clear()
        ListSuperaronMedia.Items.Clear()
        TxtMedia.Clear()

    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        For j = 0 To ListMensual.Items.Count - 1
            If ListMensual.Items(j).ToString > media Then
                almacen = ListNombre.Items(j).ToString
                ListSuperaronMedia.Items.Add(almacen)
            End If
        Next
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        MenuOpciones.Show()
    End Sub
End Class