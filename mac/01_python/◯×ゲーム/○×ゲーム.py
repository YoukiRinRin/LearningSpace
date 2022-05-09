from pydoc import cli
from turtle import pos
import pygame
from pygame.locals import *
import sys

from tkinter import messagebox





#masu_img_path = "image/masu.png"

#masu_img = pygame.image.load(masu_img_path)


def main():
    pygame.init()

    turn = 0





    font1 = pygame.font.SysFont(None, 55) 
    text = font1.render("FINISH", True, (255,0,0)) 


    field = [[0,0,0],[0,0,0],[0,0,0]]

    screen_width = 400
    screen_hight = 300

    #マス描画用パラメータ
    size_masu_width = 50
    size_masu_height = 50

    pos_masu_x_first = 65
    pos_masu_y_first = 50

    line_width = 5

    pos_masu_x_second = pos_masu_x_first + size_masu_width + line_width
    pos_masu_x_third = pos_masu_x_second + size_masu_width + line_width

    pos_masu_y_second = pos_masu_y_first + size_masu_height + line_width
    pos_masu_y_third = pos_masu_y_second + size_masu_width + line_width

    white = (255,255,255)

    click_mouse_pos =()

    #◯用パラメータ
    red = (255,0,0)


    pos_circle_x_1 = pos_masu_x_first + size_masu_width / 2
    pos_circle_y_1 = pos_masu_y_first + size_masu_height /2
    
    pos_circle_x_2 = pos_masu_x_second + size_masu_width / 2
    pos_circle_y_2 = pos_masu_y_first + size_masu_height /2
    

    pos_circle_x_3 = pos_masu_x_third+ size_masu_width / 2
    pos_circle_y_3 = pos_masu_y_first + size_masu_height /2
    

    pos_circle_x_4 = pos_masu_x_first + size_masu_width / 2
    pos_circle_y_4 = pos_masu_y_second + size_masu_height /2
    

    pos_circle_x_5 = pos_masu_x_second + size_masu_width / 2
    pos_circle_y_5 = pos_masu_y_second + size_masu_height /2
    

    pos_circle_x_6 = pos_masu_x_third + size_masu_width / 2
    pos_circle_y_6 = pos_masu_y_second + size_masu_height /2
    

    pos_circle_x_7 = pos_masu_x_first + size_masu_width / 2
    pos_circle_y_7 = pos_masu_y_third + size_masu_height /2
    

    pos_circle_x_8 = pos_masu_x_second + size_masu_width / 2
    pos_circle_y_8 = pos_masu_y_third + size_masu_height /2
    

    pos_circle_x_9 = pos_masu_x_third + size_masu_width / 2
    pos_circle_y_9 = pos_masu_y_third + size_masu_height /2
    

    pos_circle_center_1 = (pos_circle_x_1,pos_circle_y_1)
    pos_circle_center_2 = (pos_circle_x_2,pos_circle_y_2)
    pos_circle_center_3 = (pos_circle_x_3,pos_circle_y_3)
    pos_circle_center_4 = (pos_circle_x_4,pos_circle_y_4)
    pos_circle_center_5 = (pos_circle_x_5,pos_circle_y_5)
    pos_circle_center_6 = (pos_circle_x_6,pos_circle_y_6)
    pos_circle_center_7 = (pos_circle_x_7,pos_circle_y_7)
    pos_circle_center_8 = (pos_circle_x_8,pos_circle_y_8)
    pos_circle_center_9 = (pos_circle_x_9,pos_circle_y_9)



    radius_circle = 25

        
    range_masu_start_1=(pos_masu_x_first,pos_masu_y_first)
    range_masu_end_1=(pos_masu_x_first + size_masu_width,pos_masu_y_first + size_masu_height)

    range_masu_start_2 = (pos_masu_x_second,pos_masu_y_first)
    range_masu_end_2=(pos_masu_x_second + size_masu_width,pos_masu_y_first + size_masu_height)

    range_masu_start_3 = (pos_masu_x_third,pos_masu_y_first)
    range_masu_end_3=(pos_masu_x_third + size_masu_width,pos_masu_y_first + size_masu_height)

    range_masu_start_4=(pos_masu_x_first,pos_masu_y_second)
    range_masu_end_4=(pos_masu_x_first + size_masu_width,pos_masu_y_second + size_masu_height)

    range_masu_start_5 = (pos_masu_x_second,pos_masu_y_second)
    range_masu_end_5=(pos_masu_x_second + size_masu_width,pos_masu_y_second + size_masu_height)

    range_masu_start_6 = (pos_masu_x_third,pos_masu_y_first)
    range_masu_end_6=(pos_masu_x_third + size_masu_width,pos_masu_y_second + size_masu_height)

    range_masu_start_7=(pos_masu_x_first,pos_masu_y_second)
    range_masu_end_7=(pos_masu_x_first + size_masu_width,pos_masu_y_third + size_masu_height)

    range_masu_start_8 = (pos_masu_x_second,pos_masu_y_second)
    range_masu_end_8=(pos_masu_x_second + size_masu_width,pos_masu_y_third + size_masu_height)

    range_masu_start_9 = (pos_masu_x_third,pos_masu_y_first)
    range_masu_end_9=(pos_masu_x_third + size_masu_width,pos_masu_y_third + size_masu_height)



    #pygame.draw.line(screen, (0,0,255), (start_pos_x_l_1,start_pos_y_l_1), (end_pos_x_l_1,end_pos_y_l_1), 10) 
    #pygame.draw.line(screen, (0,0,255), (start_pos_x_r_1,start_pos_y_r_1), (end_pos_x_r_1,end_pos_y_r_1), 10) 
    

    start_pos_x_l_1 = pos_masu_x_first
    start_pos_y_l_1 = pos_masu_y_first
    end_pos_x_l_1 = pos_masu_x_first + size_masu_width
    end_pos_y_l_1 = pos_masu_y_first+size_masu_height

    start_pos_x_r_1 = pos_masu_x_first + size_masu_width
    start_pos_y_r_1 = pos_masu_y_first
    end_pos_x_r_1 = pos_masu_x_first
    end_pos_y_r_1 = pos_masu_y_first+size_masu_height


    start_pos_x_l_2 = pos_masu_x_first + size_masu_width + line_width
    start_pos_y_l_2 = pos_masu_y_first
    end_pos_x_l_2 = pos_masu_x_first + size_masu_width  + size_masu_width + line_width
    end_pos_y_l_2 = pos_masu_y_first+size_masu_height

    start_pos_x_r_2 = pos_masu_x_first + size_masu_width + size_masu_width + line_width
    start_pos_y_r_2 = pos_masu_y_first
    end_pos_x_r_2 = pos_masu_x_first + size_masu_width + line_width
    end_pos_y_r_2 = pos_masu_y_first+size_masu_height


    start_pos_x_l_3 = start_pos_x_l_2 + size_masu_width
    start_pos_y_l_3 = pos_masu_y_first
    end_pos_x_l_3 = end_pos_x_l_2 + size_masu_width   + line_width
    end_pos_y_l_3 = pos_masu_y_first+size_masu_height

    start_pos_x_r_3 = start_pos_x_r_2 + size_masu_width
    start_pos_y_r_3 = pos_masu_y_first
    end_pos_x_r_3 = end_pos_x_r_2  + line_width + size_masu_width 
    end_pos_y_r_3 = pos_masu_y_first+size_masu_height


    start_pos_x_l_4 = pos_masu_x_first
    start_pos_y_l_4 = pos_masu_y_first  + size_masu_height + line_width
    end_pos_x_l_4 = pos_masu_x_first + size_masu_width
    end_pos_y_l_4 = pos_masu_y_first+size_masu_height + size_masu_height + line_width

    start_pos_x_r_4 = pos_masu_x_first + size_masu_width
    start_pos_y_r_4 = pos_masu_y_first + size_masu_height + line_width
    end_pos_x_r_4 = pos_masu_x_first
    end_pos_y_r_4 = pos_masu_y_first+size_masu_height + size_masu_height + line_width


    start_pos_x_l_5 = pos_masu_x_first + size_masu_width + line_width
    start_pos_y_l_5 = pos_masu_y_first + size_masu_height + line_width
    end_pos_x_l_5 = pos_masu_x_first + size_masu_width  + size_masu_width + line_width
    end_pos_y_l_5 = pos_masu_y_first+size_masu_height + size_masu_height + line_width

    start_pos_x_r_5 = pos_masu_x_first + size_masu_width + size_masu_width + line_width
    start_pos_y_r_5 = pos_masu_y_first + size_masu_height + line_width
    end_pos_x_r_5 = pos_masu_x_first + size_masu_width + line_width
    end_pos_y_r_5 = pos_masu_y_first+size_masu_height + size_masu_height + line_width


    start_pos_x_l_6 = start_pos_x_l_2 + size_masu_width
    start_pos_y_l_6 = pos_masu_y_first + size_masu_height + line_width
    end_pos_x_l_6 = end_pos_x_l_2 + size_masu_width   + line_width
    end_pos_y_l_6 = pos_masu_y_first+size_masu_height + size_masu_height + line_width

    start_pos_x_r_6 = start_pos_x_r_2 + size_masu_width
    start_pos_y_r_6 = pos_masu_y_first + size_masu_height + line_width
    end_pos_x_r_6 = end_pos_x_r_2  + line_width + size_masu_width 
    end_pos_y_r_6 = pos_masu_y_first+size_masu_height + size_masu_height + line_width


    """
    pygame.draw.line(screen, (0,0,255), (start_pos_x_l_2,start_pos_y_l_2), (end_pos_x_l_2,end_pos_y_l_2), 10) 
    pygame.draw.line(screen, (0,0,255), (start_pos_x_r_2,start_pos_y_r_2), (end_pos_x_r_2,end_pos_y_r_2), 10) 
"""
    

    pygame.init()                                   # Pygameの初期化
    screen = pygame.display.set_mode((screen_width, screen_hight))    # 大きさ400*300の画面を生成
    pygame.display.set_caption("○×ゲーム")              # タイトルバーに表示する文字




    while (1):
        screen.fill((0,0,0))        # 画面を黒色(#000000)に塗りつぶし

        #マス描画
        #1行目
        pygame.draw.rect(screen,white,(pos_masu_x_first,pos_masu_y_first,size_masu_width,size_masu_height))
        pygame.draw.rect(screen,white,(pos_masu_x_second,pos_masu_y_first,size_masu_width,size_masu_height))
        pygame.draw.rect(screen,white,(pos_masu_x_third,pos_masu_y_first,size_masu_width,size_masu_height))
        
        #2行目
        pygame.draw.rect(screen,white,(pos_masu_x_first,pos_masu_y_second,size_masu_width,size_masu_height))
        pygame.draw.rect(screen,white,(pos_masu_x_second,pos_masu_y_second,size_masu_width,size_masu_height))
        pygame.draw.rect(screen,white,(pos_masu_x_third,pos_masu_y_second,size_masu_width,size_masu_height))

        #3行目    
        pygame.draw.rect(screen,white,(pos_masu_x_first,pos_masu_y_third,size_masu_width,size_masu_height))
        pygame.draw.rect(screen,white,(pos_masu_x_second,pos_masu_y_third,size_masu_width,size_masu_height))
        pygame.draw.rect(screen,white,(pos_masu_x_third,pos_masu_y_third,size_masu_width,size_masu_height))
        

        #pygame.draw.circle(screen,red,pos_circle_center,radius_circle,10)

        
        for event in pygame.event.get():
            if event.type == MOUSEBUTTONDOWN:
                click_mouse_pos = pygame.mouse.get_pos()

                if turn == 0:
                    if click_mouse_pos[0] >= range_masu_start_1[0] and click_mouse_pos[1] >= range_masu_start_1[1] and click_mouse_pos[0] <= range_masu_end_1[0] and click_mouse_pos[1] <= range_masu_end_1[1]:
                        
                        field[0][0] = 1
                    elif click_mouse_pos[0] >= range_masu_start_2[0] and click_mouse_pos[1] >= range_masu_start_2[1] and click_mouse_pos[0] <= range_masu_end_2[0] and click_mouse_pos[1] <= range_masu_end_2[1]:
                
                        field[0][1] = 1
                    elif click_mouse_pos[0] >= range_masu_start_3[0] and click_mouse_pos[1] >= range_masu_start_3[1] and click_mouse_pos[0] <= range_masu_end_3[0] and click_mouse_pos[1] <= range_masu_end_3[1]:
                        
                        field[0][2] = 1
                    elif click_mouse_pos[0] >= range_masu_start_4[0] and click_mouse_pos[1] >= range_masu_start_4[1] and click_mouse_pos[0] <= range_masu_end_4[0] and click_mouse_pos[1] <= range_masu_end_4[1]:
                        
                        field[1][0] = 1
                    elif click_mouse_pos[0] >= range_masu_start_5[0] and click_mouse_pos[1] >= range_masu_start_5[1] and click_mouse_pos[0] <= range_masu_end_5[0] and click_mouse_pos[1] <= range_masu_end_5[1]:
                        
                        field[1][1] = 1
                    elif click_mouse_pos[0] >= range_masu_start_6[0] and click_mouse_pos[1] >= range_masu_start_6[1] and click_mouse_pos[0] <= range_masu_end_6[0] and click_mouse_pos[1] <= range_masu_end_6[1]:
                        
                        field[1][2] = 1
                    elif click_mouse_pos[0] >= range_masu_start_7[0] and click_mouse_pos[1] >= range_masu_start_7[1] and click_mouse_pos[0] <= range_masu_end_7[0] and click_mouse_pos[1] <= range_masu_end_7[1]:
                    
                        field[2][0] = 1
                    elif click_mouse_pos[0] >= range_masu_start_8[0] and click_mouse_pos[1] >= range_masu_start_8[1] and click_mouse_pos[0] <= range_masu_end_8[0] and click_mouse_pos[1] <= range_masu_end_8[1]:
                        
                        field[2][1] = 1
                    elif click_mouse_pos[0] >= range_masu_start_9[0] and click_mouse_pos[1] >= range_masu_start_9[1] and click_mouse_pos[0] <= range_masu_end_9[0] and click_mouse_pos[1] <= range_masu_end_9[1]:
                        
                        field[2][2] = 1
                    turn = 1
                elif turn == 1:
                    if click_mouse_pos[0] >= range_masu_start_1[0] and click_mouse_pos[1] >= range_masu_start_1[1] and click_mouse_pos[0] <= range_masu_end_1[0] and click_mouse_pos[1] <= range_masu_end_1[1]:
                        pos_circle_center_1 = (pos_circle_x_1,pos_circle_y_1)
                        field[0][0] = 2
                    elif click_mouse_pos[0] >= range_masu_start_2[0] and click_mouse_pos[1] >= range_masu_start_2[1] and click_mouse_pos[0] <= range_masu_end_2[0] and click_mouse_pos[1] <= range_masu_end_2[1]:
                        pos_circle_center_2 = (pos_circle_x_2,pos_circle_y_2)
                        field[0][1] = 2
                    elif click_mouse_pos[0] >= range_masu_start_3[0] and click_mouse_pos[1] >= range_masu_start_3[1] and click_mouse_pos[0] <= range_masu_end_3[0] and click_mouse_pos[1] <= range_masu_end_3[1]:
                        pos_circle_center_3 = (pos_circle_x_3,pos_circle_y_3)
                        field[0][2] = 2
                    elif click_mouse_pos[0] >= range_masu_start_4[0] and click_mouse_pos[1] >= range_masu_start_4[1] and click_mouse_pos[0] <= range_masu_end_4[0] and click_mouse_pos[1] <= range_masu_end_4[1]:
                        pos_circle_center_4 = (pos_circle_x_4,pos_circle_y_4)
                        field[1][0] = 2
                    elif click_mouse_pos[0] >= range_masu_start_5[0] and click_mouse_pos[1] >= range_masu_start_5[1] and click_mouse_pos[0] <= range_masu_end_5[0] and click_mouse_pos[1] <= range_masu_end_5[1]:
                        pos_circle_center_5 = (pos_circle_x_5,pos_circle_y_5)
                        field[1][1] = 2
                    elif click_mouse_pos[0] >= range_masu_start_6[0] and click_mouse_pos[1] >= range_masu_start_6[1] and click_mouse_pos[0] <= range_masu_end_6[0] and click_mouse_pos[1] <= range_masu_end_6[1]:
                        pos_circle_center_6 = (pos_circle_x_6,pos_circle_y_6)
                        field[1][2] = 2
                    elif click_mouse_pos[0] >= range_masu_start_7[0] and click_mouse_pos[1] >= range_masu_start_7[1] and click_mouse_pos[0] <= range_masu_end_7[0] and click_mouse_pos[1] <= range_masu_end_7[1]:
                        pos_circle_center_7 = (pos_circle_x_7,pos_circle_y_7)
                        field[2][0] = 2
                    elif click_mouse_pos[0] >= range_masu_start_8[0] and click_mouse_pos[1] >= range_masu_start_8[1] and click_mouse_pos[0] <= range_masu_end_8[0] and click_mouse_pos[1] <= range_masu_end_8[1]:
                        pos_circle_center_8 = (pos_circle_x_8,pos_circle_y_8)
                        field[2][1] = 2
                    elif click_mouse_pos[0] >= range_masu_start_9[0] and click_mouse_pos[1] >= range_masu_start_9[1] and click_mouse_pos[0] <= range_masu_end_9[0] and click_mouse_pos[1] <= range_masu_end_9[1]:
                        pos_circle_center_9 = (pos_circle_x_9,pos_circle_y_9)
                        field[2][2] = 2
                    turn = 0
            elif event.type == QUIT:  # 閉じるボタンが押されたら終了
                pygame.quit()       # Pygameの終了(画面閉じられる)
                sys.exit()
        
        if field[0][0] == field[0][1] and field[0][1] == field[0][2]:
            screen.blit(text, [20, 100])
            
        #1マス目

        if field[0][0] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_1,radius_circle,10)
        elif field[0][0] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        if field[0][1] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_2,radius_circle,10)
        elif field[0][1] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        if field[0][2] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_3,radius_circle,10)
        elif field[0][2] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 


        if field[1][0] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_4,radius_circle,10)
        elif field[1][0] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        if field[1][1] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_5,radius_circle,10)
        elif field[1][1] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        if field[1][2] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_6,radius_circle,10)
        elif field[1][2] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 


        if field[2][0] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_4,radius_circle,10)
        elif field[2][0] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        if field[2][1] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_5,radius_circle,10)
        elif field[2][1] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        if field[2][2] == 1:
            pygame.draw.circle(screen,red,pos_circle_center_6,radius_circle,10)
        elif field[2][2] == 2:
            pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
            pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 


        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_1,start_pos_y_l_1), (end_pos_x_l_1,end_pos_y_l_1), 10) 
        pygame.draw.line(screen, (0,0,255), (start_pos_x_r_1,start_pos_y_r_1), (end_pos_x_r_1,end_pos_y_r_1), 10) 

        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_2,start_pos_y_l_2), (end_pos_x_l_2,end_pos_y_l_2), 10) 
        pygame.draw.line(screen, (0,0,255), (start_pos_x_r_2,start_pos_y_r_2), (end_pos_x_r_2,end_pos_y_r_2), 10) 

        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_3,start_pos_y_l_3), (end_pos_x_l_3,end_pos_y_l_3), 10) 
        pygame.draw.line(screen, (0,0,255), (start_pos_x_r_3,start_pos_y_r_3), (end_pos_x_r_3,end_pos_y_r_3), 10) 
    
        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_4,start_pos_y_l_4), (end_pos_x_l_4,end_pos_y_l_4), 10) 
        pygame.draw.line(screen, (0,0,255), (start_pos_x_r_4,start_pos_y_r_4), (end_pos_x_r_4,end_pos_y_r_4), 10) 
    
        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_5,start_pos_y_l_5), (end_pos_x_l_5,end_pos_y_l_5), 10) 
        pygame.draw.line(screen, (0,0,255), (start_pos_x_r_5,start_pos_y_r_5), (end_pos_x_r_5,end_pos_y_r_5), 10) 
    
        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_6,start_pos_y_l_6), (end_pos_x_l_6,end_pos_y_l_6), 10) 
        pygame.draw.line(screen, (0,0,255), (start_pos_x_r_6,start_pos_y_r_6), (end_pos_x_r_6,end_pos_y_r_6), 10) 
    

        """
        pygame.draw.circle(screen,red,pos_circle_center_4,radius_circle,10)
        pygame.draw.circle(screen,red,pos_circle_center_5,radius_circle,10)
        pygame.draw.circle(screen,red,pos_circle_center_6,radius_circle,10)
        pygame.draw.circle(screen,red,pos_circle_center_7,radius_circle,10)
        pygame.draw.circle(screen,red,pos_circle_center_8,radius_circle,10)
        pygame.draw.circle(screen,red,pos_circle_center_9,radius_circle,10)
        """

        """
        pygame.draw.line(screen, (0,0,255), (start_pos_x_l_1,start_pos_y_l_1), (end_pos_x_l_1,end_pos_y_l_1), 10)
        
        
        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 

        pygame.draw.line(screen, (0,0,255), (pos_masu_x_first,pos_masu_y_first), (pos_masu_x_first + size_masu_width,pos_masu_y_first+size_masu_height), 10) 
        pygame.draw.line(screen, (0,0,255),(pos_masu_x_first + size_masu_width,pos_masu_y_first),(pos_masu_x_first,pos_masu_y_first + size_masu_height), 10) 
    """
    
        
        

        pygame.display.update()     # 画面を更

        #screen.blit(masu_img(masu_height,masu_width))

        
        
        


if __name__ == "__main__":
    main()




