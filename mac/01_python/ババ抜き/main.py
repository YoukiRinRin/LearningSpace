from asyncio import selector_events
from itertools import accumulate
from re import  A
import pygame


class card:
    mark = ""
    number = 0
    index_number = 0
    image_back = '/image/card_back.png'

    pair_ix_num = {1:1,2:2,3:3,4:4,5:5,6:6,7:7,8:8,9:9,10:10,11:11,12:12,13:13,
                    14:1,15:2,16:3,17:4,18:5,19:6,20:7,21:8,22:9,23:10,24:11,25:12,26:13,
                    27:1,28:2,29:3,30:4,31:5,32:6,33:7,34:8,35:9,36:10,37:11,38:12,39:13,
                    40:1,41:2,42:3,43:4,44:5,45:6,46:7,47:8,48:9,49:10,50:11,51:12,52:13}
    pair_ix_mark = {1:"H",2:"H",3:"H",4:"H",5:"H",6:"H",7:"H",8:"H",9:"H",10:"H",11:"H",12:"H",13:"H",
                    14:"D",15:"D",16:"D",17:"D",18:"D",19:"D",20:"D",21:"D",22:"D",23:"D",24:"D",25:"D",26:"D",
                    27:"S",28:"S",29:"S",30:"S",31:"S",32:"S",33:"S",34:"S",35:"S",36:"S",37:"S",38:"S",39:"S",
                    40:"C",41:"C",42:"C",43:"C",44:"C",45:"C",46:"C",47:"C",48:"C",49:"C",50:"C",51:"C",52:"C"}

    
    path_image = "/image"
    path_image_heart = path_image + "/heart"
    path_image_diamond = path_image + "/diamond"
    path_image_clover = path_image + "/clover"
    path_image_spade = path_image + "/spade"

    pair_ix_image = {1:path_image_heart+'/card_heart_01.png',
                     2:path_image_heart+'/card_heart_02.png',
                     3:path_image_heart+'/card_heart_03.png',
                     4:path_image_heart+'/card_heart_04.png',
                     5:path_image_heart+'/card_heart_05.png',
                     6:path_image_heart+'/card_heart_06.png',
                     7:path_image_heart+'/card_heart_07.png',
                     8:path_image_heart+'/card_heart_08.png',
                     9:path_image_heart+'/card_heart_09.png',
                     10:path_image_heart+'/card_heart_10.png',
                     11:path_image_heart+'/card_heart_11.png',
                     12:path_image_heart+'/card_heart_12.png',
                     13:path_image_heart+'/card_heart_13.png',
                     14:path_image_diamond+'card_diamond_01.png',
                     15:path_image_diamond+'card_diamond_02.png',
                     16:path_image_diamond+'card_diamond_03.png',
                     17:path_image_diamond+'card_diamond_04.png',
                     18:path_image_diamond+'card_diamond_05.png',
                     19:path_image_diamond+'card_diamond_06.png',
                     20:path_image_diamond+'card_diamond_07.png',
                     21:path_image_diamond+'card_diamond_08.png',
                     22:path_image_diamond+'card_diamond_09.png',
                     23:path_image_diamond+'card_diamond_10.png',
                     24:path_image_diamond+'card_diamond_11.png',
                     25:path_image_diamond+'card_diamond_12.png',
                     26:path_image_diamond+'card_diamond_13.png',
                     27:path_image_spade+'card_spade01_.png',
                     28:path_image_spade+'card_spade02_.png',
                     29:path_image_spade+'card_spade03_.png',
                     30:path_image_spade+'card_spade04_.png',
                     31:path_image_spade+'card_spade05_.png',
                     32:path_image_spade+'card_spade06_.png',
                     33:path_image_spade+'card_spade07_.png',
                     34:path_image_spade+'card_spade08_.png',
                     35:path_image_spade+'card_spade09_.png',
                     36:path_image_spade+'card_spade10_.png',
                     37:path_image_spade+'card_spade11_.png',
                     38:path_image_spade+'card_spade12_.png',
                     39:path_image_spade+'card_spade13_.png',
                     40:path_image_clover+'card_clover01.png',
                     41:path_image_clover+'card_clover02.png',
                     42:path_image_clover+'card_clover03.png',
                     43:path_image_clover+'card_clover04.png',
                     44:path_image_clover+'card_clover05.png',
                     45:path_image_clover+'card_clover06.png',
                     46:path_image_clover+'card_clover07.png',
                     47:path_image_clover+'card_clover08.png',
                     48:path_image_clover+'card_clover09.png',
                     49:path_image_clover+'card_clover10.png',
                     50:path_image_clover+'card_clover11.png',
                     51:path_image_clover+'card_clover12.png',
                     52:path_image_clover+'card_clover13.png'}


    def __init__(self,mark,number,index_number,image_face):
        self.mark = mark
        self.number = number
        self.index_number = index_number
        self.image_face = image_face
        
        self.index_and_number = {self.index_number:self.number}
        self.index_and_mark = {self.index_number:self.mark}

    def back_card_kind(index_num):
        print(1)



