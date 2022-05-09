import pygame
from pygame.locals import *
import sys


def main():

    

    
    pygame.init()                                   # Pygameの初期化
    screen = pygame.display.set_mode((800, 600))    # 大きさ400*300の画面を生成
    pygame.display.set_caption("時計")              # タイトルバーに表示する文字


    pos = (400,300)
    radius =(250)

    while (1):
        screen.fill((0,0,0))        # 画面を黒色(#000000)に塗りつぶし
        pygame.draw.circle(screen,(255,255,255), pos, radius, width=0)
        pygame.display.update()     # 画面を更新
        # イベント処理


        for event in pygame.event.get():
            if event.type == QUIT:  # 閉じるボタンが押されたら終了
                pygame.quit()       # Pygameの終了(画面閉じられる)
                sys.exit()





if __name__ == "__main__":
    main()