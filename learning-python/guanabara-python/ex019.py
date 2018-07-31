#Mateus Filipe - ex019
import random

aluno1 = input('Qual o nome do primeiro aluno? ')
aluno2 = input('Qual o nome do segundo aluno? ')
aluno3 = input('Qual o nome do terceiro aluno? ')
aluno4 = input('Qual o nome do quarto aluno? ')

alunos = [aluno1, aluno2, aluno3, aluno4]
escolhido = random.choice(alunos)

print('O aluno escolhido foi {}'.format(escolhido))
