import pygame
from pygame.locals import *
import sys
import os


def main():

    abs_path = os.path.dirname(os.path.abspath(__file__))

    size_image_w = 80
    size_image_h = 120


    path_image = abs_path + "/image"
    path_image_heart = path_image + "/heart"
    path_image_diamond = path_image + "/diamond"
    path_image_clover = path_image + "/clover" 
    path_image_spade = path_image + "/spade"

    img1 = pygame.image.load(path_image_heart+'/card_heart_01.png',)
    img2 = pygame.image.load(path_image_heart+'/card_heart_02.png')
    img3 = pygame.image.load(path_image_heart+'/card_heart_03.png')
    img4 = pygame.image.load(path_image_heart+'/card_heart_04.png')
    img5 = pygame.image.load(path_image_heart+'/card_heart_05.png')
    img6 = pygame.image.load(path_image_heart+'/card_heart_06.png')
    img7 = pygame.image.load(path_image_heart+'/card_heart_07.png')
    img8 = pygame.image.load(path_image_heart+'/card_heart_08.png')
    img9 = pygame.image.load(path_image_heart+'/card_heart_09.png')
    img10 = pygame.image.load(path_image_heart+'/card_heart_10.png')
    img11 = pygame.image.load(path_image_heart+'/card_heart_11.png')
    img12 = pygame.image.load(path_image_heart+'/card_heart_12.png')
    img13 = pygame.image.load(path_image_heart+'/card_heart_13.png')
    img14 = pygame.image.load(path_image_diamond+'/card_diamond_01.png')
    img15 = pygame.image.load(path_image_diamond+'/card_diamond_02.png')
    img16 = pygame.image.load(path_image_diamond+'/card_diamond_03.png')
    img17 = pygame.image.load(path_image_diamond+'/card_diamond_04.png')
    img18 = pygame.image.load(path_image_diamond+'/card_diamond_05.png')
    img19 = pygame.image.load(path_image_diamond+'/card_diamond_06.png')
    img20 = pygame.image.load(path_image_diamond+'/card_diamond_07.png')
    img21 = pygame.image.load(path_image_diamond+'/card_diamond_08.png')
    img22 = pygame.image.load(path_image_diamond+'/card_diamond_09.png')
    img23 = pygame.image.load(path_image_diamond+'/card_diamond_10.png')
    img24 = pygame.image.load(path_image_diamond+'/card_diamond_11.png')
    img25 = pygame.image.load(path_image_diamond+'/card_diamond_12.png')
    img26 = pygame.image.load(path_image_diamond+'/card_diamond_13.png')
    img27 = pygame.image.load(path_image_spade+'/card_spade_01.png')
    img28 = pygame.image.load(path_image_spade+'/card_spade_02.png')
    img29 = pygame.image.load(path_image_spade+'/card_spade_03.png')
    img30 = pygame.image.load(path_image_spade+'/card_spade_04.png')
    img31 = pygame.image.load(path_image_spade+'/card_spade_05.png')
    img32 = pygame.image.load(path_image_spade+'/card_spade_06.png')
    img33 = pygame.image.load(path_image_spade+'/card_spade_07.png')
    img34 = pygame.image.load(path_image_spade+'/card_spade_08.png')
    img35 = pygame.image.load(path_image_spade+'/card_spade_09.png')
    img36 = pygame.image.load(path_image_spade+'/card_spade_10.png')
    img37 = pygame.image.load(path_image_spade+'/card_spade_11.png')
    img38 = pygame.image.load(path_image_spade+'/card_spade_13.png')
    img39 = pygame.image.load(path_image_spade+'/card_spade_13.png')
    img40 = pygame.image.load(path_image_clover+'/card_club_01.png')
    img41 = pygame.image.load(path_image_clover+'/card_club_02.png')
    img42 = pygame.image.load(path_image_clover+'/card_club_03.png')
    img43 = pygame.image.load(path_image_clover+'/card_club_04.png')
    img44 = pygame.image.load(path_image_clover+'/card_club_05.png')
    img45 = pygame.image.load(path_image_clover+'/card_club_06.png')
    img46 = pygame.image.load(path_image_clover+'/card_club_07.png')
    img47 = pygame.image.load(path_image_clover+'/card_club_08.png')
    img48 = pygame.image.load(path_image_clover+'/card_club_09.png')
    img49 = pygame.image.load(path_image_clover+'/card_club_10.png')
    img50 = pygame.image.load(path_image_clover+'/card_club_11.png')
    img51 = pygame.image.load(path_image_clover+'/card_club_12.png')
    img52 = pygame.image.load(path_image_clover+'/card_club_13.png')
    
    img_back = pygame.image.load(path_image+'/card_back.png')

    img1=pygame.transform.scale(img1, (size_image_w,size_image_h ))
    img2=pygame.transform.scale(img2, (size_image_w,size_image_h ))
    img3=pygame.transform.scale(img3, (size_image_w,size_image_h ))
    img4=pygame.transform.scale(img4, (size_image_w,size_image_h ))
    img5=pygame.transform.scale(img5, (size_image_w,size_image_h ))
    img6=pygame.transform.scale(img6, (size_image_w,size_image_h ))
    img7=pygame.transform.scale(img7, (size_image_w,size_image_h ))
    img8=pygame.transform.scale(img8, (size_image_w,size_image_h ))
    img9=pygame.transform.scale(img9, (size_image_w,size_image_h ))
    img10=pygame.transform.scale(img10, (size_image_w,size_image_h ))
    img11=pygame.transform.scale(img11, (size_image_w,size_image_h ))
    img12=pygame.transform.scale(img12, (size_image_w,size_image_h ))
    img13=pygame.transform.scale(img13, (size_image_w,size_image_h ))
    img14=pygame.transform.scale(img14, (size_image_w,size_image_h ))
    img15=pygame.transform.scale(img15, (size_image_w,size_image_h ))
    img16=pygame.transform.scale(img16, (size_image_w,size_image_h ))
    img17=pygame.transform.scale(img17, (size_image_w,size_image_h ))
    img18=pygame.transform.scale(img18, (size_image_w,size_image_h ))
    img19=pygame.transform.scale(img19, (size_image_w,size_image_h ))
    img20=pygame.transform.scale(img20, (size_image_w,size_image_h ))
    img21=pygame.transform.scale(img21, (size_image_w,size_image_h ))
    img22=pygame.transform.scale(img22, (size_image_w,size_image_h ))
    img23=pygame.transform.scale(img23, (size_image_w,size_image_h ))
    img24=pygame.transform.scale(img24, (size_image_w,size_image_h ))
    img25=pygame.transform.scale(img25, (size_image_w,size_image_h ))
    img26=pygame.transform.scale(img26, (size_image_w,size_image_h ))
    img27=pygame.transform.scale(img27, (size_image_w,size_image_h ))
    img28=pygame.transform.scale(img28, (size_image_w,size_image_h ))
    img29=pygame.transform.scale(img29, (size_image_w,size_image_h ))
    img30=pygame.transform.scale(img30, (size_image_w,size_image_h ))
    img31=pygame.transform.scale(img31, (size_image_w,size_image_h ))
    img32=pygame.transform.scale(img32, (size_image_w,size_image_h ))
    img33=pygame.transform.scale(img33, (size_image_w,size_image_h ))
    img34=pygame.transform.scale(img34, (size_image_w,size_image_h ))
    img35=pygame.transform.scale(img35, (size_image_w,size_image_h ))
    img36=pygame.transform.scale(img36, (size_image_w,size_image_h ))
    img37=pygame.transform.scale(img37, (size_image_w,size_image_h ))
    img38=pygame.transform.scale(img38, (size_image_w,size_image_h ))
    img39=pygame.transform.scale(img39, (size_image_w,size_image_h ))
    img40=pygame.transform.scale(img40, (size_image_w,size_image_h ))
    img41=pygame.transform.scale(img41, (size_image_w,size_image_h ))
    img42=pygame.transform.scale(img42, (size_image_w,size_image_h ))
    img43=pygame.transform.scale(img43, (size_image_w,size_image_h ))
    img44=pygame.transform.scale(img44, (size_image_w,size_image_h ))
    img45=pygame.transform.scale(img45, (size_image_w,size_image_h ))
    img46=pygame.transform.scale(img46, (size_image_w,size_image_h ))
    img47=pygame.transform.scale(img47, (size_image_w,size_image_h ))
    img48=pygame.transform.scale(img48, (size_image_w,size_image_h ))
    img49=pygame.transform.scale(img49, (size_image_w,size_image_h ))
    img50=pygame.transform.scale(img50, (size_image_w,size_image_h ))
    img51=pygame.transform.scale(img51, (size_image_w,size_image_h ))
    img52=pygame.transform.scale(img52, (size_image_w,size_image_h ))

    img_back = pygame.transform.scale(img_back, (size_image_w,size_image_h ))


    field = []
    for i in range(52):
        field.append(i)

    distance = 5

    card_1_x_str = 20
    card_1_x_fin = card_1_x_str + size_image_w
    card_1_y_str = 20
    card_1_y_fin = card_1_y_str + size_image_h

    card_2_x_str = card_1_x_fin + distance
    card_2_x_fin =  card_2_x_str + size_image_w
    card_2_y_str = card_1_y_str
    card_2_y_fin = card_1_y_fin

    card_3_x_str = card_2_x_fin + distance
    card_3_x_fin =  card_3_x_str + size_image_w
    card_3_y_str = card_1_y_str
    card_3_y_fin = card_1_y_fin

    card_4_x_str = card_3_x_fin + distance
    card_4_x_fin =  card_4_x_str + size_image_w
    card_4_y_str = card_1_y_str
    card_4_y_fin = card_1_y_fin

    card_5_x_str = card_4_x_fin + distance
    card_5_x_fin =  card_5_x_str + size_image_w
    card_5_y_str = card_1_y_str
    card_5_y_fin = card_1_y_fin

    card_6_x_str = card_5_x_fin + distance
    card_6_x_fin =  card_6_x_str + size_image_w
    card_6_y_str = card_1_y_str
    card_6_y_fin = card_1_y_fin

    card_7_x_str = card_6_x_fin + distance
    card_7_x_fin =  card_7_x_str + size_image_w
    card_7_y_str = card_1_y_str
    card_7_y_fin = card_1_y_fin

    card_8_x_str = card_7_x_fin + distance
    card_8_x_fin =  card_8_x_str + size_image_w
    card_8_y_str = card_1_y_str
    card_8_y_fin = card_1_y_fin

    card_9_x_str = card_8_x_fin + distance
    card_9_x_fin =  card_9_x_str + size_image_w
    card_9_y_str = card_1_y_str
    card_9_y_fin = card_1_y_fin

    card_10_x_str = card_9_x_fin + distance
    card_10_x_fin =  card_10_x_str + size_image_w
    card_10_y_str = card_1_y_str
    card_10_y_fin = card_1_y_fin

    card_11_x_str = card_1_x_fin
    card_11_x_fin = card_1_x_str 
    card_11_y_str = card_1_y_str + distance + size_image_h
    card_11_y_fin = card_1_y_fin + distance + size_image_h




    """
    card_3_x = card_2_x + size_image_w + distance
    card_3_y = card_2_y + size_image_h

    card_4_x = card_3_x + size_image_w + distance
    card_4_y = card_3_y + size_image_h

    card_5_x = card_4_x + size_image_w + distance
    card_5_y = card_4_y + size_image_h

    card_6_x = card_5_x + size_image_w + distance
    card_6_y = card_5_y + size_image_h

    card_7_x = card_6_x + size_image_w + distance
    card_7_y = card_6_y + size_image_h

    card_8_x = card_7_x + size_image_w + distance
    card_8_y = card_7_y + size_image_h

    card_9_x = card_8_x + size_image_w + distance
    card_9_y = card_8_y + size_image_h

    card_10_x = card_9_x + size_image_w + distance
    card_10_y = card_9_y + size_image_h

    card_11_x = card_1_x
    card_11_y = card_1_y + distance + size_image_h

    card_12_x = card_1_x
    card_12_y = card_1_y + distance + size_image_h

    card_13_x = card_1_x
    card_13_y = card_1_y + distance + size_image_h

    card_14_x = card_1_x
    card_14_y = card_1_y + distance + size_image_h

    card_15_x = card_1_x
    card_15_y = card_1_y + distance + size_image_h

    card_16_x = card_1_x
    card_16_y = card_1_y + distance + size_image_h

    card_17_x = card_1_x
    card_17_y = card_1_y + distance + size_image_h

    card_18_x = card_1_x
    card_18_y = card_1_y + distance + size_image_h

    card_19_x = card_1_x
    card_19_y = card_1_y + distance + size_image_h

    card_20_x = card_1_x
    card_20_y = card_1_y + distance + size_image_h

    card_11_x = card_1_x
    card_11_y = card_1_y + distance + size_image_h
"""

    pygame.init()                                   # Pygameの初期化
    screen = pygame.display.set_mode((1250, 750))    # 大きさ400*300の画面を生成
    pygame.display.set_caption("神経衰弱")              # タイトルバーに表示する文字

    while (1):
        screen.fill((0,0,0))        # 画面を黒色(#000000)に塗りつぶし
        
        
        x = 20
        y = 20
        for i_1 in range(5):
            for i in range(10):
                screen.blit(img_back, (x, y))
                x += size_image_w + distance
            x = 20
            y += size_image_h + distance
 


     
        pygame.display.update()     # 画面を更新
        # イベント処理
        for event in pygame.event.get():
            if event.type == QUIT:  # 閉じるボタンが押されたら終了
                pygame.quit()       # Pygameの終了(画面閉じられる)
                sys.exit()

            if event.type == MOUSEBUTTONDOWN and event.button == 1:
                x,y = event.pos
                if x > card_1_x_str and x < card_1_x_fin and y > card_1_y_str and y < card_1_y_fin:
                    print("a")
                elif x > card_2_x_str and x < card_2_x_fin and y > card_2_y_str and y < card_2_y_fin:
                    print("b")
                elif x > card_3_x_str and x < card_3_x_fin and y > card_3_y_str and y < card_3_y_fin:
                    print("c")
                elif x > card_4_x_str and x < card_4_x_fin and y > card_4_y_str and y < card_4_y_fin:
                    print("d")
                elif x > card_5_x_str and x < card_5_x_fin and y > card_5_y_str and y < card_5_y_fin:
                    print("e")
                elif x > card_6_x_str and x < card_6_x_fin and y > card_6_y_str and y < card_6_y_fin:
                    print("f")
                elif x > card_7_x_str and x < card_7_x_fin and y > card_7_y_str and y < card_7_y_fin:
                    print("g")
                elif x > card_8_x_str and x < card_8_x_fin and y > card_8_y_str and y < card_8_y_fin:
                    print("h")
                elif x > card_9_x_str and x < card_9_x_fin and y > card_9_y_str and y < card_9_y_fin:
                    print("i")
                elif x > card_10_x_str and x < card_10_x_fin and y > card_10_y_str and y < card_10_y_fin:
                    print("j")
                elif x > card_11_x_str and x < card_11_x_fin and y > card_11_y_str and y < card_11_y_fin:
                    print("k")
                else:
                    print("else")




if __name__ == "__main__":
    main()