Option Explicit On
Imports Integration.Conection.clsConection
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ClsADONET

    Const Name As String = "ClsADONET"
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

    Public Function ExecutaSQL(ByVal Consulta As String) As DataTable

        Dim Resultado As Long = 0
        Try
            Using cn As New Integration.Conection.clsConection
                Using cmd As New SqlCommand
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Consulta
                    Using dt As New DataTable
                        Return cn.ExecuteCmdResultDt(cmd)
                    End Using

                End Using
            End Using
        Catch ex As Exception
            'MsgBox(Err.Description)
            Throw ex
        End Try

    End Function

    Public Function ExecutaSQLIUD(ByVal Consulta As String) As Long

        Dim Resultado As Long = 0

        Try
            Using cn As New Integration.Conection.clsConection
                Using cmd As New SqlCommand
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = Consulta
                    Return cn.ExecuteCmdResultLong(cmd)
                End Using
            End Using
        Catch ex As Exception
            Resultado = Err.Number
            MsgBox(Err.Description)
            'MsgBox(Resultado)
            Return Resultado
        End Try

    End Function

End Class