class player:
    def __init__(self,name):
        self.name = name 
        self.hand=[]
        self.turn_oder = 0

class deck:
    num_deck = 52
    
    deck_index = [1,2,3,4,5,6,7,8,9,10,
                11,12,13,14,15,16,17,18,19,20,
                21,22,23,24,25,26,27,28,29,30,
                31,32,33,34,35,36,37,38,39,40,
                41,42,43,44,45,46,47,48,49,50,
                51,52]

    

    



    def shuffle():

        print(deck.card_h_1.mark)


card = card

"""
path_image = "/image"
path_image_heart = path_image + "/heart"
path_image_diamond = path_image + "/diamond"
path_image_clover = path_image + "/clover"
path_image_spade = path_image + "/spade"


card_h_1 =  card("H",1,1,path_image_heart+'/card_heart_01.png')
card_h_2  = card("H",2,2,path_image_heart+'/card_heart_02.png')
card_h_3  = card("H",3,3,path_image_heart+'/card_heart_03.png')
card_h_4  = card("H",4,4,path_image_heart+'/card_heart_04.png')
card_h_5  = card("H",5,5,path_image_heart+'/card_heart_05.png')
card_h_6  = card("H",6,6,path_image_heart+'/card_heart_06.png')
card_h_7  = card("H",7,7,path_image_heart+'/card_heart_07.png')
card_h_8  = card("H",8,8,path_image_heart+'/card_heart_08.png')
card_h_9  = card("H",9,9,path_image_heart+'/card_heart_09.png')
card_h_10  =card("H",10,10,path_image_heart+'/card_heart_10.png')
card_h_J  = card("H",11,11,path_image_heart+'/card_heart_11.png')
card_h_Q  = card("H",12,12,path_image_heart+'/card_heart_12.png')
card_h_K  = card("H",13,13,path_image_heart+'/card_heart_13.png')
card_d_1 =  card("D",1,14,path_image_diamond+'/card_diamond_01.png')
card_d_2  = card("D",2,15,path_image_diamond+'/card_diamond_02.png')
card_d_3  = card("D",3,16,path_image_diamond+'/card_diamond_03.png')
card_d_4  = card("D",4,17,path_image_diamond+'/card_diamond_04.png')
card_d_5  = card("D",5,18,path_image_diamond+'/card_diamond_05.png')
card_d_6  = card("D",6,19,path_image_diamond+'/card_diamond_06.png')
card_d_7  = card("D",7,20,path_image_diamond+'/card_diamond_07.png')
card_d_8  = card("D",8,21,path_image_diamond+'/card_diamond_08.png')
card_d_9  = card("D",9,22,path_image_diamond+'/card_diamond_09.png')
card_d_10  =card("D",10,23,path_image_diamond+'/card_diamond_10.png')
card_d_J  = card("D",11,24,path_image_diamond+'/card_diamond_11.png')
card_d_Q  = card("D",12,25,path_image_diamond+'/card_diamond_12.png')
card_d_K  = card("D",13,26,path_image_diamond+'/card_diamond_13.png')
card_s_1 =  card("S",1,27,path_image_spade+'/card_spade_01.png')
card_s_2  = card("S",2,28,path_image_spade+'/card_spade_02.png')
card_s_3  = card("S",3,29,path_image_spade+'/card_spade_03.png')
card_s_4  = card("S",4,30,path_image_spade+'/card_spade_04.png')
card_s_5  = card("S",5,31,path_image_spade+'/card_spade_05.png')
card_s_6  = card("S",6,32,path_image_spade+'/card_spade_06.png')
card_s_7  = card("S",7,33,path_image_spade+'/card_spade_07.png')
card_s_8  = card("S",8,34,path_image_spade+'/card_spade_08.png')
card_s_9  = card("S",9,35,path_image_spade+'/card_spade_09.png')
card_s_10  =card("S",10,36,path_image_spade+'/card_spade_10.png')
card_s_J  = card("S",11,37,path_image_spade+'/card_spade_11.png')
card_s_Q  = card("S",12,38,path_image_spade+'/card_spade_12.png')
card_s_K  = card("S",13,39,path_image_spade+'/card_spade_13.png')
card_c_1 =  card("C",1,40,path_image_clover+'/card_clover_01.png')
card_c_2  = card("C",2,41,path_image_clover+'/card_clover_02.png')     
card_c_3  = card("C",3,42,path_image_clover+'/card_clover_03.png')
card_c_4  = card("C",4,43,path_image_clover+'/card_clover_04.png')
card_c_5  = card("C",5,44,path_image_clover+'/card_clover_05.png')
card_c_6  = card("C",6,45,path_image_clover+'/card_clover_06.png')
card_c_7  = card("C",7,46,path_image_clover+'/card_clover_07.png')
card_c_8  = card("C",8,47,path_image_clover+'/card_clover_08.png')
card_c_9  = card("C",9,48,path_image_clover+'/card_clover_09.png')
card_c_10  =card("C",10,49,path_image_clover+'/card_clover_10.png')
card_c_J  = card("C",11,50,path_image_clover+'/card_clover_11.png')
card_c_Q  = card("C",12,51,path_image_clover+'/card_clover_12.png')
card_c_K  = card("C",13,52,path_image_clover+'/card_clover_13.png')
"""










