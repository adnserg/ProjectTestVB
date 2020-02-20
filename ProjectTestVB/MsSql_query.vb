Imports System.Data.SqlClient
Public Class MsSql_query
    Inherits Querys

#Region "Запросы"
    Public Sub Sdb(sourcetoconnect As String)
        Try
            MsSqlConnection = New SqlConnection(sourcetoconnect)
            MsSqlConnection.Open()
            MsSqlConnection.Close()
            confailed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            confailed = True
        End Try
    End Sub

    Public Sub CreateTable(TableNameBox As String, ColumnOneBox As String, ColumnTwoBox As String, ColumnThreeBox As String)
        Try
            MsSqlConnection.Close()
            MsSqlConnection.Open()
            comMS = New SqlCommand("CREATE TABLE " + TableNameBox + "(" +
                    "id INT NOT NULL PRIMARY KEY," +
                    ColumnOneBox + " NVARCHAR(30), " +
                    ColumnTwoBox + " NVARCHAR(30), " +
                    ColumnThreeBox + " NVARCHAR(30))", MsSqlConnection)
            comMS.ExecuteNonQuery()
            query = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            query = False
        End Try
    End Sub

    Public Sub ListTables()
        Try
            Data.Clear()
            MsSqlConnection.Close()
            MsSqlConnection.Open()
            comMS = New SqlCommand("SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_TYPE != 'VIEW'", MsSqlConnection)
            SqlReader = comMS.ExecuteReader()
            While (SqlReader.Read())
                Data.Add(SqlReader.GetString(0))
                query = True
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            query = False
        End Try
    End Sub

    Public Sub ListColumnsTable(ListTable As String)
        Try
            MsSqlConnection.Close()
            MsSqlConnection.Open()
            comMS = New SqlCommand("SELECT column_name FROM information_schema.columns WHERE table_name = '" + ListTable + "';", MsSqlConnection)
            SqlReader = comMS.ExecuteReader()
            Dim i As Integer = 0
            While (SqlReader.Read())
                tablecolumns(i) = SqlReader(0).ToString()
                i += 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
        End Try
    End Sub

    Public Sub Insert(ListTableBox As String, Column1 As String, Column2 As String, Column3 As String)
        Try
            SelectMaxID(ListTableBox)
            If id = "" Then
                id = "0"
            Else
                id = (Convert.ToInt32(id) + 1).ToString()
            End If
            MsSqlConnection.Close()
            MsSqlConnection.Open()
            comMS = New SqlCommand("INSERT INTO " + ListTableBox + " VALUES (" + id.ToString() + ",'" + Column1 + "','" + Column2 + "','" + Column3 + "')", MsSqlConnection)
            comMS.ExecuteNonQuery()
            query = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            query = True
            MsSqlConnection.Close()
        End Try
    End Sub

    Public Sub SelectMaxID(i As String)
        MsSqlConnection.Close()
        MsSqlConnection.Open()
        comMS = New SqlCommand("Select MAX(id) from " + i, MsSqlConnection)
        SqlReader = comMS.ExecuteReader()
        While (SqlReader.Read())
            id = SqlReader.GetValue(0).ToString()
        End While
        SqlReader.Close()
        MsSqlConnection.Close()
    End Sub

    Public Sub SelectLastRow(ListTableBox2 As String)
        Try
            MsSqlConnection.Close()
            SelectMaxID(ListTableBox2)
            For i As Integer = 0 To sc.Count - 1
                sc(i) = ""
            Next
            If id = "" Then
                MessageBox.Show("В таблице нет записей!", "Внимание")
            Else
                MsSqlConnection.Open()
                comMS = New SqlCommand("SELECT * FROM " + ListTableBox2 + " Where id = " + id, MsSqlConnection)
                SqlReader = comMS.ExecuteReader()
                While (SqlReader.Read())
                    sc(0) = SqlReader.GetString(1)
                    sc(1) = SqlReader.GetString(2)
                    sc(2) = SqlReader.GetString(3)
                End While
                SqlReader.Close()
                comMS.ExecuteNonQuery()
                MsSqlConnection.Close()
            End If
            query = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            query = False
        End Try
    End Sub
#End Region

End Class
