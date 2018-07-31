#Mateus Filipe - ex015

kmp = float(input('Digite quantos Km foram rodados: '))
dias = int(input('Digite quantos dias alugou o carro: '))

pk = kmp * 0.15
pd = dias * 60
pTotal = pk + pd

print('Preço pelos dias = R${}'.format(pd))
print('Preço pelos km = R${}'.format(pk))
print('O preço total a ser pago é de R${}'.format(pTotal))
