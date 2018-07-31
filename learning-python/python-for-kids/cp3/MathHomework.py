#DeverDeMatemática
problema = input("Digite a conta que quer realizar ou 'sair' para sair: ")
while(problema !="sair"):
    print("A resposta de ", problema, " é: ", eval(problema))
    problema = input("Digite outra conta ou 'sair' para sair: ")
