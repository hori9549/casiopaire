echo off
rem Windows版 cmd コマンドライン

rem LINE Messaging API プッシュメッセージを送る
set LINE_PUSH_URL=https://api.line.me/v2/bot/message/push

rem Channel access token (long-lived)
rem Authorization: Bearer
set LINE_CHANNEL_ACCESS_TOKEN=%1

rem Your user ID
set LINE_USER_ID=%2

rem 送信するメッセージ
set MESSAGE_TEXT=%3

rem echo %LINE_USER_ID%
rem echo %MESSAGE_TEXT%
rem pause

set POST_DATA={ ^
  \"to\": \"%LINE_USER_ID%\", ^
  \"messages\":[ ^
    { ^
      \"type\":\"text\", ^
      \"text\":\"%MESSAGE_TEXT%\" ^
    } ^
  ] ^
}

rem cURLコマンドで PUSHメッセージを送信
curl ^
  "%LINE_PUSH_URL%" ^
  -f -v -X POST ^
  -H "Content-Type: application/json;charset=utf-8" ^
  -H "Authorization: Bearer %LINE_CHANNEL_ACCESS_TOKEN%" ^
  -d "%POST_DATA%"

rem エラーコード確認
echo %errorlevel%

rem pause

rem 終了コードを返す
EXIT /B %errorlevel%