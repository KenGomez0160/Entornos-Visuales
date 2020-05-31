Public Class Form1
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim pUnitario, Cantidad As Integer
        Dim descuento, ISV, subTotal, Total As Double
        Dim aplicarDescuento As Boolean
        Dim aplicarISV As Boolean

        pUnitario = Val(TextPunitario.Text)
        Cantidad = Val(TextCantidad.Text)

        aplicarDescuento = CheckAplicarDescuetno.Checked
        descuento = 0

        aplicarISV = CheckAplicarDescuetno.Checked
        aplicarISV = 0

        If TextPunitario.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(TextPunitario.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TextPunitario.Text = ""
        ElseIf TextPunitario.Text < 0 Then
            MsgBox("Escriba valores mayores que 0 o positivos", vbInformation)
        End If

        If TextCantidad.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(TextCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TextCantidad.Text = ""
        ElseIf TextCantidad.Text < 0 Then
            MsgBox("Escriba valores mayores que 0 o positivos", vbInformation)
        End If



        subTotal = pUnitario * Cantidad

        If (ComboTiposDescuentos.Text) = "Estudiante" Then
            descuento = subTotal * 0.02

        ElseIf (ComboTiposDescuentos.Text) = "Mayores de edad" Then
            descuento = subTotal * 0.05

        ElseIf (ComboTiposDescuentos.Text) = "Por pronto pago" Then
            descuento = subTotal * 0.1

        ElseIf (ComboTiposDescuentos.Text) = "Por volumen" Then
            descuento = subTotal * 0.12
        ElseIf (ComboTiposDescuentos.Text) = "Por frecuencia" Then
            descuento = subTotal * 0.15
        ElseIf (ComboTiposDescuentos.Text) = "Por Menudeo" Then
            descuento = subTotal * 0.18
        End If
        Total = subTotal - descuento

        If (ComboOpciones.Text) = "15%" Then
            ISV = subTotal * 0.15
        ElseIf (ComboOpciones.Text) = "17%" Then
            ISV = subTotal * 0.17
        End If
        Total = subTotal + ISV


        TextISV.Text = ISV
        TextSubTotal.Text = subTotal
        TextDescuento.Text = descuento
        TextTotal.Text = Total

        BtnNuevo.Enabled = True



    End Sub

    Private Sub ComboTiposDescuentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTiposDescuentos.SelectedIndexChanged

    End Sub

    Private Sub ComboTiposDescuentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboTiposDescuentos.KeyPress
        e.Handled = True

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboOpciones.KeyPress
        e.Handled = True
    End Sub

    Private Sub CheckAplicarDescuetno_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAplicarDescuetno.CheckedChanged
        If CheckAplicarDescuetno.Checked = True Then

            CheckAplicarISV.Enabled = False
            ComboOpciones.Enabled = False

        ElseIf CheckAplicarDescuetno.Checked = False Then
            CheckAplicarISV.Enabled = True
            ComboOpciones.Enabled = True
        End If
    End Sub

    Private Sub CheckAplicarISV_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAplicarISV.CheckedChanged
        If CheckAplicarISV.Checked = True Then
            CheckAplicarDescuetno.Enabled = False
            ComboTiposDescuentos.Enabled = False

        ElseIf CheckAplicarISV.Checked = False Then
            CheckAplicarDescuetno.Enabled = True
            ComboTiposDescuentos.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboTiposDescuentos.Items.Add("Estudiante")
        ComboTiposDescuentos.Items.Add("Mayores de edad")
        ComboTiposDescuentos.Items.Add("Por pronto pago")
        ComboTiposDescuentos.Items.Add("Por volumen")
        ComboTiposDescuentos.Items.Add("Por frecuencia")
        ComboTiposDescuentos.Items.Add("Por Menudeo")

        ComboOpciones.Items.Add("15%")
        ComboOpciones.Items.Add("17%")

        BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        TextPunitario.Clear()
        TextCantidad.Clear()
        TextSubTotal.Clear()
        TextDescuento.Clear()
        TextISV.Clear()
        TextTotal.Clear()
        CheckAplicarDescuetno.Checked = False
        CheckAplicarISV.Checked = False
        ComboTiposDescuentos.Text = ""
        ComboOpciones.Text = ""


    End Sub
End Class
