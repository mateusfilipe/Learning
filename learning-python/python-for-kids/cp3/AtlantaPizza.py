#AtlantaPizza.py - Calculadora de Custo de Pizza

nPizza = eval(input("Quantas pizzas deseja? "))
precoPizza = eval(input("Quanto custa cada pizza? "))
subtotal=nPizza*precoPizza
taxa = 0.08
valorFinal=subtotal+(subtotal*taxa)
print("Custo total será de R$",valorFinal)
print("Incluindo R$",subtotal,"pelas pizzas")
print("R$",taxa*subtotal," de taxa")
