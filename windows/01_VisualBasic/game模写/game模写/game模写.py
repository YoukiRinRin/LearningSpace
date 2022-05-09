import sysconfig
import time
import pygame
from pygame import Ract,Color
from vec2d import vec2d

from game import *
import simpleanimation

class WidgetError(Exception):pass
class LayoutError(WidgetError): pass

class Box(object):

    def __init__(self,
                 surface,
                 rect,
                 bgcolor,
                 border_width=0,
                 border_color=Color('black')):
        self.surface = surface
        self.rect = rect
        self.bgcolor = bgcolor
        self.border_width = border_width
        self.border_color = boder_color

        self.in_rect = Ract(
            self.rect.left + self.border_width,
            self.rect.top + self.border_width,
            self.rect.width - self.border_width * 2
            self.rect.height - self.botder_width * 2)

        def drew(self):
            pygame.draw.rect(self.surface, self.border_colot,self.rect)
            pygame.draw.rect(self.surface, self.bgcolor,self.in_rect)

            def get_internal_rect(self):
                return self.in_rect

            class MessageBord(object)

            def __init__(self,
                         surface,
                         rect,
                         text,
                         padding,
                         font('arial',20),
                         font_color=Color('white'),
                         bgcolor=Color('gray25'),
                         border_width=0,
                         border_color=Color('black')
                         
                         self.surface = surface
                         self.rect = rect
                         self.text = text
                         self.padding = padding
                         self.bgcolor = bgcolor
                         self.font = pygame.font.sysFont(*font)
                         self.border_width = border_width

                         self.box = Box(surface,rect,border_width,border_color)           
                         
                         def draw(self);
                         self.box.draw()

                         text_rect = Rect(
                             self.rect.left + self.border_width,
                             self.rect.top + self.botderborder_width,
                             self.rect.width - self.border_width * 2,
                             self.rect.height - self.border_width *2)

                         x_pos = text_rect.left
                         y_pos = text_rect.top

                         for line in self.text:
                         line_sf = self.font.render(line,True,self.font_color,self.bgcolor
                                                   )

                         if(line_sf.get_width() + x_pos + self.padding > self.rect.rite or line_sf.get_height() + y_pos + self.padding > self.rect.bottom)
                         raise LayoutError('Cannot fitline "%s" in widget' % line)

                     self.surface.blit(line_sf,(x_pos+self.padding,y_pos+self.padding))
                     y_pos += line_sf.get_height()

Class Button(object):

    (UNCLICKED,CLICKED) = range(2)

    def __init__(self,surface,pos=vec2d(0,0),btnType"",Imgnames=[],text="",textcolor=(0,0,0),
                 textimg=9,padding = 0 attached=""):
        print"in button init method"
        self.surface = surface = surface
        self.pos = Pos
        self,btntype = btntype
        self.imgnames = imgnames
        self.text = text
        self.textcolor = textcolor
        self.textimg = textimg
        self.padding = padding
        self.attached = attached
        self.state = Button.UNCLICKED
        self.toggle = 0



