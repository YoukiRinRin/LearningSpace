import requests
from bs4 import BeautifulSoup
from io import BytesIO


res = requests.get('https://search.rakuten.co.jp/search/mall/?sid=261122')

soup = BeautifulSoup(res.text,'html.parser')

figure = soup.figure

res_img = requests.get(figure.find('img')['src'])
#if res.status_code is 200:
#        i = BytesIO.Image.open(BytesIO(res_img.content))
#        i.save("a.jpg")

print(figure.find('img')['src'])
#print(soup.figure.contents)
#img_hint = soup.find_all('img')

