Option Explicit On

Imports Integration.DataIntegration
Imports System.Data.Sql
Imports System.Data.SqlClient

Module mdl_Controles

    Dim ObjADONET As New Integration.DataIntegration.ClsADONET
    Dim dt As New DataTable

    Public Sub LlenaCombo(ByRef Combo As ComboBox, ByVal StrSQL As String, ByVal Codigo As String, ByVal Name As String)

        Try

            dt = ObjADONET.ExecutaSQL(StrSQL)
            'Llena valores en el ComboBox
            Combo.ValueMember = Codigo
            Combo.DisplayMember = Name
            Combo.DataSource = dt

        Catch ex As Exception
            MsgBox("Error al llenar ComboBox:" & Combo.Name & "." & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Aviso")

        End Try

    End Sub

    Public Sub LlenaDataCombo(ByRef Combo As ComboBox, ByRef dt As DataTable, ByVal Codigo As String, ByVal Name As String)

        Try
            'Llena valores en el ComboBox
            Combo.ValueMember = Codigo
            Combo.DisplayMember = Name
            Combo.DataSource = dt

        Catch ex As Exception
            MsgBox("Error al llenar ComboBox:" & Combo.Name & "." & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Aviso")

        End Try

    End Sub

    Public Sub LlenaListBox(ByRef List As ListBox, ByRef dt As DataTable, ByVal Codigo As String, ByVal Name As String)

        Try
            'Llena valores en el ComboBox
            List.ValueMember = Codigo
            List.DisplayMember = Name
            List.DataSource = dt

        Catch ex As Exception
            MsgBox("Error al llenar ComboBox:" & List.Name & "." & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Aviso")

        End Try

    End Sub

    Public Function Consulta_Reader(ByVal StrSQL As String) As DataTable

        'Este metodo recibe como parametro la consulta completa y sirve para hacer SELECT 
        Try
            dt = ObjADONET.ExecutaSQL(StrSQL)

        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error!")
            Exit Function
        End Try

        Return dt

    End Function

    Public Function Verificar_Existencia(ByVal StrSQL As String) As Boolean

        'Devuelve true si existe, entonces no grabamos, o devuelve false si no existe entoinces debemos grabar. 
        Dim dt As New DataTable
        Try

            dt = ObjADONET.ExecutaSQL(StrSQL)

        Catch ex As Exception
            MsgBox("Error al consultar la base de datos!" & Chr(13) & ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function Get_Valor(ByVal StrSQL As String, Optional ByVal cpCampo As String = "Valor") As String

        'Este metodo recibe como parametro la consulta completa y devuelve un valor
        Try
            dt = ObjADONET.ExecutaSQL(StrSQL)
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

        If dt.Rows.Count > 0 Then
            REM valor se debe poner a todo StrSQL as Valor
            get_valor = dt.Rows(0)(cpCampo)
        Else
            get_valor = ""
        End If

    End Function

    Public Sub consulta_non_query_MSG(ByVal StrSQL As String)

        Dim Resultado As Long

        'Este metodo recibe como parametro la consulta completa y sirve para hacer INSERT, UPDATE Y DELETE 
        Resultado = ObjADONET.ExecutaSQLIUD(StrSQL)
        If Resultado <> 0 Then
            MessageBox.Show("!La operacion se realizo con éxito..!", "Operacion exitosa..!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("!Se encontraron errores..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Function ExecutaStrSQL(ByVal StrSQL As String) As Long

        Dim Resultado As Long

        'Este metodo recibe como parametro la consulta completa y sirve para hacer INSERT, UPDATE Y DELETE 
        Resultado = ObjADONET.ExecutaSQLIUD(StrSQL)

        Return Resultado

    End Function

End Module
