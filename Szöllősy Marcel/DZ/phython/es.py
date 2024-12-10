nev = input("Adj meg egy nevet!")
szam = input("Adj meg egy számot!")

def kiiras2():
    nev3 = input("Adj meg egy nevet! ")
    szam3 = input("Adj meg egy számot! ")
    return szam3, nev3

def kiiras(nev1, szam1):
    print(nev1 + ' * ' + szam1 + ' ' + kiiras2()[0] + ' ' + kiiras2()[1])
    kiiras2()

kiiras(nev, szam)