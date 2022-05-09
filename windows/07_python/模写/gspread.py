from os import abort
from matplotlib.pyplot import title
import gspread 
import json

from oauth2client.service_account import ServiceAccountCreadentials

scope = ['https://spreadsheets.google.com/feeds','https://www.googleapis.com/auth/drive']

credentials = ServiceAccountCredentials.form_json_Keyfile_name('秘密鍵のJSON',sc

gc = gspread.authorize(credentials)

workbook = gc.open('ファイル名')

workbook = gc.open_by_key('')

worksheet_kist = workbook.worksheets()

worksheet_list[0].title

from flask import Flask,request,abort
from linebot import(
    LineBotApi,WebhookHandler
)
from linebot.exception import(
    InvalidSignatureError
)
from line.models import(
    MessageEvent,textMessage,TextSendMessage,
)
import os 

app = Flask(__name__)

YOUR_CHANNEL_ACCESS_TOKEN = os.eniron["YOUR_CHANNEL_ACCESS_TOKEN"]
YOUR_CHANNEL_SECRET = os.environ["YOUR_CHANNEL_SECRET"]

line_bot_api = LineBotApi(YOUR_CHANNEL_ACCESS_TOKEN)
handler = webhookHandler(YOUR_CHANNEL_SECRET)

@app.route("/callback",methods=['POST'])
def callback():
    signature = request.headers['X-Line-Signature']

    body = request.get_data(as_text = True)
    app.loger.info("Request body:" + body)