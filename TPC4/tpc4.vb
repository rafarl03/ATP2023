import random

def criarLista(N):
    return [random.randint(1,100) for x in range(N)]

def lerLista(N):
    return [int(input("Escolha " +str(N)+ " números inteiros")) for x in range(N)]

def soma(lista):
    return sum(lista)

def media(lista):
    if len(lista) > 0:
        return sum(lista) / len(lista)
    else:
        return 0

def maior(lista):
    res= lista[0]
    for x in lista:
        if x > res:
            res=x
    return res

def menor(lista):
    res= lista[0]
    for x in lista:
        if x < res:
            res=x
    return res

def ordenadaCrescente(lista):
    for x in range(len(lista)-1):
        if lista[x] > lista[x+1]:
            return "Não"
    return "Sim"

def ordenadaDecrescente(lista):
    for x in range(len(lista)-1):
        if lista[x] < lista[x+1]:
            return "Não"
    return "Sim"

def procurarElemento(lista, elemento):
    for x in range(len(lista)):
        if x == lista[elemento]:
            return x 
    return -1

def menu(N):
    listaInicial = []
    resposta1 = input("(1) Criar Lista (2) Ler Lista (3) Soma (4) Média (5) Maior (6) Menor (7) Está ordenada por ordem crescente? (8) Está ordenada por ordem decrescente? (9) Procura um elemento (0) Sair")
    #resposta2 = input("(1) Criar Lista (2) Ler Lista (3) Soma (4) Média (5) Maior (6) Menor (7) Está ordenada por ordem crescente? (8) Está ordenada por ordem decrescente? (9) Procura um elemento (0) Sair")
    if resposta1 == "1":
        listaInicial = criarLista(N)
    if resposta1 == "2":
        listaInicial = lerLista(N)
    if resposta1 == "3":
        soma(lista)
    if resposta1 == "4":
        media(lista)
    if resposta1 == "5":
        maior(lista)
    if resposta1 == "6":
        menor(lista)
    if resposta1 == "7":
        ordenadaCrescente(lista)
    if resposta1 == "8":
        ordenadaDecrescente(lista)
    if resposta1 == "9":
        Y = procurarElemento(lista, elemento)

    return Y

    #if resposta1 == "2":



menu(4)