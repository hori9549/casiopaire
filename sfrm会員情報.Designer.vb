<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrm会員情報
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cmb会員 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvプロジェクト = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colプロジェクトID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colプロジェクト名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col内容 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当理事 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開催日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考_プロジェクト = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col会員ID_プロジェクト = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvスキル = New System.Windows.Forms.DataGridView()
        Me.colID_スキル = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col会員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colスキル名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colスキルレベル = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除フラグ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvプロジェクト, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvスキル, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(721, 501)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 42)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.Location = New System.Drawing.Point(5, 4)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(111, 34)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(126, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(112, 34)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        Me.Cancel_Button.Visible = False
        '
        'cmb会員
        '
        Me.cmb会員.FormattingEnabled = True
        Me.cmb会員.Location = New System.Drawing.Point(65, 12)
        Me.cmb会員.Name = "cmb会員"
        Me.cmb会員.Size = New System.Drawing.Size(201, 27)
        Me.cmb会員.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "氏名"
        '
        'dgvプロジェクト
        '
        Me.dgvプロジェクト.AllowUserToAddRows = False
        Me.dgvプロジェクト.AllowUserToDeleteRows = False
        Me.dgvプロジェクト.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvプロジェクト.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colプロジェクトID, Me.colプロジェクト名, Me.col内容, Me.col担当理事, Me.col開催日, Me.col開始日, Me.col終了日, Me.col備考_プロジェクト, Me.col会員ID_プロジェクト})
        Me.dgvプロジェクト.Location = New System.Drawing.Point(16, 45)
        Me.dgvプロジェクト.Name = "dgvプロジェクト"
        Me.dgvプロジェクト.RowHeadersVisible = False
        Me.dgvプロジェクト.RowTemplate.Height = 21
        Me.dgvプロジェクト.Size = New System.Drawing.Size(943, 222)
        Me.dgvプロジェクト.TabIndex = 3
        Me.dgvプロジェクト.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'colプロジェクトID
        '
        Me.colプロジェクトID.DataPropertyName = "プロジェクトID"
        Me.colプロジェクトID.HeaderText = "プロジェクトID"
        Me.colプロジェクトID.Name = "colプロジェクトID"
        Me.colプロジェクトID.Visible = False
        '
        'colプロジェクト名
        '
        Me.colプロジェクト名.DataPropertyName = "プロジェクト名"
        Me.colプロジェクト名.HeaderText = "プロジェクト名"
        Me.colプロジェクト名.Name = "colプロジェクト名"
        Me.colプロジェクト名.Width = 200
        '
        'col内容
        '
        Me.col内容.DataPropertyName = "内容"
        Me.col内容.HeaderText = "プロジェクト内容"
        Me.col内容.Name = "col内容"
        Me.col内容.Width = 400
        '
        'col担当理事
        '
        Me.col担当理事.DataPropertyName = "担当理事"
        Me.col担当理事.HeaderText = "担当理事"
        Me.col担当理事.Name = "col担当理事"
        Me.col担当理事.Visible = False
        Me.col担当理事.Width = 200
        '
        'col開催日
        '
        Me.col開催日.DataPropertyName = "開催日"
        Me.col開催日.HeaderText = "開催日"
        Me.col開催日.Name = "col開催日"
        Me.col開催日.Visible = False
        '
        'col開始日
        '
        Me.col開始日.DataPropertyName = "開始日"
        Me.col開始日.HeaderText = "開始日"
        Me.col開始日.Name = "col開始日"
        Me.col開始日.Visible = False
        '
        'col終了日
        '
        Me.col終了日.DataPropertyName = "終了日"
        Me.col終了日.HeaderText = "終了日"
        Me.col終了日.Name = "col終了日"
        Me.col終了日.Visible = False
        '
        'col備考_プロジェクト
        '
        Me.col備考_プロジェクト.DataPropertyName = "備考"
        Me.col備考_プロジェクト.HeaderText = "備考"
        Me.col備考_プロジェクト.Name = "col備考_プロジェクト"
        Me.col備考_プロジェクト.Visible = False
        '
        'col会員ID_プロジェクト
        '
        Me.col会員ID_プロジェクト.DataPropertyName = "会員ID"
        Me.col会員ID_プロジェクト.HeaderText = "会員ID"
        Me.col会員ID_プロジェクト.Name = "col会員ID_プロジェクト"
        Me.col会員ID_プロジェクト.Visible = False
        '
        'dgvスキル
        '
        Me.dgvスキル.AllowUserToAddRows = False
        Me.dgvスキル.AllowUserToDeleteRows = False
        Me.dgvスキル.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvスキル.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID_スキル, Me.col会員ID, Me.colスキル名, Me.colスキルレベル, Me.col備考, Me.col削除フラグ})
        Me.dgvスキル.Location = New System.Drawing.Point(14, 272)
        Me.dgvスキル.Name = "dgvスキル"
        Me.dgvスキル.RowHeadersVisible = False
        Me.dgvスキル.RowTemplate.Height = 21
        Me.dgvスキル.Size = New System.Drawing.Size(950, 222)
        Me.dgvスキル.TabIndex = 4
        '
        'colID_スキル
        '
        Me.colID_スキル.DataPropertyName = "ID"
        Me.colID_スキル.HeaderText = "ID"
        Me.colID_スキル.Name = "colID_スキル"
        Me.colID_スキル.Visible = False
        '
        'col会員ID
        '
        Me.col会員ID.DataPropertyName = "会員ID"
        Me.col会員ID.HeaderText = "会員ID"
        Me.col会員ID.Name = "col会員ID"
        Me.col会員ID.Visible = False
        '
        'colスキル名
        '
        Me.colスキル名.DataPropertyName = "スキル名"
        Me.colスキル名.HeaderText = "スキル名"
        Me.colスキル名.Name = "colスキル名"
        Me.colスキル名.Width = 200
        '
        'colスキルレベル
        '
        Me.colスキルレベル.DataPropertyName = "スキルレベル"
        Me.colスキルレベル.HeaderText = "スキルレベル"
        Me.colスキルレベル.Name = "colスキルレベル"
        Me.colスキルレベル.Width = 200
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.Width = 400
        '
        'col削除フラグ
        '
        Me.col削除フラグ.DataPropertyName = "削除フラグ"
        Me.col削除フラグ.HeaderText = "削除"
        Me.col削除フラグ.Name = "col削除フラグ"
        Me.col削除フラグ.Visible = False
        '
        'sfrm会員情報
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.dgvスキル)
        Me.Controls.Add(Me.dgvプロジェクト)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb会員)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrm会員情報"
        Me.ShowInTaskbar = False
        Me.Text = "会員情報"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvプロジェクト, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvスキル, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cmb会員 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvプロジェクト As DataGridView
    Friend WithEvents dgvスキル As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colプロジェクトID As DataGridViewTextBoxColumn
    Friend WithEvents colプロジェクト名 As DataGridViewTextBoxColumn
    Friend WithEvents col内容 As DataGridViewTextBoxColumn
    Friend WithEvents col担当理事 As DataGridViewTextBoxColumn
    Friend WithEvents col開催日 As DataGridViewTextBoxColumn
    Friend WithEvents col開始日 As DataGridViewTextBoxColumn
    Friend WithEvents col終了日 As DataGridViewTextBoxColumn
    Friend WithEvents col備考_プロジェクト As DataGridViewTextBoxColumn
    Friend WithEvents col会員ID_プロジェクト As DataGridViewTextBoxColumn
    Friend WithEvents colID_スキル As DataGridViewTextBoxColumn
    Friend WithEvents col会員ID As DataGridViewTextBoxColumn
    Friend WithEvents colスキル名 As DataGridViewTextBoxColumn
    Friend WithEvents colスキルレベル As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
    Friend WithEvents col削除フラグ As DataGridViewTextBoxColumn
End Class
