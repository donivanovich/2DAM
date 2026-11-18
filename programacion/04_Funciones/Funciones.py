def sumar(a:int, b:int, *c:int) -> int:                               
    return a + b + sum(c)                                                   

def restar(a:int, b:int) -> int:
    return a - b

def dividir(a:int | float, b:int | float) -> float:
    if b == 0 or a == 0:
        raise ZeroDivisionError('No se puede dividir entre 0.')
    return a/b

def mult(a:int, b:int = 2) -> int:
    return a * b

print(sumar(1, 2))

def crear_persona(**datos) -> None:
    print(datos)

crear_persona(nombre='Pepe', edad=12)