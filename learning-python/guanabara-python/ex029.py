#Mateus Filipe - ex029

velocidade = float(input('Digite a velocidade que estava: '))

if velocidade > 80:
    multa = (velocidade - 80)*7
    print('Você foi multado no valor de R${:.2f}'.format(multa))
else:
    print('Você não foi multado!')
