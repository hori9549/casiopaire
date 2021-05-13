Imports System.Data
Imports System.Data.SqlClient
Imports ClosedXML.Excel
Module mdlCommon
    Public my環境設定 As cls環境設定
    Public MS会員ID As String
    Public MS氏名 As String

    Public Function s日付変換(ByVal set日付 As String) As String
        Dim ret変換後 As String = ""

        ''空白であれば処理は終わり
        If set日付 = "" Then Return ""

        ''日付であればOK
        If IsDate(set日付) = True Then Return CDate(set日付).ToString("yyyy/MM/dd")

        Try
            Select Case set日付.Length
                Case Is <= 2
                    ret変換後 = Now.Year & "/" & Now.Month & "/" & CInt(set日付).ToString("00")

                Case Is <= 4
                    set日付 = CInt(set日付).ToString("0000")
                    ret変換後 = Now.Year & "/" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2)

                Case 6
                    If set日付.Substring(0, 2) > 50 Then
                        ret変換後 = "19" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2) & "/" & set日付.Substring(4, 2)
                    Else
                        ret変換後 = "20" & set日付.Substring(0, 2) & "/" & set日付.Substring(2, 2) & "/" & set日付.Substring(4, 2)
                    End If

                Case 8
                    ret変換後 = set日付.Substring(0, 4) & "/" & set日付.Substring(4, 2) & "/" & set日付.Substring(6, 2)

            End Select
        Catch ex As Exception
            ret変換後 = ""
        End Try

        If IsDate(ret変換後) = True Then
            Return CDate(ret変換後).ToString("yyyy/MM/dd")
        Else
            sfrmメッセージ.ShowDialog("日付に変換できません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ""
        End If
    End Function

End Module
