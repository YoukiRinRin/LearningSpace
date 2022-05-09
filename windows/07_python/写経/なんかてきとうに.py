from sympy import * 
import re

x = Symbol('x')
y = Symbol('y')


print(x + y + x - y)
print(x + x * x)
print((x+y)*2)

print(expand(x + y)**3)

#p199
#num_regex = re.compile(r'\d\d\d-\d\d\d^\d\d\d\d')
#m = num_regex.search('携帯: 999-555-6666　自宅:001-100-9292')
#m.group()
s = 'aaa@xxx.com'
m = re.match(r'[a-z]+@[a-z]+\.[a-z]+', s)
print(m)

print(type(m))

print(m.start())
print(m.end())
print(m.span())

print(m.start())
print(m.end())
print(m.span())

print(m.group())

print(type(m.group()))


print(m.group(0))
print(m.group(1))
print(m.group(2))
print(m.group(3))
print(m.group(4))

if re.match('[0-9]',s):
    print('match')
else:
    print('no match')

number = [number for number in range(1,10) if number % 2 == 0]
print(number)


m = re.match('[0-9]*',s)

p = re.compile('[a-z]+')
print(p.fullmatch('abc'))
print(p.fullmatch('abc123'))

s = 'abc'


amount_dict = {"hight":1.2,"normal":1.0,"low":0.8}

def main():


a = [1,2]
b = a

b[0] = 3
print("Check-1")
print(a)
print(b)

a1 = [1,2]
b1 = a1
a1[0] = 5
print(b1)
print(a1)

a2 = [1,2]
b2 = a2
b3 = [6,7]


class AbstractPizzaFactory:
    def __init__(self,pizza_fuctory,amount_str="normal"):
        self.factory = pizza_fuctory

    def make_pizza(self,amount_str):
        amount = amount_dict[amount_str]
        self.pizza_materials = []
        self.pizza_materials.append(self.factory.add_dough(amount))

    

    