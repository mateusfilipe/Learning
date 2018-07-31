#SpiralMyName.py
import turtle
t = turtle.Pen()
turtle.bgcolor("black")
colors = ["red", "yellow", "blue", "green"]
nome = turtle.textinput("Digite seu nome","Qual seu nome?")
for x in range(100):
    t.pencolor(colors[x%4])
    t.penup()
    t.forward(x*4)
    t.pendown()
    t.write(nome, font = ("Comic Sans", int( (x+4)/4), "bold"))
    t.left(92)
