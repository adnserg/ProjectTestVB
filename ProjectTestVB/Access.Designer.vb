<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Access
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Access))
        Me.ListTableBox2 = New System.Windows.Forms.ComboBox()
        Me.SelectTableName2 = New System.Windows.Forms.Label()
        Me.SNameColumn3 = New System.Windows.Forms.Label()
        Me.SelectColumn3 = New System.Windows.Forms.TextBox()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.SNameColumn2 = New System.Windows.Forms.Label()
        Me.SelectColumn2 = New System.Windows.Forms.TextBox()
        Me.SelectColumn1 = New System.Windows.Forms.TextBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.SNameColumn1 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListTableBox = New System.Windows.Forms.ComboBox()
        Me.SelectTableName = New System.Windows.Forms.Label()
        Me.NameColumn3 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.TextBox()
        Me.NameColumn2 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.TextBox()
        Me.NameColumn1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.TextBox()
        Me.InsertToTable = New System.Windows.Forms.Button()
        Me.StatusConnect = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SourceBox = New System.Windows.Forms.TextBox()
        Me.Connecting = New System.Windows.Forms.Button()
        Me.OpenDB = New System.Windows.Forms.Button()
        Me.TableNameBox = New System.Windows.Forms.TextBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonTableCreate = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.NameColumnThree = New System.Windows.Forms.Label()
        Me.ColumnThreeBox = New System.Windows.Forms.TextBox()
        Me.NameColumnTwo = New System.Windows.Forms.Label()
        Me.ColumnTwoBox = New System.Windows.Forms.TextBox()
        Me.NameColumnOne = New System.Windows.Forms.Label()
        Me.ColumnOneBox = New System.Windows.Forms.TextBox()
        Me.TableName = New System.Windows.Forms.Label()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListTableBox2
        '
        Me.ListTableBox2.FormattingEnabled = True
        Me.ListTableBox2.Location = New System.Drawing.Point(305, 13)
        Me.ListTableBox2.Name = "ListTableBox2"
        Me.ListTableBox2.Size = New System.Drawing.Size(186, 21)
        Me.ListTableBox2.TabIndex = 15
        '
        'SelectTableName2
        '
        Me.SelectTableName2.AutoSize = True
        Me.SelectTableName2.Location = New System.Drawing.Point(196, 16)
        Me.SelectTableName2.Name = "SelectTableName2"
        Me.SelectTableName2.Size = New System.Drawing.Size(103, 13)
        Me.SelectTableName2.TabIndex = 27
        Me.SelectTableName2.Text = "Выберите таблицу:"
        '
        'SNameColumn3
        '
        Me.SNameColumn3.AutoSize = True
        Me.SNameColumn3.Location = New System.Drawing.Point(464, 73)
        Me.SNameColumn3.Name = "SNameColumn3"
        Me.SNameColumn3.Size = New System.Drawing.Size(110, 13)
        Me.SNameColumn3.TabIndex = 30
        Me.SNameColumn3.Text = "Название 3 столбца"
        Me.SNameColumn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SelectColumn3
        '
        Me.SelectColumn3.Location = New System.Drawing.Point(448, 89)
        Me.SelectColumn3.Name = "SelectColumn3"
        Me.SelectColumn3.ReadOnly = True
        Me.SelectColumn3.Size = New System.Drawing.Size(212, 20)
        Me.SelectColumn3.TabIndex = 19
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(174, 40)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(318, 25)
        Me.SelectButton.TabIndex = 16
        Me.SelectButton.Text = "Вывести последнюю запись"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'SNameColumn2
        '
        Me.SNameColumn2.AutoSize = True
        Me.SNameColumn2.Location = New System.Drawing.Point(271, 73)
        Me.SNameColumn2.Name = "SNameColumn2"
        Me.SNameColumn2.Size = New System.Drawing.Size(110, 13)
        Me.SNameColumn2.TabIndex = 29
        Me.SNameColumn2.Text = "Название 2 столбца"
        Me.SNameColumn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SelectColumn2
        '
        Me.SelectColumn2.Location = New System.Drawing.Point(230, 89)
        Me.SelectColumn2.Name = "SelectColumn2"
        Me.SelectColumn2.ReadOnly = True
        Me.SelectColumn2.Size = New System.Drawing.Size(212, 20)
        Me.SelectColumn2.TabIndex = 18
        '
        'SelectColumn1
        '
        Me.SelectColumn1.Location = New System.Drawing.Point(12, 89)
        Me.SelectColumn1.Name = "SelectColumn1"
        Me.SelectColumn1.ReadOnly = True
        Me.SelectColumn1.Size = New System.Drawing.Size(212, 20)
        Me.SelectColumn1.TabIndex = 17
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.ListTableBox2)
        Me.groupBox4.Controls.Add(Me.SelectTableName2)
        Me.groupBox4.Controls.Add(Me.SNameColumn3)
        Me.groupBox4.Controls.Add(Me.SelectColumn3)
        Me.groupBox4.Controls.Add(Me.SelectButton)
        Me.groupBox4.Controls.Add(Me.SNameColumn2)
        Me.groupBox4.Controls.Add(Me.SelectColumn2)
        Me.groupBox4.Controls.Add(Me.SNameColumn1)
        Me.groupBox4.Controls.Add(Me.SelectColumn1)
        Me.groupBox4.Location = New System.Drawing.Point(9, 244)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(670, 120)
        Me.groupBox4.TabIndex = 38
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Вывод Данных"
        '
        'SNameColumn1
        '
        Me.SNameColumn1.AutoSize = True
        Me.SNameColumn1.Location = New System.Drawing.Point(60, 73)
        Me.SNameColumn1.Name = "SNameColumn1"
        Me.SNameColumn1.Size = New System.Drawing.Size(110, 13)
        Me.SNameColumn1.TabIndex = 28
        Me.SNameColumn1.Text = "Название 1 столбца"
        Me.SNameColumn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.ListTableBox)
        Me.groupBox3.Controls.Add(Me.SelectTableName)
        Me.groupBox3.Controls.Add(Me.NameColumn3)
        Me.groupBox3.Controls.Add(Me.Column3)
        Me.groupBox3.Controls.Add(Me.NameColumn2)
        Me.groupBox3.Controls.Add(Me.Column2)
        Me.groupBox3.Controls.Add(Me.NameColumn1)
        Me.groupBox3.Controls.Add(Me.Column1)
        Me.groupBox3.Controls.Add(Me.InsertToTable)
        Me.groupBox3.Location = New System.Drawing.Point(345, 76)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(334, 162)
        Me.groupBox3.TabIndex = 37
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Заполнение таблицы"
        '
        'ListTableBox
        '
        Me.ListTableBox.FormattingEnabled = True
        Me.ListTableBox.Location = New System.Drawing.Point(138, 19)
        Me.ListTableBox.Name = "ListTableBox"
        Me.ListTableBox.Size = New System.Drawing.Size(190, 21)
        Me.ListTableBox.TabIndex = 10
        '
        'SelectTableName
        '
        Me.SelectTableName.AutoSize = True
        Me.SelectTableName.Location = New System.Drawing.Point(13, 22)
        Me.SelectTableName.Name = "SelectTableName"
        Me.SelectTableName.Size = New System.Drawing.Size(103, 13)
        Me.SelectTableName.TabIndex = 14
        Me.SelectTableName.Text = "Выберите таблицу:"
        '
        'NameColumn3
        '
        Me.NameColumn3.AutoSize = True
        Me.NameColumn3.Location = New System.Drawing.Point(6, 100)
        Me.NameColumn3.Name = "NameColumn3"
        Me.NameColumn3.Size = New System.Drawing.Size(0, 13)
        Me.NameColumn3.TabIndex = 26
        Me.NameColumn3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column3
        '
        Me.Column3.Location = New System.Drawing.Point(138, 97)
        Me.Column3.Name = "Column3"
        Me.Column3.Size = New System.Drawing.Size(190, 20)
        Me.Column3.TabIndex = 13
        '
        'NameColumn2
        '
        Me.NameColumn2.AutoSize = True
        Me.NameColumn2.Location = New System.Drawing.Point(6, 74)
        Me.NameColumn2.Name = "NameColumn2"
        Me.NameColumn2.Size = New System.Drawing.Size(0, 13)
        Me.NameColumn2.TabIndex = 25
        Me.NameColumn2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column2
        '
        Me.Column2.Location = New System.Drawing.Point(138, 71)
        Me.Column2.Name = "Column2"
        Me.Column2.Size = New System.Drawing.Size(190, 20)
        Me.Column2.TabIndex = 12
        '
        'NameColumn1
        '
        Me.NameColumn1.AutoSize = True
        Me.NameColumn1.Location = New System.Drawing.Point(6, 48)
        Me.NameColumn1.Name = "NameColumn1"
        Me.NameColumn1.Size = New System.Drawing.Size(0, 13)
        Me.NameColumn1.TabIndex = 24
        Me.NameColumn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column1
        '
        Me.Column1.Location = New System.Drawing.Point(138, 45)
        Me.Column1.Name = "Column1"
        Me.Column1.Size = New System.Drawing.Size(190, 20)
        Me.Column1.TabIndex = 11
        '
        'InsertToTable
        '
        Me.InsertToTable.Location = New System.Drawing.Point(198, 123)
        Me.InsertToTable.Name = "InsertToTable"
        Me.InsertToTable.Size = New System.Drawing.Size(130, 25)
        Me.InsertToTable.TabIndex = 14
        Me.InsertToTable.Text = "Записать данные в бд"
        Me.InsertToTable.UseVisualStyleBackColor = True
        '
        'StatusConnect
        '
        Me.StatusConnect.Enabled = False
        Me.StatusConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StatusConnect.Location = New System.Drawing.Point(0, 37)
        Me.StatusConnect.Name = "StatusConnect"
        Me.StatusConnect.Size = New System.Drawing.Size(670, 25)
        Me.StatusConnect.TabIndex = 40
        Me.StatusConnect.Text = "Подключение к БД отсутствует"
        Me.StatusConnect.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.StatusConnect)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.SourceBox)
        Me.groupBox2.Controls.Add(Me.Connecting)
        Me.groupBox2.Controls.Add(Me.OpenDB)
        Me.groupBox2.Location = New System.Drawing.Point(9, 8)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(670, 62)
        Me.groupBox2.TabIndex = 35
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Подключение к бд"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Адрес БД"
        '
        'SourceBox
        '
        Me.SourceBox.Location = New System.Drawing.Point(68, 13)
        Me.SourceBox.Name = "SourceBox"
        Me.SourceBox.Size = New System.Drawing.Size(423, 20)
        Me.SourceBox.TabIndex = 2
        '
        'Connecting
        '
        Me.Connecting.Location = New System.Drawing.Point(573, 10)
        Me.Connecting.Name = "Connecting"
        Me.Connecting.Size = New System.Drawing.Size(91, 25)
        Me.Connecting.TabIndex = 4
        Me.Connecting.Text = "Подключиться"
        Me.Connecting.UseVisualStyleBackColor = True
        '
        'OpenDB
        '
        Me.OpenDB.Location = New System.Drawing.Point(506, 10)
        Me.OpenDB.Name = "OpenDB"
        Me.OpenDB.Size = New System.Drawing.Size(61, 25)
        Me.OpenDB.TabIndex = 3
        Me.OpenDB.Text = "Открыть"
        Me.OpenDB.UseVisualStyleBackColor = True
        '
        'TableNameBox
        '
        Me.TableNameBox.Location = New System.Drawing.Point(138, 19)
        Me.TableNameBox.Name = "TableNameBox"
        Me.TableNameBox.Size = New System.Drawing.Size(186, 20)
        Me.TableNameBox.TabIndex = 5
        '
        'ofd
        '
        Me.ofd.FileName = "openFileDialog1"
        '
        'ButtonTableCreate
        '
        Me.ButtonTableCreate.Location = New System.Drawing.Point(223, 123)
        Me.ButtonTableCreate.Name = "ButtonTableCreate"
        Me.ButtonTableCreate.Size = New System.Drawing.Size(101, 25)
        Me.ButtonTableCreate.TabIndex = 9
        Me.ButtonTableCreate.Text = "Создать таблицу"
        Me.ButtonTableCreate.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.NameColumnThree)
        Me.groupBox1.Controls.Add(Me.ColumnThreeBox)
        Me.groupBox1.Controls.Add(Me.NameColumnTwo)
        Me.groupBox1.Controls.Add(Me.ColumnTwoBox)
        Me.groupBox1.Controls.Add(Me.NameColumnOne)
        Me.groupBox1.Controls.Add(Me.ColumnOneBox)
        Me.groupBox1.Controls.Add(Me.TableName)
        Me.groupBox1.Controls.Add(Me.TableNameBox)
        Me.groupBox1.Controls.Add(Me.ButtonTableCreate)
        Me.groupBox1.Location = New System.Drawing.Point(9, 76)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(330, 162)
        Me.groupBox1.TabIndex = 36
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Создание таблицы"
        '
        'NameColumnThree
        '
        Me.NameColumnThree.AutoSize = True
        Me.NameColumnThree.Location = New System.Drawing.Point(6, 100)
        Me.NameColumnThree.Name = "NameColumnThree"
        Me.NameColumnThree.Size = New System.Drawing.Size(110, 13)
        Me.NameColumnThree.TabIndex = 23
        Me.NameColumnThree.Text = "Название 3 столбца"
        '
        'ColumnThreeBox
        '
        Me.ColumnThreeBox.Location = New System.Drawing.Point(138, 97)
        Me.ColumnThreeBox.Name = "ColumnThreeBox"
        Me.ColumnThreeBox.Size = New System.Drawing.Size(186, 20)
        Me.ColumnThreeBox.TabIndex = 8
        '
        'NameColumnTwo
        '
        Me.NameColumnTwo.AutoSize = True
        Me.NameColumnTwo.Location = New System.Drawing.Point(6, 74)
        Me.NameColumnTwo.Name = "NameColumnTwo"
        Me.NameColumnTwo.Size = New System.Drawing.Size(110, 13)
        Me.NameColumnTwo.TabIndex = 22
        Me.NameColumnTwo.Text = "Название 2 столбца"
        '
        'ColumnTwoBox
        '
        Me.ColumnTwoBox.Location = New System.Drawing.Point(138, 71)
        Me.ColumnTwoBox.Name = "ColumnTwoBox"
        Me.ColumnTwoBox.Size = New System.Drawing.Size(186, 20)
        Me.ColumnTwoBox.TabIndex = 7
        '
        'NameColumnOne
        '
        Me.NameColumnOne.AutoSize = True
        Me.NameColumnOne.Location = New System.Drawing.Point(6, 48)
        Me.NameColumnOne.Name = "NameColumnOne"
        Me.NameColumnOne.Size = New System.Drawing.Size(110, 13)
        Me.NameColumnOne.TabIndex = 21
        Me.NameColumnOne.Text = "Название 1 столбца"
        '
        'ColumnOneBox
        '
        Me.ColumnOneBox.Location = New System.Drawing.Point(138, 45)
        Me.ColumnOneBox.Name = "ColumnOneBox"
        Me.ColumnOneBox.Size = New System.Drawing.Size(186, 20)
        Me.ColumnOneBox.TabIndex = 6
        '
        'TableName
        '
        Me.TableName.AutoSize = True
        Me.TableName.Location = New System.Drawing.Point(13, 22)
        Me.TableName.Name = "TableName"
        Me.TableName.Size = New System.Drawing.Size(103, 13)
        Me.TableName.TabIndex = 20
        Me.TableName.Text = "Название таблицы"
        '
        'Access
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 372)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Access"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Access"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ListTableBox2 As ComboBox
    Private WithEvents SelectTableName2 As Label
    Private WithEvents SNameColumn3 As Label
    Private WithEvents SelectColumn3 As TextBox
    Private WithEvents SelectButton As Button
    Private WithEvents SNameColumn2 As Label
    Private WithEvents SelectColumn2 As TextBox
    Private WithEvents SelectColumn1 As TextBox
    Private WithEvents groupBox4 As GroupBox
    Private WithEvents SNameColumn1 As Label
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents ListTableBox As ComboBox
    Private WithEvents SelectTableName As Label
    Private WithEvents NameColumn3 As Label
    Private WithEvents Column3 As TextBox
    Private WithEvents NameColumn2 As Label
    Private WithEvents Column2 As TextBox
    Private WithEvents NameColumn1 As Label
    Private WithEvents Column1 As TextBox
    Private WithEvents InsertToTable As Button
    Private WithEvents StatusConnect As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents SourceBox As TextBox
    Private WithEvents Connecting As Button
    Private WithEvents OpenDB As Button
    Private WithEvents TableNameBox As TextBox
    Private WithEvents ofd As OpenFileDialog
    Private WithEvents ButtonTableCreate As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents NameColumnThree As Label
    Private WithEvents ColumnThreeBox As TextBox
    Private WithEvents NameColumnTwo As Label
    Private WithEvents ColumnTwoBox As TextBox
    Private WithEvents NameColumnOne As Label
    Private WithEvents ColumnOneBox As TextBox
    Private WithEvents TableName As Label
End Class
