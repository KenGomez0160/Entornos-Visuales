Public Class Calculadora
    Dim operacion As String
    Dim valorResultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        EvaluaRestriccionesParaContatenar()
        TxtResultado.Text &= "0"
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        EvaluaRestriccionesParaContatenar()
        If InStr(TxtResultado.Text, ".", CompareMethod.Text) = 0 Then
            TxtResultado.Text &= "."
        End If

    End Sub

    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click
        EvaluayHazOperacion()
        operacion = "+"

    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        EvaluayHazOperacion()
        operacion = "-"
    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        EvaluayHazOperacion()
        operacion = "*"
    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        EvaluayHazOperacion()
        operacion = "/"
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtResultado.Text = "0"
        Historial.Items.Clear()
        valor2 = Nothing
        valorResultado = Nothing
    End Sub

    Private Sub BtnRespuesta_Click(sender As Object, e As EventArgs) Handles BtnRespuesta.Click
        EvaluayHazOperacion()
        operacion = ""

        Historial.Items.Add(TxtResultado.Text)
    End Sub

    Private Sub BtnValides_Click(sender As Object, e As EventArgs) Handles BtnValides.Click
        Try
            If TxtResultado.Text <> "" Then
                TxtResultado.Text = TxtResultado.Text * (-1)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub EvaluayHazOperacion()
        SePresionaOperador = True
        valor2 = Val(TxtResultado.Text)
        If valorResultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valorResultado = valorResultado + valor2
                Case "-"
                    valorResultado -= valor2
                Case "*"
                    valorResultado *= valor2
                Case "/"
                    valorResultado /= valor2
            End Select
            TxtResultado.Text = valorResultado
        Else
            valorResultado = valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaContatenar()
        If SePresionaOperador = True Then
            TxtResultado.Text = ""
            SePresionaOperador = False
        ElseIf TxtResultado.Text = "0" Then
            TxtResultado.Text = ""
        End If
    End Sub

    Private Sub Historial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Historial.SelectedIndexChanged

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        MenuOpciones.Show()

    End Sub
End Class