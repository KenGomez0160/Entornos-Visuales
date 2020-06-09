Public Class Sueldo_Neto
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim sueldoMensual As Double
        Dim impuesto As Double
        Dim sueldoNeto As Double

        Dim sueldoanual As Double
        Dim impuestoAnual As Double

        sueldoMensual = Val(TxtSueldoMensual.Text)
        impuesto = Val(TxtImpuesto.Text)
        sueldoanual = Val(TxtSueldoAnual.Text)
        impuestoAnual = Val(TxtImpuestoAnual.Text)
        sueldoNeto = Val(TxtSueldoNeto.Text)


        If sueldoMensual <= 13790 Then
            sueldoanual = sueldoMensual * 12
            impuestoAnual = 0
            impuesto = 0
        ElseIf sueldoMensual <= 21027 Then
            sueldoanual = sueldoMensual * 12
            impuestoAnual = sueldoanual * 15 / 100
            impuesto = sueldoMensual * 15 / 100
        ElseIf sueldoMensual <= 48901 Then
            sueldoanual = sueldoMensual * 12
            impuestoAnual = sueldoanual * 20 / 100
            impuesto = sueldoMensual * 20 / 100
            sueldoanual = sueldoMensual * 12
        ElseIf sueldoMensual > 48901 Then
            sueldoanual = sueldoMensual * 12
            impuestoAnual = sueldoanual * 25 / 100
            impuesto = sueldoMensual * 25 / 100
        End If

        sueldoNeto = sueldoMensual - impuesto
        TxtImpuesto.Text = (impuesto)
        TxtSueldoNeto.Text = (sueldoNeto)
        TxtImpuestoAnual.Text = (impuestoAnual)
        TxtSueldoAnual.Text = (sueldoanual)

        BtnNuevo.Enabled = True
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtEmpleado.Clear()
        TxtSueldoMensual.Clear()
        TxtImpuesto.Clear()
        TxtSueldoNeto.Clear()
        TxtSueldoAnual.Clear()
        TxtImpuestoAnual.Clear()
        BtnNuevo.Enabled = False

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        MenuOpciones.Show()
    End Sub
End Class