<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrmS予定登録
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.chk休日 = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btn前 = New System.Windows.Forms.Button()
        Me.btn次 = New System.Windows.Forms.Button()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.複数削除 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.削除 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col会員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col記事 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMode表示 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp開始時間 = New System.Windows.Forms.DateTimePicker()
        Me.dtp終了時間 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt予定 = New System.Windows.Forms.TextBox()
        Me.txt予定ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt開始日 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn追加 = New System.Windows.Forms.Button()
        Me.txt終了日 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt記事 = New System.Windows.Forms.TextBox()
        Me.cmb繰返し = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn終了日 = New System.Windows.Forms.Button()
        Me.cmb会員 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt枝番号 = New System.Windows.Forms.TextBox()
        Me.grp予定登録 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.grp更新時Enable = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp予定登録.SuspendLayout()
        Me.grp更新時Enable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(1050, 713)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(120, 40)
        Me.Cancel_Button.TabIndex = 8
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(44, 9)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(213, 27)
        Me.lbl日付.TabIndex = 1
        Me.lbl日付.Text = "yyyy/mm/dd（曜）"
        '
        'chk休日
        '
        Me.chk休日.AutoSize = True
        Me.chk休日.Location = New System.Drawing.Point(312, 11)
        Me.chk休日.Name = "chk休日"
        Me.chk休日.Size = New System.Drawing.Size(66, 23)
        Me.chk休日.TabIndex = 3
        Me.chk休日.Text = "休日"
        Me.chk休日.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(920, 713)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 40)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btn前
        '
        Me.btn前.Location = New System.Drawing.Point(12, 9)
        Me.btn前.Name = "btn前"
        Me.btn前.Size = New System.Drawing.Size(26, 27)
        Me.btn前.TabIndex = 0
        Me.btn前.TabStop = False
        Me.btn前.Text = "<"
        Me.btn前.UseVisualStyleBackColor = True
        '
        'btn次
        '
        Me.btn次.Location = New System.Drawing.Point(263, 9)
        Me.btn次.Name = "btn次"
        Me.btn次.Size = New System.Drawing.Size(26, 27)
        Me.btn次.TabIndex = 2
        Me.btn次.TabStop = False
        Me.btn次.Text = ">"
        Me.btn次.UseVisualStyleBackColor = True
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col予定ID, Me.複数削除, Me.削除, Me.col会員ID, Me.氏名, Me.col開始日, Me.col終了日, Me.col開始時間, Me.col終了時間, Me.col予定, Me.col記事, Me.colcolor})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv一覧.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv一覧.Location = New System.Drawing.Point(12, 282)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1158, 423)
        Me.dgv一覧.TabIndex = 6
        Me.dgv一覧.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.Frozen = True
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colID.Visible = False
        Me.colID.Width = 70
        '
        'col予定ID
        '
        Me.col予定ID.DataPropertyName = "予定ID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col予定ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.col予定ID.HeaderText = "NO."
        Me.col予定ID.Name = "col予定ID"
        Me.col予定ID.ReadOnly = True
        Me.col予定ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col予定ID.Width = 70
        '
        '複数削除
        '
        Me.複数削除.DataPropertyName = "複数削除"
        Me.複数削除.HeaderText = "複数削除"
        Me.複数削除.Name = "複数削除"
        Me.複数削除.ReadOnly = True
        Me.複数削除.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.複数削除.Width = 110
        '
        '削除
        '
        Me.削除.DataPropertyName = "削除"
        Me.削除.HeaderText = "削除"
        Me.削除.Name = "削除"
        Me.削除.ReadOnly = True
        Me.削除.Width = 70
        '
        'col会員ID
        '
        Me.col会員ID.DataPropertyName = "会員ID"
        Me.col会員ID.HeaderText = ""
        Me.col会員ID.Name = "col会員ID"
        Me.col会員ID.ReadOnly = True
        Me.col会員ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col会員ID.Width = 20
        '
        '氏名
        '
        Me.氏名.DataPropertyName = "氏名"
        Me.氏名.HeaderText = "name"
        Me.氏名.Name = "氏名"
        Me.氏名.ReadOnly = True
        Me.氏名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col開始日
        '
        Me.col開始日.DataPropertyName = "開始日"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col開始日.DefaultCellStyle = DataGridViewCellStyle2
        Me.col開始日.HeaderText = "開始日"
        Me.col開始日.Name = "col開始日"
        Me.col開始日.ReadOnly = True
        Me.col開始日.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col終了日
        '
        Me.col終了日.DataPropertyName = "終了日"
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col終了日.DefaultCellStyle = DataGridViewCellStyle3
        Me.col終了日.HeaderText = "終了日"
        Me.col終了日.Name = "col終了日"
        Me.col終了日.ReadOnly = True
        Me.col終了日.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col開始時間
        '
        Me.col開始時間.DataPropertyName = "開始時間"
        Me.col開始時間.HeaderText = "開始"
        Me.col開始時間.Name = "col開始時間"
        Me.col開始時間.ReadOnly = True
        Me.col開始時間.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col終了時間
        '
        Me.col終了時間.DataPropertyName = "終了時間"
        Me.col終了時間.HeaderText = "終了"
        Me.col終了時間.Name = "col終了時間"
        Me.col終了時間.ReadOnly = True
        Me.col終了時間.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col予定
        '
        Me.col予定.DataPropertyName = "予定"
        Me.col予定.HeaderText = "予定"
        Me.col予定.Name = "col予定"
        Me.col予定.ReadOnly = True
        Me.col予定.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col予定.Width = 150
        '
        'col記事
        '
        Me.col記事.DataPropertyName = "記事"
        Me.col記事.HeaderText = "記事"
        Me.col記事.Name = "col記事"
        Me.col記事.ReadOnly = True
        Me.col記事.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col記事.Width = 150
        '
        'colcolor
        '
        Me.colcolor.DataPropertyName = "color"
        Me.colcolor.HeaderText = "color"
        Me.colcolor.Name = "colcolor"
        Me.colcolor.ReadOnly = True
        Me.colcolor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblMode表示
        '
        Me.lblMode表示.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.lblMode表示.Location = New System.Drawing.Point(399, 9)
        Me.lblMode表示.Name = "lblMode表示"
        Me.lblMode表示.Size = New System.Drawing.Size(605, 25)
        Me.lblMode表示.TabIndex = 4
        Me.lblMode表示.Text = "XX mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "時間"
        '
        'dtp開始時間
        '
        Me.dtp開始時間.CustomFormat = "HH:mm"
        Me.dtp開始時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp開始時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp開始時間.Location = New System.Drawing.Point(286, 49)
        Me.dtp開始時間.Name = "dtp開始時間"
        Me.dtp開始時間.ShowUpDown = True
        Me.dtp開始時間.Size = New System.Drawing.Size(71, 26)
        Me.dtp開始時間.TabIndex = 9
        '
        'dtp終了時間
        '
        Me.dtp終了時間.CustomFormat = "HH:mm"
        Me.dtp終了時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp終了時間.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dtp終了時間.Location = New System.Drawing.Point(387, 49)
        Me.dtp終了時間.Name = "dtp終了時間"
        Me.dtp終了時間.ShowUpDown = True
        Me.dtp終了時間.Size = New System.Drawing.Size(71, 26)
        Me.dtp終了時間.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "～"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "予定"
        '
        'txt予定
        '
        Me.txt予定.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt予定.Location = New System.Drawing.Point(85, 82)
        Me.txt予定.MaxLength = 50
        Me.txt予定.Name = "txt予定"
        Me.txt予定.Size = New System.Drawing.Size(836, 26)
        Me.txt予定.TabIndex = 14
        '
        'txt予定ID
        '
        Me.txt予定ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt予定ID.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt予定ID.Location = New System.Drawing.Point(85, 16)
        Me.txt予定ID.Name = "txt予定ID"
        Me.txt予定ID.ReadOnly = True
        Me.txt予定ID.Size = New System.Drawing.Size(121, 26)
        Me.txt予定ID.TabIndex = 1
        Me.txt予定ID.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "開始日"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID"
        '
        'txt開始日
        '
        Me.txt開始日.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt開始日.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt開始日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt開始日.Location = New System.Drawing.Point(85, 49)
        Me.txt開始日.MaxLength = 50
        Me.txt開始日.Name = "txt開始日"
        Me.txt開始日.ReadOnly = True
        Me.txt開始日.Size = New System.Drawing.Size(121, 26)
        Me.txt開始日.TabIndex = 7
        Me.txt開始日.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "終了日"
        '
        'btn追加
        '
        Me.btn追加.Location = New System.Drawing.Point(1006, 172)
        Me.btn追加.Name = "btn追加"
        Me.btn追加.Size = New System.Drawing.Size(120, 40)
        Me.btn追加.TabIndex = 20
        Me.btn追加.Text = "登録"
        Me.btn追加.UseVisualStyleBackColor = True
        '
        'txt終了日
        '
        Me.txt終了日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt終了日.Location = New System.Drawing.Point(304, 1)
        Me.txt終了日.MaxLength = 50
        Me.txt終了日.Name = "txt終了日"
        Me.txt終了日.Size = New System.Drawing.Size(117, 26)
        Me.txt終了日.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "記事"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(282, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "会員選択"
        '
        'txt記事
        '
        Me.txt記事.AcceptsReturn = True
        Me.txt記事.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt記事.Location = New System.Drawing.Point(85, 114)
        Me.txt記事.MaxLength = 50
        Me.txt記事.Multiline = True
        Me.txt記事.Name = "txt記事"
        Me.txt記事.Size = New System.Drawing.Size(836, 66)
        Me.txt記事.TabIndex = 16
        '
        'cmb繰返し
        '
        Me.cmb繰返し.FormattingEnabled = True
        Me.cmb繰返し.Items.AddRange(New Object() {"なし"})
        Me.cmb繰返し.Location = New System.Drawing.Point(147, 1)
        Me.cmb繰返し.Name = "cmb繰返し"
        Me.cmb繰返し.Size = New System.Drawing.Size(68, 27)
        Me.cmb繰返し.TabIndex = 2
        Me.cmb繰返し.Text = "なし"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "くり返し"
        '
        'btn終了日
        '
        Me.btn終了日.Image = Global.カシオペイア.My.Resources.Resources.カレンダー
        Me.btn終了日.Location = New System.Drawing.Point(429, 0)
        Me.btn終了日.Margin = New System.Windows.Forms.Padding(5)
        Me.btn終了日.Name = "btn終了日"
        Me.btn終了日.Size = New System.Drawing.Size(26, 26)
        Me.btn終了日.TabIndex = 5
        Me.btn終了日.TabStop = False
        Me.btn終了日.UseVisualStyleBackColor = True
        '
        'cmb会員
        '
        Me.cmb会員.FormattingEnabled = True
        Me.cmb会員.Location = New System.Drawing.Point(373, 16)
        Me.cmb会員.Name = "cmb会員"
        Me.cmb会員.Size = New System.Drawing.Size(156, 27)
        Me.cmb会員.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Color"
        '
        'txt枝番号
        '
        Me.txt枝番号.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt枝番号.Location = New System.Drawing.Point(212, 16)
        Me.txt枝番号.Name = "txt枝番号"
        Me.txt枝番号.ReadOnly = True
        Me.txt枝番号.Size = New System.Drawing.Size(64, 26)
        Me.txt枝番号.TabIndex = 2
        Me.txt枝番号.TabStop = False
        '
        'grp予定登録
        '
        Me.grp予定登録.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp予定登録.Controls.Add(Me.btnClear)
        Me.grp予定登録.Controls.Add(Me.txtColor)
        Me.grp予定登録.Controls.Add(Me.btnColor)
        Me.grp予定登録.Controls.Add(Me.grp更新時Enable)
        Me.grp予定登録.Controls.Add(Me.txt枝番号)
        Me.grp予定登録.Controls.Add(Me.Label12)
        Me.grp予定登録.Controls.Add(Me.cmb会員)
        Me.grp予定登録.Controls.Add(Me.txt記事)
        Me.grp予定登録.Controls.Add(Me.Label8)
        Me.grp予定登録.Controls.Add(Me.Label7)
        Me.grp予定登録.Controls.Add(Me.btn追加)
        Me.grp予定登録.Controls.Add(Me.Label1)
        Me.grp予定登録.Controls.Add(Me.txt開始日)
        Me.grp予定登録.Controls.Add(Me.dtp開始時間)
        Me.grp予定登録.Controls.Add(Me.dtp終了時間)
        Me.grp予定登録.Controls.Add(Me.Label4)
        Me.grp予定登録.Controls.Add(Me.Label2)
        Me.grp予定登録.Controls.Add(Me.Label5)
        Me.grp予定登録.Controls.Add(Me.txt予定ID)
        Me.grp予定登録.Controls.Add(Me.txt予定)
        Me.grp予定登録.Controls.Add(Me.Label3)
        Me.grp予定登録.ForeColor = System.Drawing.Color.Black
        Me.grp予定登録.Location = New System.Drawing.Point(26, 42)
        Me.grp予定登録.Name = "grp予定登録"
        Me.grp予定登録.Size = New System.Drawing.Size(1144, 234)
        Me.grp予定登録.TabIndex = 5
        Me.grp予定登録.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1006, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(44, 41)
        Me.btnClear.TabIndex = 5
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtColor.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.White
        Me.txtColor.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtColor.Location = New System.Drawing.Point(87, 187)
        Me.txtColor.Multiline = True
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(51, 41)
        Me.txtColor.TabIndex = 18
        Me.txtColor.TabStop = False
        Me.txtColor.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "規定色"
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Silver
        Me.btnColor.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnColor.Location = New System.Drawing.Point(145, 194)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(86, 33)
        Me.btnColor.TabIndex = 19
        Me.btnColor.TabStop = False
        Me.btnColor.Text = "色を選ぶ"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'grp更新時Enable
        '
        Me.grp更新時Enable.Controls.Add(Me.TextBox1)
        Me.grp更新時Enable.Controls.Add(Me.Label6)
        Me.grp更新時Enable.Controls.Add(Me.btn終了日)
        Me.grp更新時Enable.Controls.Add(Me.Label9)
        Me.grp更新時Enable.Controls.Add(Me.txt終了日)
        Me.grp更新時Enable.Controls.Add(Me.cmb繰返し)
        Me.grp更新時Enable.Location = New System.Drawing.Point(464, 48)
        Me.grp更新時Enable.Name = "grp更新時Enable"
        Me.grp更新時Enable.Size = New System.Drawing.Size(457, 28)
        Me.grp更新時Enable.TabIndex = 12
        Me.grp更新時Enable.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(-28, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(25, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        '
        'sfrmS予定登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.lblMode表示)
        Me.Controls.Add(Me.btn次)
        Me.Controls.Add(Me.btn前)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chk休日)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.grp予定登録)
        Me.Controls.Add(Me.dgv一覧)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "sfrmS予定登録"
        Me.ShowInTaskbar = False
        Me.Text = "S予定登録"
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp予定登録.ResumeLayout(False)
        Me.grp予定登録.PerformLayout()
        Me.grp更新時Enable.ResumeLayout(False)
        Me.grp更新時Enable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lbl日付 As Label
    Friend WithEvents chk休日 As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btn前 As Button
    Friend WithEvents btn次 As Button
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents lblMode表示 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp開始時間 As DateTimePicker
    Friend WithEvents dtp終了時間 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt予定 As TextBox
    Friend WithEvents txt予定ID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt開始日 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn追加 As Button
    Friend WithEvents txt終了日 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt記事 As TextBox
    Friend WithEvents cmb繰返し As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn終了日 As Button
    Friend WithEvents cmb会員 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt枝番号 As TextBox
    Friend WithEvents grp予定登録 As GroupBox
    Friend WithEvents grp更新時Enable As GroupBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col予定ID As DataGridViewTextBoxColumn
    Friend WithEvents 複数削除 As DataGridViewTextBoxColumn
    Friend WithEvents 削除 As DataGridViewButtonColumn
    Friend WithEvents col会員ID As DataGridViewTextBoxColumn
    Friend WithEvents 氏名 As DataGridViewTextBoxColumn
    Friend WithEvents col開始日 As DataGridViewTextBoxColumn
    Friend WithEvents col終了日 As DataGridViewTextBoxColumn
    Friend WithEvents col開始時間 As DataGridViewTextBoxColumn
    Friend WithEvents col終了時間 As DataGridViewTextBoxColumn
    Friend WithEvents col予定 As DataGridViewTextBoxColumn
    Friend WithEvents col記事 As DataGridViewTextBoxColumn
    Friend WithEvents colcolor As DataGridViewTextBoxColumn
    Friend WithEvents btnColor As Button
    Friend WithEvents txtColor As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClear As Button
End Class
