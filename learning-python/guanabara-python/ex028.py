#Mateus Filipe - ex028

from random import randint

palpite = int(input('Tente adivinha o número pensado entre 0 e 5: '))

n = randint(0,5)

if palpite == n:
    print('Você acertou!')
else:
    print('Você o errou. O número era {}'.format(n))
