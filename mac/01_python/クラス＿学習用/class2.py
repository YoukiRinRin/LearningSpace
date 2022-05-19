class MyClass():
    def __init__(self,message):
        self.value = message
    


myinstance = MyClass("Hello!")
print(myinstance.value)


class Example():

    def __init__(self,a,b,c):
        self.num1 = a
        self.num2 = b
        self.num3 = c

    def print_tot(self):
        tot = self.num1+self.num2+self.num3
        print(tot)


myinstance = Example(1,2,3)
myinstance.print_tot()

class Oya():
    def oya_func(sekf):
        print("I am OYA")

class Kodomo(Oya):
    def kodomo_func(self):
        print("I am Kodomo")

k = Kodomo()

k.oya_func()
k.kodomo_func()

class MyClass:
    user_name = None
    age = None
    def say(self):
        print("名前:{0},年齢:{1}".format(self.user_name,self.age))

    
user1 = MyClass()
user1.user_name="山田"
user1.age = 20

user2 = MyClass()
user2.user_name = "鈴木"
user2.age = 40

user1.say()
user2.say()