player1 = player('a')
player2 = player('b')


deck1 = deck




for ix in range(deck1.num_deck):

    if ix % 2 == 1:
        player1.hand.append(ix)
    elif ix % 2 == 0:
        player2.hand.append(ix)



print("player1の手札" ,player1.hand)
print("player2の手札" ,player2.hand)


print(player1.name)
print(player2.name)

check_same = []

aa = []

"""
for a in player1.hand:
    for b in player1.hand:
        if card.pair_ix_num[a] == card.pair_ix_num[b]:
            print("True",end='')
        else:
            print("false",end='')
        print(card.pair_ix_num[a],end='')
        print(card.pair_ix_num[b])
"""
for a in range(len(player1.hand)):
    print("a:",a)
    t=1
    for b in range(len(player1.hand)):
        if t == 1:
            continue
        print("b",b)
        print("player1.hand",card.pair_ix_num[player1.hand[a]])
        print("player1.hand",card.pair_ix_num[player1.hand[b]])
        t = 0


for a in range(0,len(player1.hand)):
    t = 1
    #print('a:' ,card.pair_ix_num[player1.hand[a]],end=",")
    for b in range(0,len(player1.hand)):
        if t == 1:
            t=0
            continue
        else:
            if card.pair_ix_num[player1.hand[a]] == card.pair_ix_num[player1.hand[b]]:
                aa.append(b)
        
        for c in range(len(aa)):
            player1.hand.pop(c)
    aa.clear()
  
                


print('aa:',aa)





            
        #    print('b:',card.pair_ix_num[player1.hand[b]],end=",")        
    #print()


#def search_card(index_num):
 



#for card_ix in player1.hand:
    

