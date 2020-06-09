Public Class Ecuaciones_Cuadraticas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim x1, x2 As Double

        If TxtA.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(TxtA.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TxtA.Text = ""
        End If
        If TxtB.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(TxtB.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TxtB.Text = ""
        End If
        If TxtC.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(TxtC.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            TxtC.Text = ""
        End If

        a = CInt(TxtA.Text)
        b = CInt(TxtB.Text)
        c = CInt(TxtC.Text)


        x1 = ((-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a))
        x2 = ((-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a))
        LabelX1.Text = (x1)
        LabelX2.Text = (x2)
        Label4.Visible = True
        Label5.Visible = True
        LabelX1.Visible = True
        LabelX2.Visible = True

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtA.Clear()
        TxtB.Clear()
        TxtC.Clear()
        LabelX1.Text = ""
        LabelX2.Text = ""
        Label4.Visible = False
        Label5.Visible = False
        LabelX1.Visible = False
        LabelX2.Visible = False
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        MenuOpciones.Show()
    End Sub
End Class