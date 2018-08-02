#Mateus Filipe - ex034

salario = float(input('Digite seu salario: R$'))

if salario > 1250:
    aumento = salario * (10 /100)
else:
    aumento = salario * (15/100)
print('Seu aumento foi de R${}, agora seu salário é R${}'.format(aumento,salario+aumento))
