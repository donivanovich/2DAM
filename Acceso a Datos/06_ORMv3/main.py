from Repositories.CustomerRepository import CustomerRepository
from Repositories.RentalRepository import RentalRepository
from Repositories.FilmRepository import FilmRepository
from Repositories.InventoryRepository import InventoryRepository

def main():
    while True:
        opcion:int = int(input("Introduce 1-6: "))

        if opcion == 1:
            print("Alta de nuevo usuario")
            altaNuevoUsuario()
        elif opcion == 2:
            print("Alquilar pelicula (por nombre)")
            alquilarPelicula()
        elif opcion == 3:
            print("Devolver pelicula")
            devolverPelicula()
        elif opcion == 4:
            print("Crear nueva pelicula")
            crearNuevaPelicula()
        elif opcion == 5:
            print("Dar de alta nueva unidad de pelicula")
        elif opcion == 6:
            print("Saliendo del programa, muchas gracias")
            darAltaNuevaUnidadPelicula()
            break
        else:
            print("Opción no válida, prueba de nuevo")


def altaNuevoUsuario():#Hecho
    nombre = input("Introduce el nombre y apellido: ")
    nombre = nombre.split()

    if(len(nombre) < 2):
        print("ERROR")
        return

    if(len(nombre) != 2):
        first_name = " ".join([nombre[0], nombre[1]])
        last_name = nombre[2]

    else: 
        first_name = nombre[0]
        last_name = nombre[1]

    customersList = CustomerRepository.getCustomerByFullName(first_name, last_name)
    
    if(len(customersList) == 0):
        customer = CustomerRepository.createNewCustomer(
            first_name,
            last_name, 
            1,
            1
        )
        print(f"Se ha dado de alta el siguiente Usuario: {customer}")
    else:
        print("El usuario ya existe:", customersList[0])

def alquilarPelicula():#Hecho
    nombre = input("Introduce el nombre y apellido: ")
    nombre = nombre.split()

    if(len(nombre) < 2):
        print("ERROR")
        return

    if(len(nombre) != 2):
        first_name = " ".join([nombre[0], nombre[1]])
        last_name = nombre[2]

    else: 
        first_name = nombre[0]
        last_name = nombre[1]

    customersList = CustomerRepository.getCustomerByFullName(first_name, last_name)
    
    if(len(customersList) == 0):
        customerId = CustomerRepository.createNewCustomer(
            first_name,
            last_name, 
            1,
            1
        )

    else :
        customerId = customersList[0].customer_id 
    
    rentals = RentalRepository.getRentalsByCustomerId(customerId)

    for rental in rentals:
        print(rental.rental_id , " ", rental.inventory_id , " " , rental.return_date)

    option = input("Realizar nuevo alquiler ? (1 si, 2 no) ")

    if(option == "1"):
        filmId = False

        while filmId == False:
            filmToSearch = input("Introduce el nombre de la pelicula a buscar:  ")
            filmId = FilmRepository.getFilmByName(filmToSearch)

            if(len(filmId) == 0):
                filmId = False
                print("La pelicula no existe. ")

            else:
                filmId = filmId[0].film_id

        inventoryId = InventoryRepository.GetFirstFilmInventoryById(filmId)
        inventoryId = inventoryId.inventory_id

        print(RentalRepository.createRental(customerId, inventoryId, 1))

def devolverPelicula():
    nombre = input("Introduce el nombre y apellido: ")
    nombre = nombre.split()

    if(len(nombre) < 2):
        print("ERROR")
        return

    if(len(nombre) != 2):
        first_name = " ".join([nombre[0], nombre[1]])
        last_name = nombre[2]

    else: 
        first_name = nombre[0]
        last_name = nombre[1]
    
    customersList = CustomerRepository.getCustomerByFullName(first_name, last_name)
    
    if(len(customersList) == 0):

        customerId = CustomerRepository.createNewCustomer(
            first_name,
            last_name, 
            1,
            1
        )

    filmToSearch = input("Introduce el nombre de la pelicula a buscar:  ")

    filmId = FilmRepository.getFilmByName(filmToSearch)

    if(len(filmId) == 0):
        filmId = False
        print("La pelicula no existe. ")

    else:
        filmId = filmId[0].film_id

    inventoryId = InventoryRepository.GetFirstFilmInventoryById(filmId)
    inventoryId = inventoryId.inventory_id

    RentalRepository.deleteRental(customerId, filmToSearch)

def crearNuevaPelicula():
    titulo = input("Introduce titulo de la nueva pelicula: ")

    nuevo_film  = FilmRepository.createNewFilm(titulo)

    print("Película creada:", nuevo_film)

def darAltaNuevaUnidadPelicula():
    pass

main()