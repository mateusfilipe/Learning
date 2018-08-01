#Mateus Filipe - ex026
frase = input('Digite qualquer frase: ').upper()
print('A letra [A] aparece {} vezes'.format(frase.count('A')))
print('E aparece primeiro na posição {}'.format(frase.find('A')))
print('E aparece por ultimo na posição {}'.format(frase.rfind('A')))
