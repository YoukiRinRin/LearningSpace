import matplotlib.pyplot as plt

labels = ["A", "B", "C", "D", "E"]
data = [54, 32, 18, 44, 29]
ex = [0.1,0,0,0,0]


labels = ["Python", "Ruby", "Java", "C++", "PHP"]
sizes  = [40, 12, 24, 16, 9]
colors =["navy", "yellow", "blue", "gold", "tomato"]

plt.pie(sizes,labels=labels,colors=colors)
plt.axis("equal")
plt.show()