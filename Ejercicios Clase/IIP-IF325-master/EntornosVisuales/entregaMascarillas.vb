Public Class entregaMascarillas
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, DoWhile
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDepartamentos.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, ", Ingresar")
            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbDepartamento.Items.Add(mascarillas)
        Next
    End Sub

    Private Sub entregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString
        municipios = Val(txtMunicipios.Text)

        Select Case idDepartamento
            Case 0
                For i = 1 To municipios Step 1
                    While (itemDepartamento > 0)
                        cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                        If (itemDepartamento > cantEntrega) Then
                            municipios += 1
                            itemDepartamento -= cantEntrega
                            txtStock.Text = itemDepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End While
                Next
        End Select





        txtStock.Text = itemDepartamento
    End Sub
End Class