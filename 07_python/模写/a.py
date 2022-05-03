class SimpleDate:
    a = 0
    b = 0

    def sum(self):
        return self.a + self.b

    def set(self,a,b):
        self.a = a
        self.b = b


data1 = SimpleDate()
data2 = SimpleDate()

data1.set(1,2)
print(data1.sum())

import pygame
SCREEN_WIDTH = 480
SCREEN_HEIGHT = 800

TYPE_SMALL = 1
TYPE_MIDDLE = 2
TYPE_BIG = 3

class Block(pygame.sprite.Sprite):
    def __init__(self,bullet_img,init_pos):
        pygame.sprite.sprite.__init__(self)
        self.img = bullet_img
        self.rect = self.imagel.get_rect()
        
        self.rect.left = SCREEN.left + x * self.rect.width
        self.rect.top = SCREEN.top + y * self.rect.height

class Score():
    def __init__(self,x,y):
        self.sysfont = pygame.font.SysFont(None,20)
        self.score = 0
        (self.x,self.u)
        def draw(self,screen):
            img = self.sysfont.render("SCORE:"+str(self.score),True,(255,255,250))
            screen.blit(img,(self.x,self.y))
        def add_score(self,x):
            self.score += x

    def main():
        pygame.init()
        screen = pygame.display.set_mode(SCREEN.size)
        Ball.paddle_sound = pygame.mixer.Sound()
        BAll.block_sound = pygame.mixer.sound()
    
