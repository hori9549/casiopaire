Imports System.Data
Imports System.Data.SqlClient
Imports ClosedXML.Excel
Module mdlCommon
    '  Public my環境設定 As cls環境設定
    Public MS会員ID As String
    Public MS氏名 As String

    'Public Function s日付変換(ByVal set日付 As String) As String
    '    Dim ret変換後 As String = ""

    '    ''空白であれば処理は終わり
    '    If set日付 = "" Then Return ""

    '    ''日付であればOK
    '    If IsDate(set日付) = True Then Return CDate(set日付).ToString("yyyy/MM/dd")

    '    Try
    '        Select Case set日付.Length
    '            Case Is <= 2
    '                ret変換後 = Now.Year & "/" & Now.Month & "/" & CInt(set日付).ToString("00")

    '            Case Is <= 4
    '                set日付 = CInt(set日付).ToString("0000")
    '                ret変換後 = Now.Year & "/" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2)

    '            Case 6
    '                If set日付.Substring(0, 2) > 50 Then
    '                    ret変換後 = "19" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2) & "/" & set日付.Substring(4, 2)
    '                Else
    '                    ret変換後 = "20" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2) & "/" & set日付.Substring(4, 2)
    '                End If

    '            Case 8
    '                ret変換後 = set日付.Substring(0, 4) & "/" & set日付.Substring(4, 2) & "/" & set日付.Substring(6, 2)

    '        End Select
    '    Catch ex As Exception
    '        ret変換後 = ""
    '    End Try

    '    If IsDate(ret変換後) = True Then
    '        Return CDate(ret変換後).ToString("yyyy/MM/dd")
    '    Else
    '        sfrmメッセージ.ShowDialog("日付に変換できません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Return ""
    '    End If
    'End Function
    Public Function rtnParameter(ByVal hexNum As String) As String()
        Dim P(2) As String
        Dim strTempColor As String
        Dim HexKasira As String = "&H"
        strTempColor = hexNum
        Select Case hexNum.Length         'HexのLengthによる処理
            Case 1 To 2
                P(0) = "&H0"
                P(1) = "&H0"
                P(2) = HexKasira & Mid(strTempColor, 1)
            Case 3
                P(0) = "&H0"
                P(1) = HexKasira & Mid(strTempColor, 1, 1)
                P(2) = HexKasira & Mid(strTempColor, 2, 2)
            Case 4
                P(0) = "&H0"
                P(1) = HexKasira & Mid(strTempColor, 1, 2)
                P(2) = HexKasira & Mid(strTempColor, 3, 2)
            Case 5
                P(0) = HexKasira & Mid(strTempColor, 1, 1)
                P(1) = HexKasira & Mid(strTempColor, 2, 2)
                P(2) = HexKasira & Mid(strTempColor, 4, 2)
            Case 6
                P(0) = HexKasira & Mid(strTempColor, 1, 2)
                P(1) = HexKasira & Mid(strTempColor, 3, 2)
                P(2) = HexKasira & Mid(strTempColor, 5, 2)
            Case Else
                P(0) = "&Hff"
                P(1) = "&Hff"
                P(2) = "&Hff"
        End Select

        Return P
    End Function
End Module
