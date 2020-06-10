Public Class Login
    Dim crearUsuario As String
    Dim CrearContraseña As String
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim Usuario As String
        Dim contraseñas As String


        Usuario = TxtUsuario.Text
        contraseñas = TxtContraseña.Text



        If Usuario = crearUsuario Then
            MsgBox("Usuario aceptado", vbInformation)
            If contraseñas = CrearContraseña Then
                Ingreso.Show()
            Else
                MsgBox("ContraseñaInvalida")
            End If
            TxtContraseña.Text = contraseñas
            TxtUsuario.Text = Usuario
        Else
            MsgBox("Usuario Incorrecto")
            TxtUsuario.Clear()
            TxtContraseña.Clear()
        End If


    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click


        crearUsuario = InputBox("Ingrese el usuario")
        CrearContraseña = InputBox("Ingrese la Contraseña")

        TxtContraseña.Enabled = True
        TxtUsuario.Enabled = True
        BtnIngresar.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub
End Class
