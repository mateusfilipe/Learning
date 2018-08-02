#Mateus Filipe - ex031

dist = float(input('Digite a distância percorrida: '))
if dist <= 200:
    preço  = 0.5*dist
else:
    preço = 0.45*dist
print('Preço: R${}'.format(preço))
