Public Class Access
    Dim stconnect As Boolean = True
    ReadOnly Acc As New Access_query
    ReadOnly querys As New Querys
    Dim filename2 As String

#Region "Подключение к бд"

    Public Function Connect(file As String)
        If file <> "" Then
            querys.Value = "Provider = Microsoft.Jet.OLEDB.4.0; User Id = Admin; Password = ''; " + "Data Source = " + file
            filename2 = file
        Else
            MessageBox.Show("Введите место расположения БД Access", "Внимание!")
            Return Nothing
        End If
        Return querys.Value
    End Function


    Public Function Connect()
        ofd.FileName = ""
        ofd.Filter = "бд access (*.mdb)|*.mdb"
        ofd.FilterIndex = 2
        Dim filename As String = ""
        If ofd.ShowDialog() = DialogResult.OK Then
            filename = ofd.FileName
        End If
        If filename = "" Then
            Return ""
        End If
        querys.Value = "Provider = Microsoft.Jet.OLEDB.4.0; User Id = Admin; Password = ''; " + "Data Source = " + filename
        filename2 = filename
        Return querys.Value
    End Function

#End Region

#Region "События"
    Private Sub OpenDB_Click(sender As Object, e As EventArgs) Handles OpenDB.Click
        Connect()
        SourceBox.Text = filename2
    End Sub

    Private Sub Connecting_Click(sender As Object, e As EventArgs) Handles Connecting.Click
        If Connect(SourceBox.Text) <> Nothing Then
            Acc.Sdb(querys.Value)
        End If
        If Not Acc.confailed Then
            If stconnect Then
                '// MessageBox.Show("Подключение успешно установлено")
                '//Connecting.Enabled = false
                Connecting.Text = "Отключиться"
                StatusConnect.BackColor = Color.Green
                StatusConnect.Text = "Подключение к БД установлено"
                SourceBox.Enabled = False
                OpenDB.Enabled = False
                stconnect = False
                Acc.conclose = False
            Else
                '//MessageBox.Show("Подключение разорвано");
                Connecting.Text = "Подключиться"
                StatusConnect.Text = "Подключение к БД отсутствует"
                StatusConnect.BackColor = Color.Red
                SourceBox.Enabled = True
                OpenDB.Enabled = True
                stconnect = True
                Acc.conclose = True
            End If
        End If
    End Sub

    Private Sub ButtonTableCreate_Click(sender As Object, e As EventArgs) Handles ButtonTableCreate.Click
        If Acc.conclose Then
            MessageBox.Show("Подключите БД", "Внимание!")
        ElseIf TableNameBox.Text = "" Then
            MessageBox.Show("Заполните поле 'название таблицы'", "Внимание!")
            'Acc.confailed = True
        ElseIf ColumnOneBox.Text = "" Then
            MessageBox.Show("Заполните поле 'название 1-го столбца'", "Внимание!")
            'Acc.confailed = True
        ElseIf ColumnTwoBox.Text = "" Then
            MessageBox.Show("Заполните поле 'название 2-го столбца'", "Внимание!")
            'Acc.confailed = True
        ElseIf ColumnThreeBox.Text = "" Then
            MessageBox.Show("Заполните поле 'название 3-го столбца'", "Внимание!")
            'Acc.confailed = True
        Else
            Acc.CreateTable(TableNameBox.Text, ColumnOneBox.Text, ColumnTwoBox.Text, ColumnThreeBox.Text)
            If Not Acc.query Then
                MessageBox.Show("Таблица успешно создана", "Great!")
            End If
        End If
    End Sub

    Private Sub ListTableBox_Click(sender As Object, e As EventArgs) Handles ListTableBox.Click
        If Not Acc.conclose Then
            ListTableBox.Items.Clear()
            '  ListTableBox2.Items.Clear()
            Acc.ListTable()
            For i As Integer = 0 To Acc.Data.Count - 1
                ListTableBox.Items.Add(Acc.Data(i))
                '     ListTableBox2.Items.Add(Acc.Data(i))
            Next
        Else
            MessageBox.Show("Подключите БД", "Внимание!")
            ListTableBox.Items.Clear()
            '  ListTableBox2.Items.Clear()
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
                MessageBox.Show("Такой таблицы нет! Выберите из списка", "Внимание!")
                NameColumn1.Text = ""
                NameColumn2.Text = ""
                NameColumn3.Text = ""
            Else
                Acc.ListColumnsTable(ListTableBox.Text)
                NameColumn1.Text = Acc.tablecolumns(1)
                NameColumn2.Text = Acc.tablecolumns(2)
                NameColumn3.Text = Acc.tablecolumns(3)
            End If

        End If
    End Sub

    Private Sub InsertToTable_Click(sender As Object, e As EventArgs) Handles InsertToTable.Click
        If Acc.conclose Then
            MessageBox.Show("Подключите БД", "Внимание!")
        Else
            If (ListTableBox.Text = "") Then
                MessageBox.Show("Выберите таблицу из списка", "Внимание")
            ElseIf Column1.Text <> "" Or Column2.Text <> "" Or Column3.Text <> "" Then
                Acc.Insert(ListTableBox.Text, Column1.Text, Column2.Text, Column3.Text)
                If Not Acc.query Then
                    MessageBox.Show("Данные успешно записаны", "Great!")
                End If
            Else
                MessageBox.Show("Для записи, заполните хотябы одно из полей", "Внимание")
            End If
        End If
    End Sub

    Private Sub ListTableBox2_Click(sender As Object, e As EventArgs) Handles ListTableBox2.Click
        If Not Acc.conclose Then
            ' ListTableBox.Items.Clear()
            ListTableBox2.Items.Clear()
            Acc.ListTable()
            For i As Integer = 0 To Acc.Data.Count - 1
                ' ListTableBox.Items.Add(Acc.Data(i))
                ListTableBox2.Items.Add(Acc.Data(i))
            Next
        Else
            MessageBox.Show("Подключите БД", "Внимание!")
            ' ListTableBox.Items.Clear()
            ListTableBox2.Items.Clear()
        End If
    End Sub

    Private Sub ListTableBox2_TextChanged(sender As Object, e As EventArgs) Handles ListTableBox2.TextChanged
        Dim errors As Boolean = True
        SelectColumn1.Text = ""
        SelectColumn2.Text = ""
        SelectColumn3.Text = ""
        If ListTableBox2.Text = "" Then
            NameColumn1.Text = ""
            NameColumn2.Text = ""
            NameColumn3.Text = ""
        Else
            For i As Integer = 0 To ListTableBox.Items.Count - 1
                If ListTableBox2.Text = ListTableBox.Items(i).ToString() Then
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
                Acc.ListColumnsTable(ListTableBox2.Text)
                SNameColumn1.Text = Acc.tablecolumns(1)
                SNameColumn2.Text = Acc.tablecolumns(2)
                SNameColumn3.Text = Acc.tablecolumns(3)
            End If
        End If
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        If Acc.conclose Then
            MessageBox.Show("Подключите БД", "Внимание!")
        Else
            If ListTableBox2.Text = "" Then
                MessageBox.Show("Выберите таблицу из списка!", "Внимание")
            Else
                Acc.SelectLastrow(ListTableBox2.Text)
                SelectColumn1.Text = Acc.sc(0)
                SelectColumn2.Text = Acc.sc(1)
                SelectColumn3.Text = Acc.sc(2)
            End If
        End If
    End Sub

    Private Sub Access_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WinAppTest.Show()
    End Sub

    Private Sub Access_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameColumn1.Text = ""
        NameColumn2.Text = ""
        NameColumn3.Text = ""
        SNameColumn1.Text = ""
        SNameColumn2.Text = ""
        SNameColumn3.Text = ""
        StatusConnect.BackColor = Color.Red
    End Sub

#End Region

End Class