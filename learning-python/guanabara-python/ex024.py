#Mateus Filipe - ex024
cidade = input('Digite o nome da sua cidade: ')
cidadeS = cidade.split()
if 'SANTO' in cidadeS[0].upper():
    print('Sua cidade começa com Santo')
else:
    print('Sua cidade não começa com Santo')
