Public Class MsSql
    ReadOnly MsSql As New MsSql_query
    ReadOnly querys As New Querys
    Private check_click_connect As Boolean = True

#Region "Подключение к БД"
    Private Function Connect(server As String, database As String)
        Querys.Value = "Data Source = " + server + "; Initial Catalog = " + database + "; Integrated Security = SSPI;"
        Return querys.Value

    End Function

#End Region

#Region "События"
    Private Sub MsSql_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusConnect.BackColor = Color.Red
    End Sub

    Private Sub Connecting_Click(sender As Object, e As EventArgs) Handles Connecting.Click
        'проверяем все ли заполнено
        If SourceBox.Text = "" Or dbBox.Text = "" Then
            MessageBox.Show("Заполните все поля для подключения!", "Внимание!")
        Else
            Connect(SourceBox.Text, dbBox.Text) 'получаем строку подключения
            MsSql.Sdb(querys.Value) 'тестовое подключение для проверки
            If Not MsSql.confailed Then 'Если все успешно выводим сообщение и блокируем кнопку
                If check_click_connect Then
                    MessageBox.Show("Подключение успешно установлено", "Great!")
                    SourceBox.Enabled = False
                    dbBox.Enabled = False
                    Connecting.Text = "Отключиться"
                    StatusConnect.BackColor = Color.Green
                    StatusConnect.Text = "Подключение к БД установлено"
                    check_click_connect = False
                    MsSql.conclose = False
                Else
                    SourceBox.Enabled = True
                    dbBox.Enabled = True
                    check_click_connect = True
                    Connecting.Text = "Подключиться"
                    StatusConnect.BackColor = Color.Red
                    StatusConnect.Text = "Подключение к БД отсутствует"
                    MsSql.conclose = True
                End If
            End If
        End If
    End Sub

    Private Sub ButtonTableCreate_Click(sender As Object, e As EventArgs) Handles ButtonTableCreate.Click
        If Not MsSql.conclose Then
            If TableNameBox.Text = "" Or ColumnOneBox.Text = "" Or ColumnTwoBox.Text = "" Or ColumnThreeBox.Text = "" Then
                MessageBox.Show("Заполните все поля!", "Внимание!")
            Else
                MsSql.CreateTable(TableNameBox.Text, ColumnOneBox.Text, ColumnTwoBox.Text, ColumnThreeBox.Text)
                If MsSql.query Then
                    MessageBox.Show("Таблица успешно создана", "Great!") '//Если все хорошо - уведомляем
                End If
            End If
        Else
            MessageBox.Show("Подключите БД", "Внимание!")
        End If
    End Sub

    Private Sub ListTableBox_Click(sender As Object, e As EventArgs) Handles ListTableBox.Click
        If Not MsSql.conclose Then
            ListTableBox.Items.Clear()
            MsSql.ListTables()
            For i As Integer = 0 To MsSql.Data.Count - 1
                ListTableBox.Items.Add(MsSql.Data(i))
            Next
        Else
            MessageBox.Show("Подключите БД", "Внимание!")
            ListTableBox.Items.Clear()
        End If
    End Sub

    Private Sub ListTableBox_TextChanged(sender As Object, e As EventArgs) Handles ListTableBox.TextChanged
        Dim errors As Boolean = True
        If ListTableBox.Text = "" Then
            NameColumn1.Text = ""
            NameColumn2.Text = ""
            NameColumn3.Text = ""
        Else
            For i As Integer = 0 To ListTableBox.Items.Count - 1
                If ListTableBox.Text = ListTableBox.Items(i).ToString() Then
                    errors = False
                    Exit For
                End If
            Next
            If errors Then
                MessageBox.Show("Такой таблицы нет!Выберите из списка", "Внимание!")
                NameColumn1.Text = ""
                NameColumn2.Text = ""
                NameColumn3.Text = ""
            Else
                MsSql.ListColumnsTable(ListTableBox.Text)
                NameColumn1.Text = MsSql.tablecolumns(1)
                NameColumn2.Text = MsSql.tablecolumns(2)
                NameColumn3.Text = MsSql.tablecolumns(3)
            End If
        End If
    End Sub

    Private Sub InsertToTable_Click(sender As Object, e As EventArgs) Handles InsertToTable.Click
        If MsSql.conclose Then
            MessageBox.Show("Подключите БД", "Внимание!")
        Else
            If ListTableBox.Text = "" Then
                MessageBox.Show("Выберите таблицу из списка", "Внимание")
            ElseIf Column1.Text <> "" Or Column2.Text <> "" Or Column3.Text <> "" Then
                MsSql.Insert(ListTableBox.Text, Column1.Text, Column2.Text, Column3.Text)
                MessageBox.Show("Запись успешно добавлена в таблицу!", "Great!")
            Else
                MessageBox.Show("Для записи, заполните хотябы одно из полей", "Внимание")
            End If
        End If
    End Sub

    Private Sub ListTableBox2_Click(sender As Object, e As EventArgs) Handles ListTableBox2.Click
        If Not MsSql.conclose Then
            ListTableBox2.Items.Clear()
            MsSql.ListTables()
            For i As Integer = 0 To MsSql.Data.Count - 1
                ListTableBox2.Items.Add(MsSql.Data(i))
            Next
        Else
            MessageBox.Show("Подключите БД", "Внимание!")
        End If
    End Sub

    Private Sub ListTableBox2_TextChanged(sender As Object, e As EventArgs) Handles ListTableBox2.TextChanged
        SelectColumn1.Text = ""
        SelectColumn2.Text = ""
        SelectColumn3.Text = ""
        Dim errors As Boolean = True
        If ListTableBox2.Text = "" Then
            SNameColumn1.Text = ""
            SNameColumn2.Text = ""
            SNameColumn3.Text = ""
        Else
            For i As Integer = 0 To ListTableBox2.Items.Count - 1
                If ListTableBox2.Text = ListTableBox2.Items(i).ToString() Then
                    errors = False
                    Exit For
                End If
            Next
            If errors Then
                MessageBox.Show("Такой таблицы нет!Выберите из списка", "Внимание!")
                SNameColumn1.Text = "Название 1 столбца"
                SNameColumn2.Text = "Название 2 столбца"
                SNameColumn3.Text = "Название 3 столбца"
            Else
                MsSql.ListColumnsTable(ListTableBox2.Text)
                SNameColumn1.Text = MsSql.tablecolumns(1)
                SNameColumn2.Text = MsSql.tablecolumns(2)
                SNameColumn3.Text = MsSql.tablecolumns(3)
            End If
        End If
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        If MsSql.conclose Then
            MessageBox.Show("Подключите БД", "Внимание!")
        Else
            If ListTableBox2.Text = "" Then
                MessageBox.Show("Выберите таблицу из списка!", "Внимание")
            Else
                MsSql.SelectLastRow(ListTableBox2.Text)
                SelectColumn1.Text = MsSql.sc(0)
                SelectColumn2.Text = MsSql.sc(1)
                SelectColumn3.Text = MsSql.sc(2)
            End If
        End If
    End Sub

    Private Sub MsSql_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WinAppTest.Show()
    End Sub

#Region "Запрет на ввод цифр"
    Private Sub TableNameBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TableNameBox.KeyPress
        Block(e)
    End Sub

    Private Sub ColumnOneBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ColumnOneBox.KeyPress
        Block(e)
    End Sub

    Private Sub ColumnTwoBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ColumnTwoBox.KeyPress
        Block(e)
    End Sub

    Private Sub ColumnThreeBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ColumnThreeBox.KeyPress
        Block(e)
    End Sub

    Public Sub Block(e)
        If e.KeyChar <> Chr(8) And e.KeyChar <> Chr(32) And Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

#End Region

#End Region

End Class