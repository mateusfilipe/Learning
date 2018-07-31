#ColorSpiralInput.py
import turtle #Importando comandos gráficos da linguagem Logo

t = turtle.Pen()
turtle.bgcolor("black")
cores = ["red", "yellow", "blue", "green", "orange", "purple", "white", "gray"]
lados = int(turtle.numinput("Número de lados",
                            "Quantos lados você quer? (1 - 8)", 4 , 1, 8))
for x in range(360):
    t.pencolor(cores[x % lados])
    t.forward(x * 3 / lados + x)
    t.left(360 / lados + 1)
    t.width(x * lados / 200)
    t.speed(10)
