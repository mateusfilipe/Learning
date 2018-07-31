#Mateus Filipe - ex018
import math

angulo = float(input('Digite um valor para o angulo: '))

seno = math.sin(math.radians(angulo))
coseno = math.cos(math.radians(angulo))
tangente = math.tan(math.radians(angulo))

print('Seno: {:.3f}'.format(seno))
print('Coseno: {:.3f}'.format(coseno))
print('Tangente: {:.3f}'.format(tangente))
