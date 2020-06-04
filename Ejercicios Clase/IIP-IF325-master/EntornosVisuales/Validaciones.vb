Imports System.ComponentModel

Public Class Validaciones
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Try Catch
        'ValidateChildren  Botton
        'Validating     Cajas de texto
        Try
            'Si las casillas estan sin  ningun valor
            'Aplique a todos los elementos>  Producto sea diferente de vacio, precio sea diferente de vacio, Cantidad sea un valor entero
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        toolTip.SetToolTip(txtProducto, "Ingrese un producto")
        toolTip.ToolTipTitle = "Producto"
        toolTip.ToolTipIcon = ToolTipIcon.Info

    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        toolTip.SetToolTip(txtPrecio, "Ingrese un precio")
        toolTip.ToolTipTitle = "Precio"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        toolTip.SetToolTip(txtCantidad, "Ingrese una cantidad (Entero)")
        toolTip.ToolTipTitle = "Cantidad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        toolTip.SetToolTip(txtDescripcion, "Ingrese una descripcion")
        toolTip.ToolTipTitle = "Descripcion"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class