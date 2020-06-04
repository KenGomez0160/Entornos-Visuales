Imports System.ComponentModel

Public Class Form1
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboInstrumentos.Items.Add("Guitarra Acustica")
        ComboInstrumentos.Items.Add("Guitarra Electrica")
        ComboInstrumentos.Items.Add("Bajo Acustico")
        ComboInstrumentos.Items.Add("Bajo Electrico")
        ComboInstrumentos.Items.Add("Piano Electrico")
        ComboInstrumentos.Items.Add("Bateria")
        ComboInstrumentos.Items.Add("Violin")
        ComboInstrumentos.Items.Add("Trompeta")

    End Sub

    Private Sub ComboInstrumentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboInstrumentos.SelectedIndexChanged

    End Sub

    Private Sub ComboInstrumentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboInstrumentos.KeyPress
        e.Handled = True
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim descuento As Double
        Dim descuentoExtra As Double
        Dim totalPagar As Double
        Dim cantidad As Integer
        Dim total As Double
        cantidad = Val(TxtCantidad.Text)
        totalPagar = Val(TxtTotalPagar.Text)
        descuento = Val(TxtDescuento.Text)

        If cantidad > 2 Then
            descuento = totalPagar * 0.3
        Else
            descuento = 0
        End If


        If (CheckGrupos.Checked) = True Then
            descuentoExtra = totalPagar * 0.08
        ElseIf (CheckFrecuencia.Checked) = True Then
            descuentoExtra = totalPagar * 0.07
        Else
            descuentoExtra = 0
        End If
        descuento += descuentoExtra
        total = totalPagar - descuento
        Try

            If Me.ValidateChildren And TxtCantidad.Text <> String.Empty And Val(TxtCantidad.Text) - Int(Val(TxtCantidad.Text)) = 0 Then
                MessageBox.Show("Datos Ingresados", "Formulario Intrumentos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        TxtTotal.Text = (total)
        TxtDescuento.Text = (descuento)

        BtnNuevo.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSolicitarPrecio_Click(sender As Object, e As EventArgs) Handles btnSolicitarPrecio.Click
        Dim cantidad As Integer
        Dim precio As Double
        Dim totalPagar As Double

        cantidad = Val(TxtCantidad.Text)
        totalPagar = Val(TxtTotalPagar.Text)
        'Validar lo ingresado

        If Not IsNumeric(TxtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TxtCantidad.Text = ""
        ElseIf TxtCantidad.Text < 1 Then
            MsgBox("Escriba valores mayores que 0 o positivos", vbInformation)
        End If


        For i = 1 To cantidad Step 1

            precio = InputBox("Ingrese el precio del Intrumentos" & i, ", Ingresar")
            totalPagar += precio


        Next
        TxtTotalPagar.Text = (totalPagar)
        TxtCantidad.Text = cantidad
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged

    End Sub

    Private Sub TxtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles TxtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub

    Private Sub TxtCantidad_MouseHover(sender As Object, e As EventArgs) Handles TxtCantidad.MouseHover
        toolTip.SetToolTip(TxtCantidad, "Ingrese una cantidad")
        toolTip.ToolTipTitle = "Cantidad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSolicitarPrecio_MouseHover(sender As Object, e As EventArgs) Handles btnSolicitarPrecio.MouseHover
        toolTip.SetToolTip(btnSolicitarPrecio, "Dele Click en solicitar")
        toolTip.ToolTipTitle = "Solicitar"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub ComboInstrumentos_MouseHover(sender As Object, e As EventArgs) Handles ComboInstrumentos.MouseHover
        toolTip.SetToolTip(ComboInstrumentos, "Elija un instrumento")
        toolTip.ToolTipTitle = "Instrumentos"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtCantidad.Clear()
        TxtTotalPagar.Clear()
        TxtDescuento.Clear()
        TxtTotal.Clear()
        CheckGrupos.Checked = False
        CheckFrecuencia.Checked = False
        ComboInstrumentos.Text = ""

        BtnNuevo.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Left -= 5
        If Label6.Left <= -Width Then
            Label6.Text = Width
        End If
    End Sub
End Class
