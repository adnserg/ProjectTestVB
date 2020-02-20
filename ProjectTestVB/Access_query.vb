Imports System.Data.OleDb
Public Class Access_query
    Inherits Querys

    Private tbls As DataTable
    Private dbAdapter1 As OleDbDataAdapter

#Region "Запросы"
    Public Sub Sdb(sourcetoconnect As String)
        Try
            AccessConnection = New OleDbConnection(sourcetoconnect)
            AccessConnection.Open()
            AccessConnection.Close()
            confailed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            confailed = True
        End Try
    End Sub

    Public Sub CreateTable(TableNameBox As String, ColumnOneBox As String, ColumnTwoBox As String, ColumnThreeBox As String)
        Try
            AccessConnection.Close()
            AccessConnection.Open()
            comAccess = New OleDbCommand("CREATE TABLE " +
                                                       TableNameBox + " (" +
                                                       "id COUNTER CONSTRAINT id PRIMARY KEY, " +
                                                       ColumnOneBox + " STRING," +
                                                       ColumnTwoBox + " STRING, " +
                                                       ColumnThreeBox + " STRING)", AccessConnection)
            comAccess.ExecuteNonQuery()
            AccessConnection.Close()
        Catch Ex As Exception
            MessageBox.Show("Ошибка\n" + Ex.Message)
            query = True
        End Try
    End Sub

    Public Sub ListTable()
        Try
            Data.Clear()
            AccessConnection.Close()
            AccessConnection.Open()
            tbls = AccessConnection.GetSchema("Tables", New String() {Nothing, Nothing, Nothing, "TABLE"})
            For Each row As DataRow In tbls.Rows
                Data.Add((row("TABLE_NAME")).ToString)
            Next
            AccessConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
        End Try
    End Sub

    Public Sub ListColumnsTable(ListTable As String)

        Try
            AccessConnection.Open()
            Dim name As String = ListTable
            dbAdapter1 = New OleDbDataAdapter("SELECT * FROM " + name, AccessConnection)
            tbls = New DataTable()
            dbAdapter1.Fill(tbls)
            AccessConnection.Close()
            Dim i As Integer = 0
            For Each item As DataColumn In tbls.Columns
                tablecolumns(i) = item.ToString()
                i += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
        End Try
    End Sub

    Public Sub Insert(ListTableBox As String, Column1 As String, Column2 As String, Column3 As String)
        Try
            SelectMaxId(ListTableBox)
            If id = "" Then
                id = "1"
            Else
                id = (Convert.ToInt32(id) + 1).ToString()
            End If
            AccessConnection.Close()
            AccessConnection.Open()
            comAccess = New OleDbCommand("INSERT INTO " + ListTableBox + " VALUES ('" + id + "','" + Column1 + "','" + Column2 + "','" + Column3 + "')", AccessConnection)
            comAccess.ExecuteNonQuery()
            AccessConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            query = True
        End Try
    End Sub

    Public Sub SelectMaxID(i As String)
        Try
            AccessConnection.Open()
            comAccess = New OleDbCommand("Select MAX(id) from " + i, AccessConnection)
            OleReader = comAccess.ExecuteReader()
            While (OleReader.Read())
                id = OleReader.GetValue(0).ToString()
            End While
            query = False
            OleReader.Close()
            AccessConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка")
            'query = True
        End Try
    End Sub

    Public Sub SelectLastrow(ListTableBox2 As String)
        AccessConnection.Close()
        SelectMaxID(ListTableBox2)
        For i As Integer = 0 To sc.Count - 1
            sc(i) = ""
        Next
        'If Not query Then
        If id = "" Then
            MessageBox.Show("В таблице нет записей!", "Внимание")
        Else
            Try
                AccessConnection.Open()
                Dim Query2 As String = "SELECT * FROM " + ListTableBox2 + " Where id = " + id
                comAccess = New OleDbCommand(Query2, AccessConnection)
                OleReader = comAccess.ExecuteReader()

                While (OleReader.Read())
                    sc(0) = OleReader.GetValue(1).ToString()
                    sc(1) = OleReader.GetValue(2).ToString()
                    sc(2) = OleReader.GetValue(3).ToString()
                End While
                OleReader.Close()
                AccessConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка")
                query = True
            End Try
        End If
        ' End If
    End Sub
#End Region

End Class
