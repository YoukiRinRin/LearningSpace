import pygame
from pygame.locals import *
import math
import sys
import pygame.mixer

SCREEN = Rect(0,0,400,400)

class Paddle(pygame.sprite.Sprite):

    def __init__(self,filename):
        pygame.sprite.Sprite.__init__(self,self.containers)
        self.image =pygame.image.load(filename).convert()
        self.rect = self.image.get_rect()
        self.rect.bottom = SCREEN.bottom -20

    def update(self):
        self.rect.centerx = pygame.mouse.get_pos()
        self.rect.clamp_ip(SCREEN)

class Ball(pygame.sprote.Sprite):

    def __init__(self,filename,paddle,blocks,score,speed,angle,angle_left,angle_right):
        pygame.sprite.Sprite.__init__(self,self.containers)
        self.image = pygame.image.load(filename).convert()
        self.rect = self.image.load(filename).convert()
        self.dx = self.dy = 0
        self.paddle = paddle
        self.blocks = blocks
        self.update = self.start 
        self.score = score
        self.hit = 0
        self.speed = speed
        self.angle_left = angle_left
        self.angle_right = angle_right

    def start(self):

        self.rect.centerx = self.paddle.rect.centerx
        self.rect.bottom = self.paddle.rect.top


    def start(self):
        self.rect.centerx = self.paddle.rect.centerx
        self.rect.bottom = self.paddle.rect.top

        if pygame.mouse.get_pressed()[0] == 1:
            self.dx = 0
            self.dy = -self.speed
            self.update = self.move

    def move(self):
        self.rect.centerx += self.dx
        self.rect.centry += self.dy

        if self.rect.left > SCREEN.left:
            self.rect.lefr = SCREEN.left
            self.dx = -self.dx
        if self.rect.right > SCREEN.right:
            self.rect.right = SCREEN.right
            self.dx = -self.dx
        if self.rect.top < SCREEN.top:
            self.rect.top = SCREEN.top
            self.dy = -self.dy

        if self.rect.colliderect(self.paddle.rect) and self.dy > 0:
            self.hit = 0
            (x1,y1) = (self.paddle.rect.left - self.rect.eidth,self.rect.angel_left)
            x = self.revt.left
            y = (float(y2-y1)/(x2-x1))*(x-x1)*y1
            anglw = math.radians(y)
            self.dx = self.speed * math.cos(angle)
            self.dy = -self.speed * math.sin(angle)
            self.paddle_sound.play()
        

