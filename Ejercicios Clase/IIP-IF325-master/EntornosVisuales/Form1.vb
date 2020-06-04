Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        '

        Dim itemId As Integer
        Dim itemNombre As String

        itemId = cmbEquipos.SelectedIndex
        itemNombre = cmbEquipos.SelectedItem.ToString
        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)
            Case 4
                MsgBox(itemNombre)
            Case 5
                MsgBox(itemNombre)
            Case Else
                MsgBox("Selecciona un valor correcto")
        End Select


    End Sub

    Private Sub SubFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ErrorProviderToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        EntradaTextoMessage.Show()
        Me.Close()
    End Sub
End Class
