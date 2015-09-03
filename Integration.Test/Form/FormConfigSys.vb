Option Strict On

Imports System
Imports System.Xml
Imports System.Net
Imports System.Net.Dns

Imports System.IO
Imports Integration.BE
Imports Integration.BL

Public Class FormConfigSys

    Private configXml As New XmlDocument
    Private ficConfig As String


    Private Sub cfgSetValue(ByVal seccion As String, _
                        ByVal clave As String, _
                        ByVal valor As String)
        '
        Dim n As XmlNode
        n = configXml.SelectSingleNode(seccion & "/add[@key=""" & clave & """]")
        If Not n Is Nothing Then
            n.Attributes("value").InnerText = valor
        End If
    End Sub

    Private Sub FormConfigSys_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim ip As Net.Dns
        Dim nombrePC As String
        Dim entradasIP As Net.IPHostEntry

        nombrePC = System.Environment.MachineName ''Dns.GetHostName

        entradasIP = GetHostByName(nombrePC)

        Dim direccion_Ip As String = entradasIP.AddressList(0).ToString

        TxtHost.Text = nombrePC
        TxtIP.Text = direccion_Ip

        'CboNroCaja
        LlenaDataCombo(CboNroCaja, ObjConst.Get_Constante("C", CLng(CboNroCaja.Tag)), "nConValor", "cConDescripcion")

        Call CboNroCaja_SelectionChangeCommitted(CboNroCaja, Nothing)

        'recupero valores registrados
        Dim cRpt As String
        Dim cCaja As String
        Dim cDocuDefault As String

        Dim configurationAppSettings As New System.Configuration.AppSettingsReader
        cCaja = CType(configurationAppSettings.GetValue("NroCaja", GetType(System.String)), String)
        cDocuDefault = CType(configurationAppSettings.GetValue("nTipoDocuDefault", GetType(System.String)), String)
        cRpt = CType(configurationAppSettings.GetValue("RutaRpt", GetType(System.String)), String)


        TxtPath.Text = cRpt ' AppPathExe() & "\Rpt\"
        CboNroCaja.SelectedValue = CInt(CLng(cCaja))
        CboTipoDocu.SelectionLength = CInt(CLng(cDocuDefault))

        'carga archivo de app.config
        ficConfig = Application.ExecutablePath & ".config"
        configXml.Load(ficConfig)


    End Sub

    Private Sub BtnAplica_Click(sender As System.Object, e As System.EventArgs) Handles BtnAplica.Click

        Try
            Dim ReqConfig As New BE.Sistema.BE_ReqSysConfig
            Dim ObjConfig As New BL_Sistema

            Dim Response As New BE_ResGenerico
            Dim Resultado As Long

            ReqConfig.NameHosts = Trim(TxtHost.Text)
            ReqConfig.AdressIP = Trim(TxtIP.Text)
            ReqConfig.NroCaja = CLng(CboNroCaja.SelectedValue)
            ReqConfig.PathRpt = Trim(TxtPath.Text)
            ReqConfig.nTipoDocuDefault = CLng(CboTipoDocu.SelectedValue)

            'Verifica si Existe Host y Caja ya registradas
            If ObjConfig.Get_SysConfigParametros(ReqConfig) <> 0 Then
                MessageBox.Show("Nro. de Caja, ya esta asignada en otro Equipo actualmente.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Exit Sub
            End If

            'Insert / Update
            Response = ObjConfig.Set_SysConfigParametros(ReqConfig)
            Resultado = Response.Resultado

            'Set app.config
            cfgSetValue("configuration/appSettings", "RutaRpt", TxtPath.Text)
            'NroCaja
            cfgSetValue("configuration/appSettings", "NroCaja", CboNroCaja.SelectedValue.ToString)
            'nTipoDocuDefault
            cfgSetValue("configuration/appSettings", "nTipoDocuDefault", CboTipoDocu.SelectedValue.ToString)
            'Save
            configXml.Save(ficConfig)

            MessageBox.Show("Se cambiaron los parametro del archivo config.app.", "Validando", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCerrar.Click

        Close()
        Dispose()

    End Sub

    Private Sub Form1_Unload(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'impide la combinacion ALT+F4 para cerrar la aplicacion y cerrar el formulario con la X
        e.Cancel = True
    End Sub

    Private Sub CboNroCaja_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CboNroCaja.SelectionChangeCommitted

        'llena CboTipoDocu segun caja asignada
        Dim ReqTDocu As New BE.CtasCtes.BE_TipoDocporNroCaja
        Dim ObjTDocu As New BL_CtaCtes.BL_CtaCteServicioFacturacion

        ReqTDocu.cPerJurCodigo = StrcPerJuridica
        ReqTDocu.nCajCodigo = CLng(CboNroCaja.SelectedValue)  'CLng(ObtenerParametroAppConfig("NroCaja"))

        LlenaDataCombo(CboTipoDocu, ObjTDocu.Get_TipoDocporNroCaja(ReqTDocu), "nIntCodigo", "cIntDescripcion")

    End Sub
End Class