import pygame
from pygame.locals import *
import sys

def main():
    (w,h) = (1000,1000)   # 画面サイズ
    (x,y) = (w/2, h/2)
    pygame.init()       # pygame初期化
    pygame.display.set_mode((w, h), 0, 32)  # 画面設定
    screen = pygame.display.get_surface()
    angle= 0
    unco_flag = 0
    
    # 背景画像の取得
    #bg = pygame.image.load(".jpg").convert_alpha()    
    #rect_bg = bg.get_rect()

    # プレイヤー画像の取得
    player = pygame.image.load("unchi_character.png").convert_alpha()    
    rect_player = player.get_rect()
    rect_player.center = (500, 500) # プレイヤー画像の初期位置

    while (1):
        pygame.display.update()             # 画面更新
        pygame.time.wait(300)                # 更新時間間隔
        screen.fill((0, 20, 0, 0))          # 画面の背景色
        #screen.blit(bg, rect_bg)            # 背景画像の描画
        rotated = pygame.transform.rotate(player,angle)
        screen.blit(rotated, rect_player)    # プレイヤー画像の描画

        if angle == 0:
            if unco_flag == 0:
                angle = -15
                unco_flag = 1
            elif unco_flag == 1:
                angle = 15
                unco_flag = 0

        elif angle == -15:
            angle = 0
        elif angle == 15:
            angle = 0


        

        # 終了用のイベント処理
        for event in pygame.event.get():
            if event.type == QUIT:          # 閉じるボタンが押されたとき
                pygame.quit()
                sys.exit()
            if event.type == KEYDOWN:       # キーを押したとき
                if event.key == K_ESCAPE:   # Escキーが押されたとき
                    pygame.quit()
                    sys.exit()


if __name__ == "__main__":
        main()