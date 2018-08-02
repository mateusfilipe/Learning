#Mateus Filipe - ex035

a = float(input('Digite o valor de [a]: '))
b = float(input('Digite o valor de [b]: '))
c = float(input('Digite o valor de [c]: '))

if ((b-c) < a and a < b+c) and ((a-c) < b and b < a+c) and((a-b) < c and c < a+b):
    print('É possível formar um triângulo!')
else:
    print('Não e possível formar um triângulo!')
