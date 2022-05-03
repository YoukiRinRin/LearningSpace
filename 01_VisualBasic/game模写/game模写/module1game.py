Import os, sys
from random import randint, choice
from math import sin, cos, radians

import pygame

from utils import Timer
from vec2d import vec2d
from widgets import *

class Game(object):
    print "Setting global GAme params."
    BG_TILE_ING = 'Images/wood2.png'
    SCREEN_WIDTH.SCREEN_HIFHT = 580,500
    GRID_SIZE = 20
    FILED_SIZE = 400,400

    def __init__(self):
        pygame.init()
        print "Pygame started."

        self.screen = pygame,display.set_mode(
            (self.SCREEN_WIDTH, self.SCREEN_HEIGHT), 0, 32)
        self.tile_img = pygame.image.load(self.BG_TILE_ING).covert_alpha()
        self.tile_img_rect = self.tile_img.get_rect()

        print"Configuring tboard MEssageBoard params"
        self.tboard_text = ['This is a test ']
