'200710 Frm111にColorCodeを送る
'200818 color変更
'20210417 カシオペイアに採用
Public Class sfrmScolorサンプル
    ' Private rgb() As String
    '  Private makeParam As New clsHtools   'インスタンスの作成

    '   Public Property fromF1 As String
    Public Property RtnColor As String
    Private getColor As String = RtnColor
    Private aryBtnList(16) As Button

    '  Dim f1 As Frm111レジメニュー設定
    '  Dim tempcolor As String
    ' コンストラクタ
    'Sub New(ByVal f As Form)
    '    f1 = f ' メイン・フォームへの参照を保存
    '    InitializeComponent()
    'End Sub
    'Public Property inHex As String
    ''  Public Property P1 As Byte
    'Public ReadOnly Property paramRGB() As String
    '    Get
    '        Return rgb(3)
    '    End Get
    'End Property

    'Public Property G As Byte
    'Public Property B As Byte
    ''------------------------------------------------
    ''    makeParamRGB　　の本体
    ''------------------------------------------------
    ' Dim rgb() As String
    ' Public Property  rgb() As String
    ' Private Function paramRGB(ByVal InHex As String, ByRef R As Byte, ByRef G As Byte, ByRef B As Byte)

    'Public Shared Function divRGB(ByVal InHex As String) As String
    '    Dim rgb(3) As String
    '    Dim HexKasira As String = "&H"
    '    Select Case InHex.Length         'HexのLengthによる処理
    '        Case 1 To 2
    '            rgb(2) = HexKasira & Mid(InHex, 1)
    '            rgb(1) = "&H0"
    '            rgb(0) = "&H0"
    '        Case 3
    '            rgb(0) = "&H0"
    '            rgb(1) = HexKasira & Mid(InHex, 1, 1)
    '            rgb(2) = HexKasira & Mid(InHex, 2, 2)
    '        Case 4
    '            rgb(0) = "&H0"
    '            rgb(1) = HexKasira & Mid(InHex, 1, 2)
    '            rgb(2) = HexKasira & Mid(InHex, 3, 2)
    '        Case 5
    '            rgb(0) = HexKasira & Mid(InHex, 1, 1)
    '            rgb(1) = HexKasira & Mid(InHex, 2, 2)
    '            rgb(2) = HexKasira & Mid(InHex, 4, 2)
    '        Case 6
    '            rgb(0) = HexKasira & Mid(InHex, 1, 2)
    '            rgb(1) = HexKasira & Mid(InHex, 3, 2)
    '            rgb(2) = HexKasira & Mid(InHex, 5, 2)
    '        Case Else
    '            rgb(0) = "&Hff"
    '            rgb(1) = "&Hff"
    '            rgb(2) = "&Hff"
    '    End Select
    '    Return rgb(3)

    'End Function

    'Private Sub makeParam(ByVal InHex As String, ByRef R As Byte, ByRef G As Byte, ByRef B As Byte)
    '    Dim HexKasira As String = "&H"
    '    Select Case InHex.Length         'HexのLengthによる処理
    '        Case 1 To 2
    '            B = HexKasira & Mid(InHex, 1)
    '            G = "&H0"
    '            R = "&H0"
    '        Case 3
    '            R = "&H0"
    '            G = HexKasira & Mid(InHex, 1, 1)
    '            B = HexKasira & Mid(InHex, 2, 2)
    '        Case 4
    '            R = "&H0"
    '            G = HexKasira & Mid(InHex, 1, 2)
    '            B = HexKasira & Mid(InHex, 3, 2)
    '        Case 5
    '            R = HexKasira & Mid(InHex, 1, 1)
    '            G = HexKasira & Mid(InHex, 2, 2)
    '            B = HexKasira & Mid(InHex, 4, 2)
    '        Case 6
    '            R = HexKasira & Mid(InHex, 1, 2)
    '            G = HexKasira & Mid(InHex, 3, 2)
    '            B = HexKasira & Mid(InHex, 5, 2)
    '        Case Else
    '            R = "&Hff"
    '            G = "&Hff"
    '            B = "&Hff"
    '    End Select

    'End Sub
    Private Sub Frm111レジメニュ設定_Colorサンプル_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Me.ControlBox = Not Me.ControlBox

        '    Btn規定値.Enabled = False

        aryBtnList(0) = Btn1
        aryBtnList(1) = Btn2
        aryBtnList(2) = Btn3
        aryBtnList(3) = Btn4
        aryBtnList(4) = Btn5
        aryBtnList(5) = Btn6
        aryBtnList(6) = Btn7
        aryBtnList(7) = Btn8
        aryBtnList(8) = Btn9
        aryBtnList(9) = Btn10
        aryBtnList(10) = Btn11
        aryBtnList(11) = Btn12
        aryBtnList(12) = Btn13
        aryBtnList(13) = Btn14
        aryBtnList(14) = Btn15
        aryBtnList(15) = Btn16

        'インスタンスの作成
        '   Dim makeParam As New DivRGB
        'プロパティに値を設定
        'Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
        'Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
        'Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる
        '  Dim rgb(3) As String
        Dim BtnColr As String
        Dim P(3) As String
        getColor = RtnColor
        For i = 0 To 15
            BtnColr = aryBtnList(i).Text
            '  Call makeParam(hexColor, R, G, B)
            P = mdlCommon.rtnParameter(BtnColr)

            ' Call makeParam(BtnColr, R, G, B)          'プロパティに値を設定

            'makeParam.DivRGB()   'メソッドの呼び出し

            'R = makeParam.P1          'プロパティをGet
            'G = makeParam.P2
            'B = makeParam.P3
            'Call makeParamRGB(BtnColr, R, G, B)
            aryBtnList(i).BackColor = Color.FromArgb(P(0), P(1), P(2))
            aryBtnList(i).ForeColor = Color.FromArgb(P(0), P(1), P(2))
        Next
        '    RtnColor = fromF1
    End Sub
    Private Sub Btnキャンセル_Click(sender As Object, e As EventArgs) Handles Btnキャンセル.Click
        ' RtnColor = fromF1
        Call Rtn処理()
    End Sub

    'Private Sub Btn規定値_Click(sender As Object, e As EventArgs)
    '    ' TxbRtn.Text = tempcolor.ToString
    '    ' RtnColor = tempcolor
    '    Call Rtn処理()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn8.Click,
        Btn6.Click, Btn7.Click, Btn9.Click, Btn10.Click, Btn11.Click, Btn12.Click, Btn13.Click, Btn14.Click, Btn15.Click, Btn16.Click

        '  Btn規定値.Enabled = True
        getColor = sender.Text
        Call Rtn処理()
    End Sub
    Sub Rtn処理()
        '  MsgBox("modoります") '  Dim f1_label1 As Label = CType(f1.Controls("Label1"), Label)
        '  f1_label1.Text = Me.TxbRtn.Text
        RtnColor = getColor
        Me.Close()
    End Sub
End Class