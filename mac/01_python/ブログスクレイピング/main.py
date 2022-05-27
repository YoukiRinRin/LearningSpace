import requests
from bs4 import BeautifulSoup

url = "https://ameblo.jp/deriba-do"

r = requests.get(url)

soup = BeautifulSoup(r.content,"html.parser")

print(soup.select("article"))

print(r)