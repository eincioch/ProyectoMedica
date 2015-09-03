Option Explicit On
Imports Integration.Conection.clsConection
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ImageClass

#Region "Set Property Data …"

    Const Name As String = "ImageClass"
    Dim mConexion As Integration.Conection.clsConection
    Dim NumError As Long
    Private _conectado As Boolean

    Public Sub New()
        NumError = 0
        'mConexion = Nothing
        Dim mConexion As New Integration.Conection.clsConection
    End Sub

    Private Property Conectado(mConexion As Conection.clsConection) As Boolean
        Get
            Return _conectado
        End Get
        Set(value As Boolean)
            _conectado = value
        End Set
    End Property

    Private Sub Finalize()
        mConexion = Nothing
    End Sub

    Public Property Conexion() As Integration.Conection.clsConection
        Get
            Return mConexion
        End Get
        Set(ByVal value As Integration.Conection.clsConection)
            mConexion = value
        End Set
    End Property


    Public Property Message() As String

        Get
            If Conectado(mConexion) Then
                Message = mConexion.Message
            Else
                Message = "No hay conexion con el Origen de datos."
            End If
            Return Message
        End Get
        Set(ByVal vMessage As String)
            Message = vMessage
        End Set
    End Property

    Public Sub TerminarTransaccion(NumError As Long)
        If Conectado(mConexion) Then mConexion.TerminarTransaccion(NumError)
    End Sub

#End Region

    'Public Function GetPerImagen(ByVal pcPerCodigo As String) As SqlDataReader

    '    Dim cn As Integration.Conection.clsConection = New Integration.Conection.clsConection
    '    Dim strsql As String
    '    Dim dr As SqlDataReader

    '    strsql = "select cPerCodigo,nPerTipImagen,iPerImaFoto,dPerImaFecRegistro From PerImagen Where cPerCodigo = '" & pcPerCodigo & "' "
    '    dr = cn.GetRecordset(strsql)
    '    Return dr
    'End Function

    Public Function Upd_InsertPerImagen(ByVal pcPerCodigo As String, ByVal pnPerTipImagen As Long, ByVal piPerImaFoto As Byte()) As Long

        Dim Resultado As Long = 0
        Try
            Using cn As New Integration.Conection.clsConection
                Using cmd As New SqlCommand
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "ups_InsertPerImagen"
                    cmd.Parameters.AddWithValue("@cPerCodigo", pcPerCodigo)
                    cmd.Parameters.AddWithValue("@nPerTipImagen", pnPerTipImagen)

                    Dim pImg As New SqlParameter("@iPerImaFoto", SqlDbType.Image)
                    pImg.Value = piPerImaFoto
                    'cmd.Parameters.AddWithValue("@iPerImaFoto", piPerImaFoto)
                    cmd.Parameters.Add(pImg)
                    Return cn.ExecuteCmdResultLong(cmd)
                End Using
            End Using
        Catch ex As Exception
            Resultado = Err.Number
            Return Resultado
        End Try

    End Function

    Public Function GetPerImagen(ByVal pcPerCodigo As String) As DataTable
        Dim Resultado As Long = 0
        Try
            Using cn As New Integration.Conection.clsConection
                Using cmd As New SqlCommand

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Exec usp_SelectPerImagen @cPerCodigo='" & pcPerCodigo & "'"
                    'cmd.CommandText = "SELECT cPerCodigo, nPerTipImagen, iPerImaFoto, dPerImaFecRegistro FROM PerImagen WHERE cPerCodigo = '" & pcPerCodigo & "' "
                    Using dt As New DataTable
                        Return cn.ExecuteCmdResultDt(cmd)
                    End Using

                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try


    End Function

End Class
