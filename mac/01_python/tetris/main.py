field = [[2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,0,0,0,0,0,0,0,0,0,0,2],
        [2,2,2,2,2,2,2,2,2,2,2,2]]


FIELD_WIDTH = 12
FIELD_HEIGHT = 21


mino = "■"

mino_I = [[0,1,0,0],
          [0,1,0,0],
          [0,1,0,0],
          [0,1,0,0]]

mino_pos_width = 4
mino_pos_height = 4

MINO_SIZE_H = 4
MINO_SIZE_W = 4

MINO_WIDTH_START = 0
MINO_HEIGHT_START = 0

idou_houkou = ''

while(1):

#    for ix in range(MINO_SIZE_W):
 #       field[mino_pos_height - 1][ix] = 0 

    #ミノの軌跡を消す
    for ix_w in range(MINO_SIZE_W):
        if field[mino_pos_height - 1][mino_pos_width + ix_w] == 2:
            break
        if field[mino_pos_height - 1][mino_pos_width + ix_w] == 1:
            field[mino_pos_height - 1][mino_pos_width + ix_w] = 0
    
    '''
    #ミノを描画する
    for ix_h in range(MINO_SIZE_H):
       for ix_w in range(MINO_SIZE_W):
            if field[mino_pos_height+ix_h][mino_pos_width+ix_w] == 1:
                field[mino_pos_height+ix_h][mino_pos_width+ix_w] = 1
            elif mino_I[ix_h][ix_w] == 0:
                 continue
            else:
                field[mino_pos_height+ix_h][mino_pos_width+ix_w] = mino_I[ix_h][ix_w]
    '''


    #左の軌跡を消す
    if idou_houkou == '右':
        for ix_h in range(MINO_SIZE_H):
            if field[mino_pos_height + ix_h][mino_pos_width ] == 1:
                field[mino_pos_height + ix_h][mino_pos_width ] = 0
    #右の軌跡を消す
    elif idou_houkou == '左':         
        for ix_h in range(MINO_SIZE_H):
            if field[mino_pos_height + ix_h][mino_pos_width + 2] == 1:
                field[mino_pos_height + ix_h][mino_pos_width+2] = 0

    
    #ミノ描画
    for ix_h in range(MINO_SIZE_H):
        for ix_w in range(MINO_SIZE_W):
            if mino_I[ix_h][ix_w] == 1 and field[mino_pos_height + ix_h][mino_pos_width] == 0:
                field[mino_pos_height + ix_h][mino_pos_width + ix_w] = mino_I[ix_h][ix_w]
    
    #フィールドを生成する
    for ix in range(FIELD_HEIGHT):
        for ix2 in range(FIELD_WIDTH):
            print(field[ix][ix2],end="")
        print()

    get_key = input()

    flg_check_next = 0

    if get_key == 's':
        mino_pos_height = 20
    elif get_key == 'd':
        
        for ix in range(mino_pos_width):
            if field[mino_pos_height][mino_pos_width + 2] == 2:
                flg_check_next = 1
        if flg_check_next == 0:
            mino_pos_width += 1
        flg_check_next == 0


        idou_houkou = '右'


    elif get_key == 'a':
        for ix in range(mino_pos_width):
            if field[mino_pos_height][mino_pos_width] == 2:
                flg_check_next = 1

        if flg_check_next == 0:
            mino_pos_width -= 1
        flg_check_next == 0

        idou_houkou = '左'

    mino_pos_height = mino_pos_height + 1

    




    




       
       







