<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmM案件
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn企業クリア = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt企業ID = New System.Windows.Forms.TextBox()
        Me.txtフリガナ = New System.Windows.Forms.TextBox()
        Me.txt参加者３ = New System.Windows.Forms.TextBox()
        Me.txt案件名 = New System.Windows.Forms.TextBox()
        Me.txt案件ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn案件クリア = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.btnカレンダー納期 = New System.Windows.Forms.Button()
        Me.btnカレンダー受注 = New System.Windows.Forms.Button()
        Me.txt納期 = New System.Windows.Forms.TextBox()
        Me.txt受注日 = New System.Windows.Forms.TextBox()
        Me.cmb担当理事 = New System.Windows.Forms.ComboBox()
        Me.txt参加者２ = New System.Windows.Forms.TextBox()
        Me.txt参加者１ = New System.Windows.Forms.TextBox()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col企業ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col案件ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colフリガナ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col案件名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col受注日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col納期 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当理事 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col参加者１ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col参加者２ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col参加者３ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colステータス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbステータス = New System.Windows.Forms.ComboBox()
        Me.btn検索 = New System.Windows.Forms.Button()
        Me.btnステータス検索 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn企業クリア
        '
        Me.btn企業クリア.Location = New System.Drawing.Point(284, 7)
        Me.btn企業クリア.Margin = New System.Windows.Forms.Padding(5)
        Me.btn企業クリア.Name = "btn企業クリア"
        Me.btn企業クリア.Size = New System.Drawing.Size(49, 27)
        Me.btn企業クリア.TabIndex = 23
        Me.btn企業クリア.Text = "＋"
        Me.btn企業クリア.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "企業ID"
        '
        'txt企業ID
        '
        Me.txt企業ID.Location = New System.Drawing.Point(110, 9)
        Me.txt企業ID.Margin = New System.Windows.Forms.Padding(5)
        Me.txt企業ID.Name = "txt企業ID"
        Me.txt企業ID.Size = New System.Drawing.Size(164, 26)
        Me.txt企業ID.TabIndex = 1
        '
        'txtフリガナ
        '
        Me.txtフリガナ.Location = New System.Drawing.Point(110, 67)
        Me.txtフリガナ.Margin = New System.Windows.Forms.Padding(5)
        Me.txtフリガナ.Name = "txtフリガナ"
        Me.txtフリガナ.Size = New System.Drawing.Size(331, 26)
        Me.txtフリガナ.TabIndex = 22
        Me.txtフリガナ.TabStop = False
        '
        'txt参加者３
        '
        Me.txt参加者３.Location = New System.Drawing.Point(786, 96)
        Me.txt参加者３.Margin = New System.Windows.Forms.Padding(5)
        Me.txt参加者３.Name = "txt参加者３"
        Me.txt参加者３.Size = New System.Drawing.Size(252, 26)
        Me.txt参加者３.TabIndex = 18
        '
        'txt案件名
        '
        Me.txt案件名.Location = New System.Drawing.Point(110, 96)
        Me.txt案件名.Margin = New System.Windows.Forms.Padding(5)
        Me.txt案件名.Name = "txt案件名"
        Me.txt案件名.Size = New System.Drawing.Size(331, 26)
        Me.txt案件名.TabIndex = 5
        '
        'txt案件ID
        '
        Me.txt案件ID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt案件ID.Location = New System.Drawing.Point(110, 38)
        Me.txt案件ID.Margin = New System.Windows.Forms.Padding(5)
        Me.txt案件ID.Name = "txt案件ID"
        Me.txt案件ID.Size = New System.Drawing.Size(164, 26)
        Me.txt案件ID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(684, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "参加者：２"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "納期"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "受注日"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "案件ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(684, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "参加者：１"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(688, 13)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "担当理事"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(684, 100)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "参加者：３"
        '
        'btn案件クリア
        '
        Me.btn案件クリア.Location = New System.Drawing.Point(283, 37)
        Me.btn案件クリア.Margin = New System.Windows.Forms.Padding(5)
        Me.btn案件クリア.Name = "btn案件クリア"
        Me.btn案件クリア.Size = New System.Drawing.Size(49, 27)
        Me.btn案件クリア.TabIndex = 24
        Me.btn案件クリア.Text = "＋"
        Me.btn案件クリア.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "案件名"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "フリガナ"
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1062, 178)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(108, 51)
        Me.btn登録.TabIndex = 23
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'btnカレンダー納期
        '
        Me.btnカレンダー納期.Location = New System.Drawing.Point(602, 125)
        Me.btnカレンダー納期.Margin = New System.Windows.Forms.Padding(5)
        Me.btnカレンダー納期.Name = "btnカレンダー納期"
        Me.btnカレンダー納期.Size = New System.Drawing.Size(31, 26)
        Me.btnカレンダー納期.TabIndex = 26
        Me.btnカレンダー納期.UseVisualStyleBackColor = True
        '
        'btnカレンダー受注
        '
        Me.btnカレンダー受注.Location = New System.Drawing.Point(301, 125)
        Me.btnカレンダー受注.Margin = New System.Windows.Forms.Padding(5)
        Me.btnカレンダー受注.Name = "btnカレンダー受注"
        Me.btnカレンダー受注.Size = New System.Drawing.Size(32, 26)
        Me.btnカレンダー受注.TabIndex = 25
        Me.btnカレンダー受注.UseVisualStyleBackColor = True
        '
        'txt納期
        '
        Me.txt納期.Location = New System.Drawing.Point(409, 125)
        Me.txt納期.Margin = New System.Windows.Forms.Padding(5)
        Me.txt納期.Name = "txt納期"
        Me.txt納期.Size = New System.Drawing.Size(187, 26)
        Me.txt納期.TabIndex = 10
        Me.txt納期.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt受注日
        '
        Me.txt受注日.Location = New System.Drawing.Point(110, 125)
        Me.txt受注日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Size = New System.Drawing.Size(187, 26)
        Me.txt受注日.TabIndex = 8
        Me.txt受注日.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb担当理事
        '
        Me.cmb担当理事.FormattingEnabled = True
        Me.cmb担当理事.Location = New System.Drawing.Point(786, 9)
        Me.cmb担当理事.Margin = New System.Windows.Forms.Padding(5)
        Me.cmb担当理事.Name = "cmb担当理事"
        Me.cmb担当理事.Size = New System.Drawing.Size(252, 27)
        Me.cmb担当理事.TabIndex = 12
        '
        'txt参加者２
        '
        Me.txt参加者２.Location = New System.Drawing.Point(786, 67)
        Me.txt参加者２.Margin = New System.Windows.Forms.Padding(5)
        Me.txt参加者２.Name = "txt参加者２"
        Me.txt参加者２.Size = New System.Drawing.Size(252, 26)
        Me.txt参加者２.TabIndex = 16
        '
        'txt参加者１
        '
        Me.txt参加者１.Location = New System.Drawing.Point(786, 38)
        Me.txt参加者１.Margin = New System.Windows.Forms.Padding(5)
        Me.txt参加者１.Name = "txt参加者１"
        Me.txt参加者１.Size = New System.Drawing.Size(252, 26)
        Me.txt参加者１.TabIndex = 14
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col企業ID, Me.col案件ID, Me.colフリガナ, Me.col案件名, Me.col受注日, Me.col納期, Me.col担当理事, Me.col参加者１, Me.col参加者２, Me.col参加者３, Me.col備考, Me.colステータス})
        Me.dgv一覧.Location = New System.Drawing.Point(6, 239)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowHeadersWidth = 51
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1166, 449)
        Me.dgv一覧.TabIndex = 27
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'col企業ID
        '
        Me.col企業ID.DataPropertyName = "企業ID"
        Me.col企業ID.HeaderText = "企業ID"
        Me.col企業ID.Name = "col企業ID"
        Me.col企業ID.ReadOnly = True
        '
        'col案件ID
        '
        Me.col案件ID.DataPropertyName = "案件ID"
        Me.col案件ID.HeaderText = "案件ID"
        Me.col案件ID.Name = "col案件ID"
        Me.col案件ID.ReadOnly = True
        '
        'colフリガナ
        '
        Me.colフリガナ.DataPropertyName = "フリガナ"
        Me.colフリガナ.HeaderText = "フリガナ"
        Me.colフリガナ.Name = "colフリガナ"
        Me.colフリガナ.ReadOnly = True
        Me.colフリガナ.Width = 120
        '
        'col案件名
        '
        Me.col案件名.DataPropertyName = "案件名"
        Me.col案件名.HeaderText = "案件名"
        Me.col案件名.Name = "col案件名"
        Me.col案件名.ReadOnly = True
        Me.col案件名.Width = 120
        '
        'col受注日
        '
        Me.col受注日.DataPropertyName = "受注日"
        Me.col受注日.HeaderText = "受注日"
        Me.col受注日.Name = "col受注日"
        Me.col受注日.ReadOnly = True
        Me.col受注日.Width = 120
        '
        'col納期
        '
        Me.col納期.DataPropertyName = "納期"
        Me.col納期.HeaderText = "納期"
        Me.col納期.Name = "col納期"
        Me.col納期.ReadOnly = True
        Me.col納期.Width = 120
        '
        'col担当理事
        '
        Me.col担当理事.DataPropertyName = "担当理事"
        Me.col担当理事.HeaderText = "担当理事"
        Me.col担当理事.Name = "col担当理事"
        Me.col担当理事.ReadOnly = True
        Me.col担当理事.Width = 120
        '
        'col参加者１
        '
        Me.col参加者１.DataPropertyName = "参加者１"
        Me.col参加者１.HeaderText = "参加者１"
        Me.col参加者１.Name = "col参加者１"
        Me.col参加者１.ReadOnly = True
        Me.col参加者１.Width = 120
        '
        'col参加者２
        '
        Me.col参加者２.DataPropertyName = "参加者２"
        Me.col参加者２.HeaderText = "参加者２"
        Me.col参加者２.Name = "col参加者２"
        Me.col参加者２.ReadOnly = True
        Me.col参加者２.Width = 120
        '
        'col参加者３
        '
        Me.col参加者３.DataPropertyName = "参加者３"
        Me.col参加者３.HeaderText = "参加者３"
        Me.col参加者３.Name = "col参加者３"
        Me.col参加者３.ReadOnly = True
        Me.col参加者３.Width = 120
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.ReadOnly = True
        Me.col備考.Width = 200
        '
        'colステータス
        '
        Me.colステータス.DataPropertyName = "ステータス"
        Me.colステータス.HeaderText = "ステータス"
        Me.colステータス.Name = "colステータス"
        Me.colステータス.ReadOnly = True
        Me.colステータス.Width = 150
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 164)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "備考"
        '
        'txt備考
        '
        Me.txt備考.Location = New System.Drawing.Point(110, 158)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(5)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt備考.Size = New System.Drawing.Size(928, 71)
        Me.txt備考.TabIndex = 22
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(902, 694)
        Me.btnCSV.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(110, 40)
        Me.btnCSV.TabIndex = 28
        Me.btnCSV.Text = "CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(689, 130)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 19)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "ステータス"
        '
        'cmbステータス
        '
        Me.cmbステータス.FormattingEnabled = True
        Me.cmbステータス.Location = New System.Drawing.Point(786, 127)
        Me.cmbステータス.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbステータス.Name = "cmbステータス"
        Me.cmbステータス.Size = New System.Drawing.Size(252, 27)
        Me.cmbステータス.TabIndex = 20
        '
        'btn検索
        '
        Me.btn検索.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn検索.Location = New System.Drawing.Point(446, 94)
        Me.btn検索.Margin = New System.Windows.Forms.Padding(5)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(70, 27)
        Me.btn検索.TabIndex = 6
        Me.btn検索.Text = "検索"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'btnステータス検索
        '
        Me.btnステータス検索.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnステータス検索.Location = New System.Drawing.Point(1042, 127)
        Me.btnステータス検索.Margin = New System.Windows.Forms.Padding(5)
        Me.btnステータス検索.Name = "btnステータス検索"
        Me.btnステータス検索.Size = New System.Drawing.Size(70, 27)
        Me.btnステータス検索.TabIndex = 102
        Me.btnステータス検索.Text = "検索"
        Me.btnステータス検索.UseVisualStyleBackColor = True
        '
        'frmM案件
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btnステータス検索)
        Me.Controls.Add(Me.btn検索)
        Me.Controls.Add(Me.cmbステータス)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.txt参加者１)
        Me.Controls.Add(Me.txt参加者２)
        Me.Controls.Add(Me.cmb担当理事)
        Me.Controls.Add(Me.txt受注日)
        Me.Controls.Add(Me.txt納期)
        Me.Controls.Add(Me.btnカレンダー受注)
        Me.Controls.Add(Me.btnカレンダー納期)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn案件クリア)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt案件ID)
        Me.Controls.Add(Me.txt案件名)
        Me.Controls.Add(Me.txt参加者３)
        Me.Controls.Add(Me.txtフリガナ)
        Me.Controls.Add(Me.txt企業ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn企業クリア)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmM案件"
        Me.Text = "frmM案件"
        Me.Controls.SetChildIndex(Me.btn企業クリア, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txt企業ID, 0)
        Me.Controls.SetChildIndex(Me.txtフリガナ, 0)
        Me.Controls.SetChildIndex(Me.txt参加者３, 0)
        Me.Controls.SetChildIndex(Me.txt案件名, 0)
        Me.Controls.SetChildIndex(Me.txt案件ID, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.btn案件クリア, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.btnカレンダー納期, 0)
        Me.Controls.SetChildIndex(Me.btnカレンダー受注, 0)
        Me.Controls.SetChildIndex(Me.txt納期, 0)
        Me.Controls.SetChildIndex(Me.txt受注日, 0)
        Me.Controls.SetChildIndex(Me.cmb担当理事, 0)
        Me.Controls.SetChildIndex(Me.txt参加者２, 0)
        Me.Controls.SetChildIndex(Me.txt参加者１, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.btnCSV, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cmbステータス, 0)
        Me.Controls.SetChildIndex(Me.btn検索, 0)
        Me.Controls.SetChildIndex(Me.btnステータス検索, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn企業クリア As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt企業ID As TextBox
    Friend WithEvents txtフリガナ As TextBox
    Friend WithEvents txt参加者３ As TextBox
    Friend WithEvents txt案件名 As TextBox
    Friend WithEvents txt案件ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn案件クリア As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn登録 As Button
    Friend WithEvents btnカレンダー納期 As Button
    Friend WithEvents btnカレンダー受注 As Button
    Friend WithEvents txt納期 As TextBox
    Friend WithEvents txt受注日 As TextBox
    Friend WithEvents cmb担当理事 As ComboBox
    Friend WithEvents txt参加者２ As TextBox
    Friend WithEvents txt参加者１ As TextBox
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents btnCSV As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbステータス As ComboBox
    Friend WithEvents btn検索 As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col企業ID As DataGridViewTextBoxColumn
    Friend WithEvents col案件ID As DataGridViewTextBoxColumn
    Friend WithEvents colフリガナ As DataGridViewTextBoxColumn
    Friend WithEvents col案件名 As DataGridViewTextBoxColumn
    Friend WithEvents col受注日 As DataGridViewTextBoxColumn
    Friend WithEvents col納期 As DataGridViewTextBoxColumn
    Friend WithEvents col担当理事 As DataGridViewTextBoxColumn
    Friend WithEvents col参加者１ As DataGridViewTextBoxColumn
    Friend WithEvents col参加者２ As DataGridViewTextBoxColumn
    Friend WithEvents col参加者３ As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
    Friend WithEvents colステータス As DataGridViewTextBoxColumn
    Friend WithEvents btnステータス検索 As Button
End Class
