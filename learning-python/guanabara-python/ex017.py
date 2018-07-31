#Mateus Filipe - ex017
from math import pow,sqrt

catetoOp = float(input('Digite o valor do cateto oposto: '))
catetoAd = float(input('Digite o valor do cateto adjacente: '))

hipotenusa = sqrt(pow(catetoOp,2)+pow(catetoAd,2))

print('O valor da hipotenusa será {}'.format(hipotenusa))
