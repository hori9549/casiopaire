<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm個別カレンダー
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv個別表示 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col枝番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col会員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col記事 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定追加 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col０ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col２ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col３ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col４ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col５ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col６ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col７ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col８ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col９ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１０ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１１ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１２ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１３ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１４ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１５ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１６ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１７ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１８ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col１９ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col２０ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col２１ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col２２ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col２３ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colそれ以後 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.btn進む = New System.Windows.Forms.Button()
        Me.btn戻る = New System.Windows.Forms.Button()
        CType(Me.dgv個別表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv個別表示
        '
        Me.dgv個別表示.AllowUserToAddRows = False
        Me.dgv個別表示.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv個別表示.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv個別表示.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv個別表示.ColumnHeadersHeight = 30
        Me.dgv個別表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col予定ID, Me.col枝番号, Me.col会員ID, Me.col氏名, Me.col開始日, Me.col終了日, Me.col開始時間, Me.col終了時間, Me.col予定, Me.col記事, Me.colcolor, Me.col予定追加, Me.col０, Me.col１, Me.col２, Me.col３, Me.col４, Me.col５, Me.col６, Me.col７, Me.col８, Me.col９, Me.col１０, Me.col１１, Me.col１２, Me.col１３, Me.col１４, Me.col１５, Me.col１６, Me.col１７, Me.col１８, Me.col１９, Me.col２０, Me.col２１, Me.col２２, Me.col２３, Me.colそれ以後})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv個別表示.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv個別表示.Location = New System.Drawing.Point(30, 99)
        Me.dgv個別表示.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgv個別表示.Name = "dgv個別表示"
        Me.dgv個別表示.RowHeadersVisible = False
        Me.dgv個別表示.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv個別表示.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv個別表示.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv個別表示.RowTemplate.DividerHeight = 1
        Me.dgv個別表示.RowTemplate.Height = 50
        Me.dgv個別表示.Size = New System.Drawing.Size(1384, 750)
        Me.dgv個別表示.TabIndex = 0
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        Me.colID.Width = 20
        '
        'col予定ID
        '
        Me.col予定ID.DataPropertyName = "予定ID"
        Me.col予定ID.HeaderText = "予定ID"
        Me.col予定ID.MinimumWidth = 6
        Me.col予定ID.Name = "col予定ID"
        Me.col予定ID.Visible = False
        Me.col予定ID.Width = 125
        '
        'col枝番号
        '
        Me.col枝番号.DataPropertyName = "枝番号"
        Me.col枝番号.HeaderText = "枝番号"
        Me.col枝番号.MinimumWidth = 6
        Me.col枝番号.Name = "col枝番号"
        Me.col枝番号.Visible = False
        Me.col枝番号.Width = 125
        '
        'col会員ID
        '
        Me.col会員ID.DataPropertyName = "会員ID"
        Me.col会員ID.HeaderText = "会員ID"
        Me.col会員ID.MinimumWidth = 6
        Me.col会員ID.Name = "col会員ID"
        Me.col会員ID.Visible = False
        Me.col会員ID.Width = 50
        '
        'col氏名
        '
        Me.col氏名.DataPropertyName = "氏名"
        Me.col氏名.HeaderText = "氏名"
        Me.col氏名.MinimumWidth = 6
        Me.col氏名.Name = "col氏名"
        Me.col氏名.Width = 90
        '
        'col開始日
        '
        Me.col開始日.DataPropertyName = "開始日"
        Me.col開始日.HeaderText = "開始日"
        Me.col開始日.MinimumWidth = 6
        Me.col開始日.Name = "col開始日"
        Me.col開始日.Visible = False
        Me.col開始日.Width = 125
        '
        'col終了日
        '
        Me.col終了日.DataPropertyName = "終了日"
        Me.col終了日.HeaderText = "終了日"
        Me.col終了日.MinimumWidth = 6
        Me.col終了日.Name = "col終了日"
        Me.col終了日.Visible = False
        Me.col終了日.Width = 125
        '
        'col開始時間
        '
        Me.col開始時間.DataPropertyName = "開始時間"
        Me.col開始時間.HeaderText = "開始時間"
        Me.col開始時間.MinimumWidth = 6
        Me.col開始時間.Name = "col開始時間"
        Me.col開始時間.Visible = False
        Me.col開始時間.Width = 125
        '
        'col終了時間
        '
        Me.col終了時間.DataPropertyName = "終了時間"
        Me.col終了時間.HeaderText = "終了時間"
        Me.col終了時間.MinimumWidth = 6
        Me.col終了時間.Name = "col終了時間"
        Me.col終了時間.Visible = False
        Me.col終了時間.Width = 125
        '
        'col予定
        '
        Me.col予定.DataPropertyName = "予定"
        Me.col予定.HeaderText = "予定"
        Me.col予定.MinimumWidth = 6
        Me.col予定.Name = "col予定"
        Me.col予定.Visible = False
        Me.col予定.Width = 180
        '
        'col記事
        '
        Me.col記事.DataPropertyName = "記事"
        Me.col記事.HeaderText = "記事"
        Me.col記事.MinimumWidth = 6
        Me.col記事.Name = "col記事"
        Me.col記事.Visible = False
        Me.col記事.Width = 125
        '
        'colcolor
        '
        Me.colcolor.DataPropertyName = "color"
        Me.colcolor.HeaderText = "color"
        Me.colcolor.MinimumWidth = 6
        Me.colcolor.Name = "colcolor"
        Me.colcolor.Visible = False
        Me.colcolor.Width = 125
        '
        'col予定追加
        '
        Me.col予定追加.DataPropertyName = "予定追加"
        Me.col予定追加.HeaderText = "予定追加"
        Me.col予定追加.MinimumWidth = 6
        Me.col予定追加.Name = "col予定追加"
        Me.col予定追加.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col予定追加.Width = 200
        '
        'col０
        '
        Me.col０.DataPropertyName = "０"
        Me.col０.HeaderText = "０"
        Me.col０.MinimumWidth = 6
        Me.col０.Name = "col０"
        Me.col０.Width = 30
        '
        'col１
        '
        Me.col１.DataPropertyName = "１"
        Me.col１.HeaderText = "１"
        Me.col１.MinimumWidth = 6
        Me.col１.Name = "col１"
        Me.col１.Width = 30
        '
        'col２
        '
        Me.col２.DataPropertyName = "２"
        Me.col２.HeaderText = "２"
        Me.col２.MinimumWidth = 6
        Me.col２.Name = "col２"
        Me.col２.Width = 30
        '
        'col３
        '
        Me.col３.DataPropertyName = "３"
        Me.col３.HeaderText = "３"
        Me.col３.MinimumWidth = 6
        Me.col３.Name = "col３"
        Me.col３.Width = 30
        '
        'col４
        '
        Me.col４.DataPropertyName = "４"
        Me.col４.HeaderText = "４"
        Me.col４.MinimumWidth = 6
        Me.col４.Name = "col４"
        Me.col４.Width = 30
        '
        'col５
        '
        Me.col５.DataPropertyName = "５"
        Me.col５.HeaderText = "５"
        Me.col５.MinimumWidth = 6
        Me.col５.Name = "col５"
        Me.col５.Width = 30
        '
        'col６
        '
        Me.col６.DataPropertyName = "６"
        Me.col６.HeaderText = "６"
        Me.col６.MinimumWidth = 6
        Me.col６.Name = "col６"
        Me.col６.Width = 30
        '
        'col７
        '
        Me.col７.DataPropertyName = "７"
        Me.col７.HeaderText = "７"
        Me.col７.MinimumWidth = 6
        Me.col７.Name = "col７"
        Me.col７.Width = 30
        '
        'col８
        '
        Me.col８.DataPropertyName = "８"
        Me.col８.HeaderText = "８"
        Me.col８.MinimumWidth = 6
        Me.col８.Name = "col８"
        Me.col８.Width = 30
        '
        'col９
        '
        Me.col９.DataPropertyName = "９"
        Me.col９.HeaderText = "９"
        Me.col９.MinimumWidth = 6
        Me.col９.Name = "col９"
        Me.col９.Width = 30
        '
        'col１０
        '
        Me.col１０.DataPropertyName = "１０"
        Me.col１０.HeaderText = "10"
        Me.col１０.MinimumWidth = 6
        Me.col１０.Name = "col１０"
        Me.col１０.Width = 30
        '
        'col１１
        '
        Me.col１１.DataPropertyName = "１１"
        Me.col１１.HeaderText = "11"
        Me.col１１.MinimumWidth = 6
        Me.col１１.Name = "col１１"
        Me.col１１.Width = 30
        '
        'col１２
        '
        Me.col１２.DataPropertyName = "１２"
        Me.col１２.HeaderText = "12"
        Me.col１２.MinimumWidth = 6
        Me.col１２.Name = "col１２"
        Me.col１２.Width = 30
        '
        'col１３
        '
        Me.col１３.DataPropertyName = "１３"
        Me.col１３.HeaderText = "13"
        Me.col１３.MinimumWidth = 6
        Me.col１３.Name = "col１３"
        Me.col１３.Width = 30
        '
        'col１４
        '
        Me.col１４.DataPropertyName = "１４"
        Me.col１４.HeaderText = "14"
        Me.col１４.MinimumWidth = 6
        Me.col１４.Name = "col１４"
        Me.col１４.Width = 30
        '
        'col１５
        '
        Me.col１５.DataPropertyName = "１５"
        Me.col１５.HeaderText = "15"
        Me.col１５.MinimumWidth = 6
        Me.col１５.Name = "col１５"
        Me.col１５.Width = 30
        '
        'col１６
        '
        Me.col１６.DataPropertyName = "１６"
        Me.col１６.HeaderText = "16"
        Me.col１６.MinimumWidth = 6
        Me.col１６.Name = "col１６"
        Me.col１６.Width = 30
        '
        'col１７
        '
        Me.col１７.DataPropertyName = "１７"
        Me.col１７.HeaderText = "17"
        Me.col１７.MinimumWidth = 6
        Me.col１７.Name = "col１７"
        Me.col１７.Width = 30
        '
        'col１８
        '
        Me.col１８.DataPropertyName = "１８"
        Me.col１８.HeaderText = "18"
        Me.col１８.MinimumWidth = 6
        Me.col１８.Name = "col１８"
        Me.col１８.Width = 30
        '
        'col１９
        '
        Me.col１９.DataPropertyName = "１９"
        Me.col１９.HeaderText = "19"
        Me.col１９.MinimumWidth = 6
        Me.col１９.Name = "col１９"
        Me.col１９.Width = 30
        '
        'col２０
        '
        Me.col２０.DataPropertyName = "２０"
        Me.col２０.HeaderText = "20"
        Me.col２０.MinimumWidth = 6
        Me.col２０.Name = "col２０"
        Me.col２０.Width = 30
        '
        'col２１
        '
        Me.col２１.DataPropertyName = "２１"
        Me.col２１.HeaderText = "21"
        Me.col２１.MinimumWidth = 6
        Me.col２１.Name = "col２１"
        Me.col２１.Width = 30
        '
        'col２２
        '
        Me.col２２.DataPropertyName = "２２"
        Me.col２２.HeaderText = "22"
        Me.col２２.MinimumWidth = 6
        Me.col２２.Name = "col２２"
        Me.col２２.Width = 30
        '
        'col２３
        '
        Me.col２３.DataPropertyName = "２３"
        Me.col２３.HeaderText = "23"
        Me.col２３.MinimumWidth = 6
        Me.col２３.Name = "col２３"
        Me.col２３.Width = 30
        '
        'colそれ以後
        '
        Me.colそれ以後.DataPropertyName = "▷"
        Me.colそれ以後.HeaderText = "▷"
        Me.colそれ以後.MinimumWidth = 6
        Me.colそれ以後.Name = "colそれ以後"
        Me.colそれ以後.Width = 40
        '
        'lbl日付
        '
        Me.lbl日付.Enabled = False
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(83, 15)
        Me.lbl日付.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(277, 34)
        Me.lbl日付.TabIndex = 110
        Me.lbl日付.Text = "yyyy/mm/dd（曜）"
        '
        'btn進む
        '
        Me.btn進む.Location = New System.Drawing.Point(368, 9)
        Me.btn進む.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn進む.Name = "btn進む"
        Me.btn進む.Size = New System.Drawing.Size(47, 45)
        Me.btn進む.TabIndex = 112
        Me.btn進む.Text = ">"
        Me.btn進む.UseVisualStyleBackColor = True
        '
        'btn戻る
        '
        Me.btn戻る.Location = New System.Drawing.Point(30, 15)
        Me.btn戻る.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(47, 45)
        Me.btn戻る.TabIndex = 113
        Me.btn戻る.Text = "<"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'frm個別カレンダー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 961)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.btn進む)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.dgv個別表示)
        Me.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Name = "frm個別カレンダー"
        Me.Text = "個別カレンダー"
        Me.Controls.SetChildIndex(Me.dgv個別表示, 0)
        Me.Controls.SetChildIndex(Me.lbl日付, 0)
        Me.Controls.SetChildIndex(Me.btn進む, 0)
        Me.Controls.SetChildIndex(Me.btn戻る, 0)
        CType(Me.dgv個別表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv個別表示 As DataGridView
    Friend WithEvents lbl日付 As Label
    Friend WithEvents btn進む As Button
    Friend WithEvents btn戻る As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col予定ID As DataGridViewTextBoxColumn
    Friend WithEvents col枝番号 As DataGridViewTextBoxColumn
    Friend WithEvents col会員ID As DataGridViewTextBoxColumn
    Friend WithEvents col氏名 As DataGridViewTextBoxColumn
    Friend WithEvents col開始日 As DataGridViewTextBoxColumn
    Friend WithEvents col終了日 As DataGridViewTextBoxColumn
    Friend WithEvents col開始時間 As DataGridViewTextBoxColumn
    Friend WithEvents col終了時間 As DataGridViewTextBoxColumn
    Friend WithEvents col予定 As DataGridViewTextBoxColumn
    Friend WithEvents col記事 As DataGridViewTextBoxColumn
    Friend WithEvents colcolor As DataGridViewTextBoxColumn
    Friend WithEvents col予定追加 As DataGridViewButtonColumn
    Friend WithEvents col０ As DataGridViewTextBoxColumn
    Friend WithEvents col１ As DataGridViewTextBoxColumn
    Friend WithEvents col２ As DataGridViewTextBoxColumn
    Friend WithEvents col３ As DataGridViewTextBoxColumn
    Friend WithEvents col４ As DataGridViewTextBoxColumn
    Friend WithEvents col５ As DataGridViewTextBoxColumn
    Friend WithEvents col６ As DataGridViewTextBoxColumn
    Friend WithEvents col７ As DataGridViewTextBoxColumn
    Friend WithEvents col８ As DataGridViewTextBoxColumn
    Friend WithEvents col９ As DataGridViewTextBoxColumn
    Friend WithEvents col１０ As DataGridViewTextBoxColumn
    Friend WithEvents col１１ As DataGridViewTextBoxColumn
    Friend WithEvents col１２ As DataGridViewTextBoxColumn
    Friend WithEvents col１３ As DataGridViewTextBoxColumn
    Friend WithEvents col１４ As DataGridViewTextBoxColumn
    Friend WithEvents col１５ As DataGridViewTextBoxColumn
    Friend WithEvents col１６ As DataGridViewTextBoxColumn
    Friend WithEvents col１７ As DataGridViewTextBoxColumn
    Friend WithEvents col１８ As DataGridViewTextBoxColumn
    Friend WithEvents col１９ As DataGridViewTextBoxColumn
    Friend WithEvents col２０ As DataGridViewTextBoxColumn
    Friend WithEvents col２１ As DataGridViewTextBoxColumn
    Friend WithEvents col２２ As DataGridViewTextBoxColumn
    Friend WithEvents col２３ As DataGridViewTextBoxColumn
    Friend WithEvents colそれ以後 As DataGridViewTextBoxColumn
End Class
