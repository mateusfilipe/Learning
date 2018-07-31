#SayOurNames.py
nome = input("Qual seu nome? ")
while nome!="":
    for x in range(100):
        print(nome, end = " ")
        print()
    nome = input("Digite outro nome, ou aperte 'ENTER' para sair: ")
print("Vlw por usar!")
