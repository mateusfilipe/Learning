#ColorSpiral.py
import turtle
t = turtle.Pen()
turtle.bgcolor("black")
#Escolhendo número de lados (De 2 a 6):
sides = eval(input("Digite o número de lados: "))
colors = ["red","yellow","blue","orange","green","purple","pink","white","dark green","salmon","gray"]
for x in range(360):
    t.pencolor(colors[x%sides])
    t.forward(x*3/sides+x)
    t.left(1480/sides+1)
    t.width(x*sides/200)
