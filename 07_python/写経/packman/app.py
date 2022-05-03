import pyxel

class pacman:
    def __init__(self):

        self.dot_x = 8
        self.dot_y = 8

        self.x_change_quantity = 0
        self.y_change_quantity = 0

        self.vectol = 0
        
        self.title_x = 1
        self.title_y = 1

        self.plot_pacman_x_coordinate = 0

        self.score = 0

        pyxel.init(128,140,caption="パックマンぽいゲーム",fps=25)

class App:
    def __init__(self):
        pyxel.init(128,128,caption="パックマンぽいゲーム,fps=25")

        pyxel.load('pacman.pyxel')

        pyxel.run(self.update,self.drew)

        self.update_tilemap()

    def update(self):

        if pyxel.btnp(pyxel.KEY_Q):
            pyxel.quit()

    def draw(self):
        pyxel.cls(0)
        self.tilemap_draw()



    def update_tilemap(self):
        if self.tilemap.state.get(self.pacman.tile_x,self.pacman.title_y) == 65:
            self.pacman.score += 30
        
        elif self.update_tilemap.get(self.pacman.tile_x,self.pacman.tiley) == 64:
            self.pacman.score += 100

    pyxel.tilemap(0).set(self.pacman.tile_x,self.pacman.tile_y,5,refimg = 0)



    def upsate_packman_state(self):

        if self.packman.dot_x % 8 == 0 and self.packman.dot_y % 8 == 0:
            if self.tilemap_state.get(self.pacman.tile_x + self.pacman.x_change_quantity,self.pacman.tile_y + self.pacman.y_cange_quantity) == 33:

                self.pacman.x_change_quantity = 0
                self.pacman.y_change_quantity = 0

        elif pyxel.btn(pyxel.KEY_W):

            if self.tilemap_state.get(self.pacman.tile_x,self.pacman.tile_y - 1) == 5 or self.tilemap_state.get(self.pacman.tile_x,self.pacman.tile_y -1) == 64 or self.tilemap_state.get(self.pacman.tile_x,self.pacman.tile_y -1) == 65:

        elif pyxel.btn(pyxel.KEY_S):

        elif pyxel.btn(pyxel.KEY_D):

        elif pyxel.btn(pyxel.KEY_A):

        self.pacman.tile_x += self.pacman.x_cahge_quantity
        self.pacman.tile_y += self.pacman.x_cahge_quantity

        def draw_pacman(self):

            if self.pacman.x_change_quantity == 0 and self.pacman.y_change_quantity == 0:
                pass
            else:
                if pyxel.frame_count % 2 == 0:
                    self.pacman.plot_pacman_x_coodinate = 0
                elif self.pacman.vectol == 1:
                    self.pacman.plot_pacman_x_coodinate = 8
                elif self.pacman.vectol == 2:
                    self.pacman.plot_pacman_x_coodinate = 16
                elif self.pacman.vectol == 3:
                    self.pacman.plot_pacman_x_coodinate = 24
                elif self.pacman.vectol == 4:
                    self.pacman.plot_pacman_x_coodinate = 32

        pyxel.blt(self.pacman.dot_x,self.pacman.dot_y,0,self.pacman.plot_pacman_x_coordinate,0,8,8)

    def tilemap_draw(self):
        base_x =0
        base_y = 0
        tm = 0
        u = 0
        v = 0
        w = 0
        h = 16
        h = 16

        pyxel.bltm(base_x,base_y,tm,u,v,w,h)




App()