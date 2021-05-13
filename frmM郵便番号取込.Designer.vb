<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM郵便番号取込
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCSVパス = New System.Windows.Forms.TextBox()
        Me.btn選択 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 9)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(599, 38)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "郵便局のサイト【http://www.post.japanpost.jp/zipcode/dl/roman-zip.html】" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "より最新版をダウンロードし、CS" &
    "Vデータの取込をすることができます。"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CSVファイル"
        '
        'txtCSVパス
        '
        Me.txtCSVパス.Location = New System.Drawing.Point(211, 69)
        Me.txtCSVパス.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCSVパス.Name = "txtCSVパス"
        Me.txtCSVパス.Size = New System.Drawing.Size(487, 26)
        Me.txtCSVパス.TabIndex = 2
        '
        'btn選択
        '
        Me.btn選択.Location = New System.Drawing.Point(708, 67)
        Me.btn選択.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn選択.Name = "btn選択"
        Me.btn選択.Size = New System.Drawing.Size(108, 29)
        Me.btn選択.TabIndex = 3
        Me.btn選択.Text = "選択"
        Me.btn選択.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(28, 116)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(788, 36)
        Me.ProgressBar1.TabIndex = 4
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(556, 173)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 44)
        Me.btn登録.TabIndex = 5
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.ForeColor = System.Drawing.Color.Red
        Me.btn終了.Location = New System.Drawing.Point(691, 173)
        Me.btn終了.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(125, 44)
        Me.btn終了.TabIndex = 6
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'frmM郵便番号取込
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 251)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn選択)
        Me.Controls.Add(Me.txtCSVパス)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.Name = "frmM郵便番号取込"
        Me.Text = "frmM郵便番号取込"
        Me.Controls.SetChildIndex(Me.LinkLabel1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCSVパス, 0)
        Me.Controls.SetChildIndex(Me.btn選択, 0)
        Me.Controls.SetChildIndex(Me.ProgressBar1, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.btn終了, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCSVパス As TextBox
    Friend WithEvents btn選択 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btn登録 As Button
    Friend WithEvents btn終了 As Button
End Class
