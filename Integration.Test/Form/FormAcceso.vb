Option Explicit On

Imports Integration.DataIntegration
Imports Integration.BE
Imports Integration.BL
'Imports Integration.DAService
'Imports Microsoft.VisualBasic

Public Class FormAcceso

    Dim ObjEncrypt As New Integration.Conection.clsCrypt

    Dim Request As New BE.Sistema.BE_ReqFechaServidor
    Dim RequestEmp As New BE.Sistema.BE_ReqSistema
    Dim ObjBL As New BL_Sistema

    Dim RequestPer As New BE.PerUsuario.BE_ReqSearhUsuario
    Dim ObjBLPer As New BL_PerUsuario

    'Dim StrUser As String
    Dim SrtPass As String

    Private Function validar() As Boolean

        validar = False

        'If Not ValidatePassword(Txt_NewPass.Text) Then
        '    MessageBox.Show("Campo <Nueva contraseña> No cumple la complejidad  de contraseñas..! " & Chr(13) &
        '           "Debe tener 8 caracteres como minimo y contener la siguiente complejidad: " & Chr(13) &
        '           "2 Mayusculas, 2 minusculas, 2 Numeros y 2 caracteres especiales (%$&@>#).", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Txt_NewPass.Focus()
        '    Exit Function
        'End If
        'If Not ValidatePassword(Txt_RNewPass.Text) Then
        '    MessageBox.Show("Campo <Repetir nueva contraseña> No cumple la complejidad  de contraseñas..! " & Chr(13) &
        '           "Debe tener 8 caracteres como minimo y contener la siguiente complejidad: " & Chr(13) &
        '           "2 Mayusculas, 2 minusculas, 2 Numeros y 2 caracteres especiales (%$&@>#).", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Txt_RNewPass.Focus()
        '    Exit Function
        'End If
        If Trim(Txt_NewPass.Text) <> Trim(Txt_RNewPass.Text) Then
            MsgBox("Contraseña no es igual cuando repite la contraseña, vuelva a ingresar ambas contraseñas por favor..!", vbExclamation, "Validando")
            Txt_NewPass.Text = "" : Txt_RNewPass.Text = ""
            Txt_NewPass.Focus()
            Exit Function
        End If
        'If Not Len(Trim(Txt_NewPass.Text)) > 7 Or Not Len(Trim(Txt_RNewPass.Text)) > 7 Then
        '    MsgBox("La contraseña debe contener como minimo 8 caracteres," & Chr(13) & "y un maximo de 15 caracteres." & Chr(13) & "Vuelva a ingresar su nueva contraseña, por favor..!", vbExclamation, "Validando")
        '    Txt_NewPass.Text = "" : Txt_RNewPass.Text = ""
        '    Txt_NewPass.Focus()
        '    Exit Function
        'End If
        validar = True

    End Function

    Private Sub FormAcceso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'lleno los ComboBox
        Request.dFechaServer = vbNullString
        RequestPer.PerCodigo = vbNullString
        LlenaDataCombo(Cbo_User, ObjBLPer.Get_CboListUsuario(RequestPer), "cPerCodigo", "cPerUsuCodigo")
        If Cbo_User.Text <> "" Then Cargar_Empresas_por_Permisos()
    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Private Sub BtnAccesar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAccesar.Click

        If Cbo_User.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un usuario de la lista..!!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cbo_User.Focus()
        ElseIf CboEmpresa.Items.Count = 0 Then
            MessageBox.Show("No puede acceder, no tiene permisos a ninguna sucursal!!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CboEmpresa.Focus()
        ElseIf CboEmpresa.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una sucursal de la lista..!!", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CboEmpresa.Focus()
        Else
            Dim Usuario As String
            Usuario = UCase(Trim(Cbo_User.Text))
            SrtPass = ObjEncrypt.EncryptByCode(Usuario, Txt_Pass.Text)

            RequestPer.PerCodigo = Usuario
            RequestPer.cPerUsuClave = SrtPass

            Dim dt2 As New DataTable
            dt2 = ObjBLPer.Get_Persona_By_Usuario(RequestPer)

            If dt2.Rows.Count > 0 And RequestPer.cPerUsuClave = dt2.Rows(0).Item("cClave").ToString Then
                REM Obteniendo fecha del servidor
                Request.dFechaServer = ""
                StrUser = dt2.Rows(0).Item("cPerCodigo").ToString
                RequestPer.cPercodigo = StrUser

                dFechaSistema = ObjBL.Get_FechaServidor(Request)

                'cPerJuridica.- Empresa a nivel de todo el sistema
                StrcPerJuridica = CboEmpresa.SelectedValue

                'Ruta de repotes
                cPathRPT = ObtenerParametroAppConfig("RutaRpt")
                cNroCaja = ObtenerParametroAppConfig("NroCaja")

                FormMDI.Show()
                FormMDI.SSUser.Text = Trim(Cbo_User.Text)
                FormMDI.SSNroCaja.Text = "Caja Nro.: " & Microsoft.VisualBasic.Right("00" & cNroCaja, 2)
                FormMDI.SSfecha.Text = UCase(Format(dFechaSistema, "Long Date"))
                FormMDI.SSVersion.Text = FormMDI.SSVersion.Text & Space(1) & Status_Version()
                Me.Hide()
            Else
                MsgBox("Usted No tiene permiso para acceder al Sistema..!!", vbExclamation, "Denegado...")
                Txt_Pass.Text = ""
                Txt_Pass.Focus()
            End If
            dt2.Dispose()
        End If

    End Sub

    Private Sub LnkLbl_ChangePass_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkLbl_ChangePass.LinkClicked
        GroupBox4.Visible = True
        Txt_PassActual.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        GroupBox4.Visible = False
        Txt_Pass.Focus()
    End Sub

    Private Sub BtnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click

        Dim Request As New BE.PerUsuario.BE_ReqSearhUsuario
        Dim ObjBL As New BL_Sistema
        Dim Response As New BE_ResGenerico

        Dim Resultado As Long
        Dim Usuario As String
        Usuario = UCase(Trim(Cbo_User.Text))
        SrtPass = ObjEncrypt.EncryptByCode(Usuario, Txt_PassActual.Text)

        Dim dt As New DataTable
        dt = ObjBLPer.Get_Persona_By_Usuario(RequestPer)
        If dt.Rows.Count > 0 Then
            StrUser = dt.Rows(0).Item("cPerCodigo").ToString
        End If

        RequestPer.PerCodigo = StrUser
        RequestPer.cPerUsuClave = SrtPass

        If dt.Rows.Count > 0 And RequestPer.cPerUsuClave = dt.Rows(0).Item("cClave").ToString Then
            If validar() Then

                RequestPer.PerCodigo = StrUser
                RequestPer.cPerUsuClave = ObjEncrypt.EncryptByCode(StrUser, Txt_NewPass.Text)

                Response = ObjBLPer.UpdChangePassword(RequestPer)
                Resultado = Response.Resultado

                If Resultado <> 0 Then
                    MessageBox.Show("Se ha cambiado la contraseña.", "Cambio contraseña..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnCancel_Click(BtnCancel, Nothing)
                Else
                    MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Else
            MessageBox.Show("Contraseña actual no es la correcta, vuelva a ingresar la contrasela actual..!!", "Validando..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_PassActual.Text = "" : Txt_PassActual.Focus()
        End If

    End Sub

    Private Sub Cbo_User_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cbo_User.SelectedIndexChanged
        Call Cargar_Empresas_por_Permisos()
    End Sub

    Sub Cargar_Empresas_por_Permisos()
        Dim dt2 As New DataTable
        RequestPer.PerCodigo = Cbo_User.Text
        dt2 = ObjBLPer.Get_Persona_By_Usuario(RequestPer)
        StrUser = dt2.Rows(0).Item("cPerCodigo").ToString
        RequestEmp.cPerCodigo = StrUser
        RequestEmp.nSisGruCodigo = nSisGruCodigo.AdmisionMedica
        LlenaDataCombo(CboEmpresa, ObjBL.Get_Empresas_Per_Mod(RequestEmp), "cPerCodigo", "cPerNombre")
    End Sub
End Class