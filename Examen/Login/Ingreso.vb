Imports System.ComponentModel

Public Class Ingreso
    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbxDepartamento.Items.Add("Comayagua")
        CbxDepartamento.Items.Add("Francisco Morazan")
        CbxDepartamento.Items.Add("Atlantidad")
        CbxDepartamento.Items.Add("Choluteca")
        CbxDepartamento.Items.Add("Colon")
        CbxDepartamento.Items.Add("Copan")
        CbxDepartamento.Items.Add("Cortes")
        CbxDepartamento.Items.Add("El paraiso")
        CbxDepartamento.Items.Add("Gracias a Dios")
        CbxDepartamento.Items.Add("Intibuca")
        CbxDepartamento.Items.Add("Islas de la Bahia")
        CbxDepartamento.Items.Add("La Paz")
        CbxDepartamento.Items.Add("Lempira")
        CbxDepartamento.Items.Add("Ocotepeque")
        CbxDepartamento.Items.Add("Olancho")
        CbxDepartamento.Items.Add("Santa Barbara")
        CbxDepartamento.Items.Add("Valle")
        CbxDepartamento.Items.Add("Yoro")

        CbxResultados.Items.Add("Positivo")
        CbxResultados.Items.Add("Negativo")

        CbxEstado.Items.Add("Activo")
        CbxEstado.Items.Add("Recuperado")
        CbxEstado.Items.Add("Muerto")
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim Departamento As String
        Dim estado As String
        Dim resultados As String

        Dim activos As Integer
        Dim recuperados As Integer
        Dim muertos As Integer

        Dim iddepartamento As String
        iddepartamento = CbxDepartamento.SelectedIndex
        activos = Val(TxtActivos.Text)
        recuperados = Val(TxtRecuperados.Text)
        muertos = Val(TxtMuertos.Text)
        If CbxDepartamento.Text = "Comayagua" Then
            activos = 200
            recuperados = 20
            muertos = 5
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Francisco Morazan" Then
            activos = 150
            recuperados = 10
            muertos = 6
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Francisco Morazan" Then
            activos = 150
            recuperados = 10
            muertos = 6
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Atlantidad" Then
            activos = 55
            recuperados = 2
            muertos = 0
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Choluteca" Then
            activos = 70
            recuperados = 7
            muertos = 1
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Colon" Then
            activos = 89
            recuperados = 19
            muertos = 3
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Copan" Then
            activos = 13
            recuperados = 3
            muertos = 2
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Cortes" Then
            activos = 200
            recuperados = 30
            muertos = 20
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "El paraiso" Then
            activos = 24
            recuperados = 5
            muertos = 3
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Gracias a Dios" Then
            activos = 20
            recuperados = 2
            muertos = 3
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Intibuca" Then
            activos = 130
            recuperados = 20
            muertos = 15
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Islas de la Bahia" Then
            activos = 56
            recuperados = 10
            muertos = 6
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "La Paz" Then
            activos = 205
            recuperados = 50
            muertos = 20
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Lempira" Then
            activos = 250
            recuperados = 50
            muertos = 40
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Ocotepeque" Then
            activos = 278
            recuperados = 34
            muertos = 53
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Olancho" Then
            activos = 300
            recuperados = 20
            muertos = 12
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Santa Barbara" Then
            activos = 83
            recuperados = 12
            muertos = 11
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Valle" Then
            activos = 345
            recuperados = 234
            muertos = 23
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        ElseIf CbxDepartamento.Text = "Yoro" Then
            activos = 300
            recuperados = 20
            muertos = 12
            ListHistorial.Items.Add(activos)
            ListHistorial.Items.Add(recuperados)
            ListHistorial.Items.Add(muertos)
        End If




        If CbxEstado.Text = "Activo" & CbxDepartamento.SelectedIndex <> True Then
            ListDescripcion.Items.Add("Su estado es de emergencia")

            activos += 1
            recuperados = recuperados
            muertos = muertos
            TxtActivos.Text = (activos)
            TxtRecuperados.Text = (recuperados)
            TxtMuertos.Text = (muertos)


        ElseIf CbxEstado.Text = "Recuperado " & CbxDepartamento.SelectedIndex <> True Then
            ListDescripcion.Items.Add("Esta fuera de peligro")

            activos = activos
            recuperados += 1
            muertos = muertos
            TxtActivos.Text = (activos)
            TxtRecuperados.Text = (recuperados)
            TxtMuertos.Text = (muertos)



        ElseIf CbxEstado.Text = "Muerto " & CbxDepartamento.SelectedIndex <> True Then
            ListDescripcion.Items.Add("Lo sentimos")

            activos = activos
            recuperados = recuperados
            muertos += 1
            TxtActivos.Text = (activos)
            TxtRecuperados.Text = (recuperados)
            TxtMuertos.Text = (muertos)

        End If


    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombre.Validating

    End Sub

    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub
End Class