class Persona: # Clase

    def __init__(self, nombre:str, edad:int = 18) -> None:
        self.nombre = nombre
        self.edad = edad
        
    def saludar(self) -> None:
        print(f'Hola, soy {self.nombre}!')

    def __str__(self) -> str:
        return f'{self.nombre} - {self.edad}'
    
    def __repr__(self) -> str:
        return self.nombre

class Empleado(Persona): # Herencia
    def __init__(self, nombre: str, sueldo:int) -> None:
        super().__init__(nombre, 20)
        self.sueldo:int = sueldo
    
    def __str__(self) -> str:
        return super().__str__() + f' --> Sueldo: {self.sueldo}'

class Alumno(Persona): # Herencia
    def __init__(self, nombre: str, aprobado:bool = False) -> None:
        super().__init__(nombre, 20)
        self.aprobado:bool = aprobado
    
    def __str__(self) -> str:
        return super().__str__() + f' --> Aprobado: {self.aprobado}'

class Profesor(Empleado):
    def __init__(self, nombre: str) -> None:
        super().__init__(nombre, 1000)
        self.alumnos:list[Alumno] = []
    
    def add_alumno(self, alumno:Alumno) -> None:
        self.alumnos.append(alumno)

alice = Alumno('Alice', True)
bob = Profesor('Bob')
bob.add_alumno(alice)
#alice.saludar()
personas:list[Persona] = [alice, bob]
#print(alice)
print(alice)
print(bob.alumnos)

