Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Querys

    Protected AccessConnection As OleDbConnection
    Protected MsSqlConnection As SqlConnection
    Protected OleReader As OleDbDataReader
    Protected SqlReader As SqlDataReader
    Protected comAccess As OleDbCommand
    Protected comMS As SqlCommand

    Public confailed As Boolean = True  'ошибка при подключении
    Public conclose As Boolean = True   'установлено ли соединение с бд
    Public query As Boolean = False     'выполнен ли запрос
    Public Data As List(Of String) = New List(Of String)
    Public tablecolumns(4), sc(3), columns(4) As String
    Public id, Value As String

End Class
