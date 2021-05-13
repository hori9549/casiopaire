<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfrmLineメッセージ
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
        Me.btn送信 = New System.Windows.Forms.Button()
        Me.txt送信メッセージ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl送信先会員ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl送信先会員名 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn送信
        '
        Me.btn送信.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn送信.Location = New System.Drawing.Point(56, 375)
        Me.btn送信.Margin = New System.Windows.Forms.Padding(5)
        Me.btn送信.Name = "btn送信"
        Me.btn送信.Size = New System.Drawing.Size(169, 51)
        Me.btn送信.TabIndex = 3
        Me.btn送信.Text = "メッセージ送信"
        Me.btn送信.UseVisualStyleBackColor = True
        '
        'txt送信メッセージ
        '
        Me.txt送信メッセージ.AcceptsReturn = True
        Me.txt送信メッセージ.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt送信メッセージ.Location = New System.Drawing.Point(16, 100)
        Me.txt送信メッセージ.Margin = New System.Windows.Forms.Padding(5)
        Me.txt送信メッセージ.Multiline = True
        Me.txt送信メッセージ.Name = "txt送信メッセージ"
        Me.txt送信メッセージ.Size = New System.Drawing.Size(421, 265)
        Me.txt送信メッセージ.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "送信メッセージ"
        '
        'lbl送信先会員ID
        '
        Me.lbl送信先会員ID.AutoSize = True
        Me.lbl送信先会員ID.Location = New System.Drawing.Point(142, 9)
        Me.lbl送信先会員ID.Name = "lbl送信先会員ID"
        Me.lbl送信先会員ID.Size = New System.Drawing.Size(121, 19)
        Me.lbl送信先会員ID.TabIndex = 10
        Me.lbl送信先会員ID.Text = "送信先会員ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "送信先会員ID："
        '
        'lbl送信先会員名
        '
        Me.lbl送信先会員名.AutoSize = True
        Me.lbl送信先会員名.Location = New System.Drawing.Point(142, 32)
        Me.lbl送信先会員名.Name = "lbl送信先会員名"
        Me.lbl送信先会員名.Size = New System.Drawing.Size(123, 19)
        Me.lbl送信先会員名.TabIndex = 12
        Me.lbl送信先会員名.Text = "送信先会員名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "送信先会員名："
        '
        'btn閉じる
        '
        Me.btn閉じる.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn閉じる.Location = New System.Drawing.Point(235, 375)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(169, 51)
        Me.btn閉じる.TabIndex = 13
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'sfrmLineメッセージ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 437)
        Me.Controls.Add(Me.btn閉じる)
        Me.Controls.Add(Me.lbl送信先会員名)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl送信先会員ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt送信メッセージ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn送信)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "sfrmLineメッセージ"
        Me.Text = "LINEメッセージ送信"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn送信 As Button
    Friend WithEvents txt送信メッセージ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl送信先会員ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl送信先会員名 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn閉じる As Button
End Class
