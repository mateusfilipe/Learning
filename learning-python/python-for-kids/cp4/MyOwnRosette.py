#MyOwnRosette.py
import turtle
t = turtle.Pen()
nCirculos = int(turtle.numinput("Quantos cículos você deseja?",1))

for x in range(nCirculos):
    t.circle(100)
    t.left(360/nCirculos)
    t.speed(100)
