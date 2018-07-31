#Mateus Filipe - ex03
n1 = float(input('Digite a primeira nota: '))
p1 = int(input('Digite o peso da primeira nota: '))

n2 = float(input('Digite a segunda nota: '))
p2 = int(input('Digite o peso da segunda nota: '))

n3 = float(input('Digite a terceira nota: '))
p3 = int(input('Digite o peso da terceira nota: '))

mediaP = ((n1*p1)+(n2*p2)+(n3*p3))/3

print('Média ponderada = {:.3f}'.format(mediaP))


