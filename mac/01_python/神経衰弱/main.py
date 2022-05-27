import pygame
from pygame.locals import *
import sys
import os
import random

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

    card_11_x_str = card_1_x_str
    card_11_x_fin = card_1_x_fin
    card_11_y_str = card_1_y_str + distance + size_image_h
    card_11_y_fin = card_1_y_fin + distance + size_image_h

    card_12_x_str = card_2_x_str
    card_12_x_fin = card_2_x_fin
    card_12_y_str = card_2_y_str + distance + size_image_h
    card_12_y_fin = card_2_y_fin + distance + size_image_h

    card_13_x_str = card_3_x_str
    card_13_x_fin = card_3_x_fin
    card_13_y_str = card_3_y_str + distance + size_image_h
    card_13_y_fin = card_3_y_fin + distance + size_image_h

    card_14_x_str = card_4_x_str
    card_14_x_fin = card_4_x_fin
    card_14_y_str = card_4_y_str + distance + size_image_h
    card_14_y_fin = card_4_y_fin + distance + size_image_h

    card_15_x_str = card_5_x_str
    card_15_x_fin = card_5_x_fin
    card_15_y_str = card_5_y_str + distance + size_image_h
    card_15_y_fin = card_5_y_fin + distance + size_image_h

    card_16_x_str = card_6_x_str
    card_16_x_fin = card_6_x_fin
    card_16_y_str = card_6_y_str + distance + size_image_h
    card_16_y_fin = card_6_y_fin + distance + size_image_h

    card_17_x_str = card_7_x_str
    card_17_x_fin = card_7_x_fin
    card_17_y_str = card_7_y_str + distance + size_image_h
    card_17_y_fin = card_7_y_fin + distance + size_image_h

    card_18_x_str = card_8_x_str
    card_18_x_fin = card_8_x_fin
    card_18_y_str = card_8_y_str + distance + size_image_h
    card_18_y_fin = card_8_y_fin + distance + size_image_h

    card_19_x_str = card_9_x_str
    card_19_x_fin = card_9_x_fin
    card_19_y_str = card_9_y_str + distance + size_image_h
    card_19_y_fin = card_9_y_fin + distance + size_image_h

    card_20_x_str = card_10_x_str
    card_20_x_fin = card_10_x_fin
    card_20_y_str = card_10_y_str + distance + size_image_h
    card_20_y_fin = card_10_y_fin + distance + size_image_h

    card_21_x_str = card_1_x_str
    card_21_x_fin = card_1_x_fin
    card_21_y_str = card_11_y_str + distance + size_image_h
    card_21_y_fin = card_11_y_fin + distance + size_image_h

    card_22_x_str = card_2_x_str
    card_22_x_fin = card_2_x_fin
    card_22_y_str = card_12_y_str + distance + size_image_h
    card_22_y_fin = card_12_y_fin + distance + size_image_h

    card_23_x_str = card_13_x_str
    card_23_x_fin = card_13_x_fin
    card_23_y_str = card_13_y_str + distance + size_image_h
    card_23_y_fin = card_13_y_fin + distance + size_image_h

    card_24_x_str = card_14_x_str
    card_24_x_fin = card_14_x_fin
    card_24_y_str = card_14_y_str + distance + size_image_h
    card_24_y_fin = card_14_y_fin + distance + size_image_h

    card_25_x_str = card_15_x_str
    card_25_x_fin = card_15_x_fin
    card_25_y_str = card_15_y_str + distance + size_image_h
    card_25_y_fin = card_15_y_fin + distance + size_image_h

    card_26_x_str = card_16_x_str
    card_26_x_fin = card_16_x_fin
    card_26_y_str = card_16_y_str + distance + size_image_h
    card_26_y_fin = card_16_y_fin + distance + size_image_h

    card_27_x_str = card_17_x_str
    card_27_x_fin = card_17_x_fin
    card_27_y_str = card_17_y_str + distance + size_image_h
    card_27_y_fin = card_17_y_fin + distance + size_image_h

    card_28_x_str = card_18_x_str
    card_28_x_fin = card_18_x_fin
    card_28_y_str = card_18_y_str + distance + size_image_h
    card_28_y_fin = card_18_y_fin + distance + size_image_h

    card_29_x_str = card_19_x_str
    card_29_x_fin = card_19_x_fin
    card_29_y_str = card_19_y_str + distance + size_image_h
    card_29_y_fin = card_19_y_fin + distance + size_image_h

    card_30_x_str = card_20_x_str
    card_30_x_fin = card_20_x_fin
    card_30_y_str = card_20_y_str + distance + size_image_h
    card_30_y_fin = card_20_y_fin + distance + size_image_h

    card_31_x_str = card_21_x_str
    card_31_x_fin = card_21_x_fin
    card_31_y_str = card_21_y_str + distance + size_image_h
    card_31_y_fin = card_21_y_fin + distance + size_image_h

    card_32_x_str = card_22_x_str
    card_32_x_fin = card_22_x_fin
    card_32_y_str = card_22_y_str + distance + size_image_h
    card_32_y_fin = card_22_y_fin + distance + size_image_h

    card_33_x_str = card_23_x_str
    card_33_x_fin = card_23_x_fin
    card_33_y_str = card_23_y_str + distance + size_image_h
    card_33_y_fin = card_23_y_fin + distance + size_image_h

    card_34_x_str = card_24_x_str
    card_34_x_fin = card_24_x_fin
    card_34_y_str = card_24_y_str + distance + size_image_h
    card_34_y_fin = card_24_y_fin + distance + size_image_h

    card_35_x_str = card_25_x_str
    card_35_x_fin = card_25_x_fin
    card_35_y_str = card_25_y_str + distance + size_image_h
    card_35_y_fin = card_25_y_fin + distance + size_image_h

    card_36_x_str = card_26_x_str
    card_36_x_fin = card_26_x_fin
    card_36_y_str = card_26_y_str + distance + size_image_h
    card_36_y_fin = card_26_y_fin + distance + size_image_h

    card_37_x_str = card_27_x_str
    card_37_x_fin = card_27_x_fin
    card_37_y_str = card_27_y_str + distance + size_image_h
    card_37_y_fin = card_27_y_fin + distance + size_image_h

    card_38_x_str = card_28_x_str
    card_38_x_fin = card_28_x_fin
    card_38_y_str = card_28_y_str + distance + size_image_h
    card_38_y_fin = card_28_y_fin + distance + size_image_h

    card_39_x_str = card_29_x_str
    card_39_x_fin = card_29_x_fin
    card_39_y_str = card_29_y_str + distance + size_image_h
    card_39_y_fin = card_29_y_fin + distance + size_image_h

    card_40_x_str = card_30_x_str
    card_40_x_fin = card_30_x_fin
    card_40_y_str = card_30_y_str + distance + size_image_h
    card_40_y_fin = card_30_y_fin + distance + size_image_h

    card_41_x_str = card_31_x_str
    card_41_x_fin = card_31_x_fin
    card_41_y_str = card_31_y_str + distance + size_image_h
    card_41_y_fin = card_31_y_fin + distance + size_image_h

    card_42_x_str = card_32_x_str
    card_42_x_fin = card_32_x_fin
    card_42_y_str = card_32_y_str + distance + size_image_h
    card_42_y_fin = card_32_y_fin + distance + size_image_h

    card_43_x_str = card_33_x_str
    card_43_x_fin = card_33_x_fin
    card_43_y_str = card_33_y_str + distance + size_image_h
    card_43_y_fin = card_33_y_fin + distance + size_image_h

    card_44_x_str = card_34_x_str
    card_44_x_fin = card_34_x_fin
    card_44_y_str = card_34_y_str + distance + size_image_h
    card_44_y_fin = card_34_y_fin + distance + size_image_h

    card_45_x_str = card_35_x_str
    card_45_x_fin = card_35_x_fin
    card_45_y_str = card_35_y_str + distance + size_image_h
    card_45_y_fin = card_35_y_fin + distance + size_image_h

    card_46_x_str = card_36_x_str
    card_46_x_fin = card_36_x_fin
    card_46_y_str = card_36_y_str + distance + size_image_h
    card_46_y_fin = card_36_y_fin + distance + size_image_h

    card_47_x_str = card_37_x_str
    card_47_x_fin = card_37_x_fin
    card_47_y_str = card_37_y_str + distance + size_image_h
    card_47_y_fin = card_37_y_fin + distance + size_image_h

    card_48_x_str = card_38_x_str
    card_48_x_fin = card_38_x_fin
    card_48_y_str = card_38_y_str + distance + size_image_h
    card_48_y_fin = card_38_y_fin + distance + size_image_h

    card_49_x_str = card_39_x_str
    card_49_x_fin = card_39_x_fin
    card_49_y_str = card_39_y_str + distance + size_image_h
    card_49_y_fin = card_39_y_fin + distance + size_image_h

    card_50_x_str = card_40_x_str
    card_50_x_fin = card_40_x_fin
    card_50_y_str = card_40_y_str + distance + size_image_h
    card_50_y_fin = card_40_y_fin + distance + size_image_h










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

    table = [0,0,0,0,0,0,0,0,0,0,
                 0,0,0,0,0,0,0,0,0,0,
                 0,0,0,0,0,0,0,0,0,0,
                 0,0,0,0,0,0,0,0,0,0,
                 0,0,0,0,0,0,0,0,0,0]
    
    table_card = [1,2,3,4,5,6,7,8,9,10,
                  11,12,13,14,15,16,17,18,19,20,
                  21,22,23,24,25,26,27,28,29,30,
                  31,32,33,34,35,36,37,38,39,40,
                  41,42,43,44,45,46,47,48,49,50,]

    random.shuffle(table_card)
    print(table_card)
    """
    table_card=[]
    def shufl_card():

        card_num = random.randrange(51)

        for i in range(50):
            for i2 in range(len(card_num)):
                if card_num == table_card[i2]:
                    table_card.append(card_num) 
    """

    def get_num_card(card_ix):

        ix = card_ix
        return_card_num = 0

        if card_ix == 1:
            return_card_num = 1
        elif card_ix == 2:
            return_card_num = 2
        elif card_ix == 3:
            return_card_num = 3
        elif card_ix == 4:
            return_card_num = 4 
        elif card_ix == 5:
            return_card_num = 5
        elif card_ix == 6:
            return_card_num = 6
        elif card_ix == 7:
            return_card_num = 7
        elif card_ix == 8:
            return_card_num = 8
        elif card_ix == 9:
            return_card_num = 9
        elif card_ix == 10:
            return_card_num = 10
        elif card_ix == 11:
            return_card_num = 11
        elif card_ix == 12:
            return_card_num = 12
        elif card_ix == 13:
            return_card_num = 13
        elif card_ix == 14:
            return_card_num = 1
        elif card_ix == 15:
            return_card_num = 2
        elif card_ix == 16:
            return_card_num = 3
        elif card_ix == 17:
            return_card_num = 4 
        elif card_ix == 18:
            return_card_num = 5
        elif card_ix == 19:
            return_card_num = 6
        elif card_ix == 20:
            return_card_num = 7
        elif card_ix == 21:
            return_card_num = 8
        elif card_ix == 22:
            return_card_num = 9
        elif card_ix == 23:
            return_card_num = 10
        elif card_ix == 24:
            return_card_num = 11
        elif card_ix == 25:
            return_card_num = 12
        elif card_ix == 26:
            return_card_num = 13
        elif card_ix == 27:
            return_card_num = 1
        elif card_ix == 28:
            return_card_num = 2
        elif card_ix == 29:
            return_card_num = 3
        elif card_ix == 30:
            return_card_num = 4 
        elif card_ix == 31:
            return_card_num = 5
        elif card_ix == 32:
            return_card_num = 6
        elif card_ix == 33:
            return_card_num = 7
        elif card_ix == 34:
            return_card_num = 8
        elif card_ix == 35:
            return_card_num = 9
        elif card_ix == 36:
            return_card_num = 10
        elif card_ix == 37:
            return_card_num = 11
        elif card_ix == 38:
            return_card_num = 12
        elif card_ix == 39:
            return_card_num = 13
        elif card_ix == 40:
            return_card_num = 1
        elif card_ix == 41:
            return_card_num = 2
        elif card_ix == 42:
            return_card_num = 3
        elif card_ix == 43:
            return_card_num = 4 
        elif card_ix == 44:
            return_card_num = 5
        elif card_ix == 45:
            return_card_num = 6
        elif card_ix == 46:
            return_card_num = 7
        elif card_ix == 47:
            return_card_num = 8
        elif card_ix == 48:
            return_card_num = 9
        elif card_ix == 49:
            return_card_num = 10
        elif card_ix == 50:
            return_card_num = 11
        elif card_ix == 51:
            return_card_num = 12
        elif card_ix == 52:
            return_card_num = 13

        return return_card_num



    
    def get_card(image):

        img = image
        return_card = 0

        if img == 1:
            return_card = img1
        elif img == 2:
            return_card = img2
        elif img == 3:
            return_card = img3  
        elif img == 4:
            return_card = img4
        elif img == 5:
            return_card = img5
        elif img == 6:
            return_card = img6
        elif img == 7:
            return_card = img7
        elif img == 8:
            return_card = img8
        elif img == 9:
            return_card = img9
        elif img == 10:
            return_card = img10
        elif img == 11:
            return_card = img11
        elif img == 12:
            return_card = img12
        elif img == 13:
            return_card = img13  
        elif img == 14:
            return_card = img14
        elif img == 15:
            return_card = img15
        elif img == 16:
            return_card = img16
        elif img == 17:
            return_card = img17
        elif img == 18:
            return_card = img18
        elif img == 19:
            return_card = img19
        elif img == 20:
            return_card = img20
        elif img == 21:
            return_card = img21
        elif img == 22:
            return_card = img22
        elif img == 23:
            return_card = img23  
        elif img == 24:
            return_card = img24
        elif img == 25:
            return_card = img25
        elif img == 26:
            return_card = img26
        elif img == 27:
            return_card = img27
        elif img == 28:
            return_card = img28
        elif img == 29:
            return_card = img29
        elif img == 30:
            return_card = img30
        elif img == 31:
            return_card = img31
        elif img == 32:
            return_card = img32
        elif img == 33:
            return_card = img33  
        elif img == 34:
            return_card = img34
        elif img == 35:
            return_card = img35
        elif img == 36:
            return_card = img36
        elif img == 37:
            return_card = img37
        elif img == 38:
            return_card = img38
        elif img == 39:
            return_card = img39
        elif img == 40:
            return_card = img40
        elif img == 41:
            return_card = img41
        elif img == 42:
            return_card = img42
        elif img == 43:
            return_card = img43  
        elif img == 44:
            return_card = img44
        elif img == 45:
            return_card = img45
        elif img == 46:
            return_card = img46
        elif img == 47:
            return_card = img47
        elif img == 48:
            return_card = img48
        elif img == 49:
            return_card = img49
        elif img == 50:
            return_card = img50
        



        return return_card

    def get_pos(pos):

        pos_card = pos

        pos_str_x = 0
        pos_str_y = 0

        if pos_card == 0:
            pos_str_x = card_1_x_str
            pos_str_y = card_1_y_str
        elif pos_card == 1:
            pos_str_x = card_2_x_str
            pos_str_y = card_2_y_str
        elif pos_card == 2:
            pos_str_x = card_3_x_str
            pos_str_y = card_3_y_str
        elif pos_card == 3:
            pos_str_x = card_4_x_str
            pos_str_y = card_4_y_str
        elif pos_card == 4:
            pos_str_x = card_5_x_str
            pos_str_y = card_5_y_str
        elif pos_card == 5:
            pos_str_x = card_6_x_str
            pos_str_y = card_6_y_str
        elif pos_card == 6:
            pos_str_x = card_7_x_str
            pos_str_y = card_7_y_str
        elif pos_card == 7:
            pos_str_x = card_8_x_str
            pos_str_y = card_8_y_str
        elif pos_card == 8:
            pos_str_x = card_9_x_str
            pos_str_y = card_9_y_str
        elif pos_card == 9:
            pos_str_x = card_10_x_str
            pos_str_y = card_10_y_str
        elif pos_card == 10:
            pos_str_x = card_11_x_str
            pos_str_y = card_11_y_str
        elif pos_card == 11:
            pos_str_x = card_12_x_str
            pos_str_y = card_12_y_str
        elif pos_card == 12:
            pos_str_x = card_13_x_str
            pos_str_y = card_13_y_str
        elif pos_card == 13:
            pos_str_x = card_14_x_str
            pos_str_y = card_14_y_str
        elif pos_card == 14:
            pos_str_x = card_15_x_str
            pos_str_y = card_15_y_str
        elif pos_card == 15:
            pos_str_x = card_16_x_str
            pos_str_y = card_16_y_str
        elif pos_card == 16:
            pos_str_x = card_17_x_str
            pos_str_y = card_17_y_str
        elif pos_card == 17:
            pos_str_x = card_18_x_str
            pos_str_y = card_18_y_str
        elif pos_card == 18:
            pos_str_x = card_19_x_str
            pos_str_y = card_19_y_str
        elif pos_card == 19:
            pos_str_x = card_20_x_str
            pos_str_y = card_20_y_str
        elif pos_card == 20:
            pos_str_x = card_21_x_str
            pos_str_y = card_21_y_str
        elif pos_card == 21:
            pos_str_x = card_22_x_str
            pos_str_y = card_22_y_str
        elif pos_card == 22:
            pos_str_x = card_23_x_str
            pos_str_y = card_23_y_str
        elif pos_card == 23:
            pos_str_x = card_24_x_str
            pos_str_y = card_24_y_str
        elif pos_card == 24:
            pos_str_x = card_25_x_str
            pos_str_y = card_25_y_str
        elif pos_card == 25:
            pos_str_x = card_26_x_str
            pos_str_y = card_26_y_str
        elif pos_card == 26:
            pos_str_x = card_27_x_str
            pos_str_y = card_27_y_str
        elif pos_card == 27:
            pos_str_x = card_28_x_str
            pos_str_y = card_28_y_str
        elif pos_card == 28:
            pos_str_x = card_29_x_str
            pos_str_y = card_29_y_str
        elif pos_card == 29:
            pos_str_x = card_30_x_str
            pos_str_y = card_30_y_str
        elif pos_card == 30:
            pos_str_x = card_31_x_str
            pos_str_y = card_31_y_str
        elif pos_card == 31:
            pos_str_x = card_32_x_str
            pos_str_y = card_32_y_str
        elif pos_card == 32:
            pos_str_x = card_33_x_str
            pos_str_y = card_33_y_str
        elif pos_card == 33:
            pos_str_x = card_34_x_str
            pos_str_y = card_34_y_str
        elif pos_card == 34:
            pos_str_x = card_35_x_str
            pos_str_y = card_35_y_str
        elif pos_card == 35:
            pos_str_x = card_36_x_str
            pos_str_y = card_36_y_str
        elif pos_card == 36:
            pos_str_x = card_37_x_str
            pos_str_y = card_37_y_str
        elif pos_card == 37:
            pos_str_x = card_38_x_str
            pos_str_y = card_38_y_str
        elif pos_card == 38:
            pos_str_x = card_39_x_str
            pos_str_y = card_39_y_str
        elif pos_card == 39:
            pos_str_x = card_40_x_str
            pos_str_y = card_40_y_str
        elif pos_card == 40:
            pos_str_x = card_41_x_str
            pos_str_y = card_41_y_str
        elif pos_card == 41:
            pos_str_x = card_42_x_str
            pos_str_y = card_42_y_str
        elif pos_card == 42:
            pos_str_x = card_43_x_str
            pos_str_y = card_43_y_str
        elif pos_card == 43:
            pos_str_x = card_44_x_str
            pos_str_y = card_44_y_str
        elif pos_card == 44:
            pos_str_x = card_45_x_str
            pos_str_y = card_45_y_str
        elif pos_card == 45:
            pos_str_x = card_46_x_str
            pos_str_y = card_46_y_str
        elif pos_card == 46:
            pos_str_x = card_47_x_str
            pos_str_y = card_47_y_str
        elif pos_card == 47:
            pos_str_x = card_48_x_str
            pos_str_y = card_48_y_str
        elif pos_card == 48:
            pos_str_x = card_49_x_str
            pos_str_y = card_49_y_str
        elif pos_card == 49:
            pos_str_x = card_50_x_str
            pos_str_y = card_50_y_str
        
        
        return pos_str_x,pos_str_y


        


    while (1):
        screen.fill((0,0,0))        # 画面を黒色(#000000)に塗りつぶし
        x = 20
        y = 20
    
        for i_1 in range(5):
            for i in range(10):
                table_now = i_1 * 10 + i
                if table[table_now] == 0:
                    screen.blit(img_back, (x, y))
                elif table[table_now] == 1:
                    img = get_card(table_card[table_now])
                    pos = get_pos(table_now)
                    a = get_num_card(table_card[table_now])
                    print(a)
                    screen.blit(img, pos)
                    
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
                    print("1")
                    table[0] = 1
                elif x > card_2_x_str and x < card_2_x_fin and y > card_2_y_str and y < card_2_y_fin:
                    print("2")
                    table[1] = 1
                elif x > card_3_x_str and x < card_3_x_fin and y > card_3_y_str and y < card_3_y_fin:
                    print("3")
                    table[2] = 1
                elif x > card_4_x_str and x < card_4_x_fin and y > card_4_y_str and y < card_4_y_fin:
                    print("4")
                    table[3] = 1
                elif x > card_5_x_str and x < card_5_x_fin and y > card_5_y_str and y < card_5_y_fin:
                    print("5")
                    table[4] = 1
                elif x > card_6_x_str and x < card_6_x_fin and y > card_6_y_str and y < card_6_y_fin:
                    print("6")
                    table[5] = 1
                elif x > card_7_x_str and x < card_7_x_fin and y > card_7_y_str and y < card_7_y_fin:
                    print("7")
                    table[6] = 1
                elif x > card_8_x_str and x < card_8_x_fin and y > card_8_y_str and y < card_8_y_fin:
                    print("8")
                    table[7] = 1
                elif x > card_9_x_str and x < card_9_x_fin and y > card_9_y_str and y < card_9_y_fin:
                    print("9")
                    table[8] = 1
                elif x > card_10_x_str and x < card_10_x_fin and y > card_10_y_str and y < card_10_y_fin:
                    print("10")
                    table[9] = 1
                elif x > card_11_x_str and x < card_11_x_fin and y > card_11_y_str and y < card_11_y_fin:
                    print("11")
                    table[10] = 1
                elif x > card_12_x_str and x < card_12_x_fin and y > card_12_y_str and y < card_12_y_fin:
                    print("12")
                    table[11] = 1
                elif x > card_13_x_str and x < card_13_x_fin and y > card_13_y_str and y < card_13_y_fin:
                    print("13")
                    table[12] = 1
                elif x > card_14_x_str and x < card_14_x_fin and y > card_14_y_str and y < card_14_y_fin:
                    print("14")
                    table[13] = 1
                elif x > card_15_x_str and x < card_15_x_fin and y > card_15_y_str and y < card_15_y_fin:
                    print("15")
                    table[14] = 1
                elif x > card_16_x_str and x < card_16_x_fin and y > card_16_y_str and y < card_16_y_fin:
                    print("16")
                    table[15] = 1
                elif x > card_17_x_str and x < card_17_x_fin and y > card_17_y_str and y < card_17_y_fin:
                    print("17")
                    table[16] = 1
                elif x > card_18_x_str and x < card_18_x_fin and y > card_18_y_str and y < card_18_y_fin:
                    print("18")
                    table[17] = 1
                elif x > card_19_x_str and x < card_19_x_fin and y > card_19_y_str and y < card_19_y_fin:
                    print("19")
                    table[18] = 1
                elif x > card_20_x_str and x < card_20_x_fin and y > card_20_y_str and y < card_20_y_fin:
                    print("20")
                    table[19] = 1
                elif x > card_21_x_str and x < card_21_x_fin and y > card_21_y_str and y < card_21_y_fin:
                    print("21")
                    table[20] = 1
                elif x > card_22_x_str and x < card_22_x_fin and y > card_22_y_str and y < card_22_y_fin:
                    print("22")
                    table[21] = 1
                elif x > card_23_x_str and x < card_23_x_fin and y > card_23_y_str and y < card_23_y_fin:
                    print("23")
                    table[22] = 1
                elif x > card_24_x_str and x < card_24_x_fin and y > card_24_y_str and y < card_24_y_fin:
                    print("24")
                    table[23] = 1
                elif x > card_25_x_str and x < card_25_x_fin and y > card_25_y_str and y < card_25_y_fin:
                    print("25")
                    table[24] = 1
                elif x > card_26_x_str and x < card_26_x_fin and y > card_26_y_str and y < card_26_y_fin:
                    print("26")
                    table[25] = 1
                elif x > card_27_x_str and x < card_27_x_fin and y > card_27_y_str and y < card_27_y_fin:
                    print("27")
                    table[26] = 1
                elif x > card_28_x_str and x < card_28_x_fin and y > card_28_y_str and y < card_28_y_fin:
                    print("28")
                    table[27] = 1
                elif x > card_29_x_str and x < card_29_x_fin and y > card_29_y_str and y < card_29_y_fin:
                    print("29")
                    table[28] = 1
                elif x > card_30_x_str and x < card_30_x_fin and y > card_30_y_str and y < card_30_y_fin:
                    print("30")
                    table[29] = 1
                elif x > card_31_x_str and x < card_31_x_fin and y > card_31_y_str and y < card_31_y_fin:
                    print("31")
                    table[30] = 1
                elif x > card_32_x_str and x < card_32_x_fin and y > card_32_y_str and y < card_32_y_fin:
                    print("32")
                    table[31] = 1
                elif x > card_33_x_str and x < card_33_x_fin and y > card_33_y_str and y < card_33_y_fin:
                    print("33")
                    table[32] = 1
                elif x > card_34_x_str and x < card_34_x_fin and y > card_34_y_str and y < card_34_y_fin:
                    print("34")
                    table[33] = 1
                elif x > card_35_x_str and x < card_35_x_fin and y > card_35_y_str and y < card_35_y_fin:
                    print("35")
                    table[34] = 1
                elif x > card_36_x_str and x < card_36_x_fin and y > card_36_y_str and y < card_36_y_fin:
                    print("36")
                    table[35] = 1
                elif x > card_37_x_str and x < card_37_x_fin and y > card_37_y_str and y < card_37_y_fin:
                    print("37")
                    table[36] = 1
                elif x > card_38_x_str and x < card_38_x_fin and y > card_38_y_str and y < card_38_y_fin:
                    print("38")
                    table[37] = 1
                elif x > card_39_x_str and x < card_39_x_fin and y > card_39_y_str and y < card_39_y_fin:
                    print("39")
                    table[38] = 1
                elif x > card_40_x_str and x < card_40_x_fin and y > card_40_y_str and y < card_40_y_fin:
                    print("40")
                    table[39] = 1
                elif x > card_41_x_str and x < card_41_x_fin and y > card_41_y_str and y < card_41_y_fin:
                    print("41")
                    table[40] = 1
                elif x > card_42_x_str and x < card_42_x_fin and y > card_42_y_str and y < card_42_y_fin:
                    print("42")
                    table[41] = 1
                elif x > card_43_x_str and x < card_43_x_fin and y > card_43_y_str and y < card_43_y_fin:
                    print("43")
                    table[42] = 1
                elif x > card_44_x_str and x < card_44_x_fin and y > card_44_y_str and y < card_44_y_fin:
                    print("44")
                    table[43] = 1
                elif x > card_45_x_str and x < card_45_x_fin and y > card_45_y_str and y < card_45_y_fin:
                    print("45")
                    table[44] = 1
                elif x > card_46_x_str and x < card_46_x_fin and y > card_46_y_str and y < card_46_y_fin:
                    print("46")
                    table[45] = 1
                elif x > card_47_x_str and x < card_47_x_fin and y > card_47_y_str and y < card_47_y_fin:
                    print("47")
                    table[46] = 1
                elif x > card_48_x_str and x < card_48_x_fin and y > card_48_y_str and y < card_48_y_fin:
                    print("48")
                    table[47] = 1
                elif x > card_49_x_str and x < card_49_x_fin and y > card_49_y_str and y < card_49_y_fin:
                    print("49")
                    table[48] = 1
                elif x > card_50_x_str and x < card_50_x_fin and y > card_50_y_str and y < card_50_y_fin:
                    print("50")
                    table[49] = 1
                
               
                
               
                else:
                    print("else")

                

                pygame.display.update()     # 画面を更新


if __name__ == "__main__":
    main()