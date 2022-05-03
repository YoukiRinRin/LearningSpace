import pygame
from pygame.locals import *
import sys
import main

masu_color = (0,255,0)
pos_masu_str_x = 0
pos_mas_str_y  = 0
pos_mas_fin_x = 0
pos_mas_fin_y = 0

class field:
 
    def __init__(self):
        self.num_masu_width = 8
        self.num_masu_hight = 8
        self.size_masu_width = 20
        self.size_masu_hight = 20

        self.size_distance = 3

        self.field = [8][8]

        self.masu_color = (0,255,0)

    def show_field():

        pygame.draw.rect(main.screen,masu_color)
        

