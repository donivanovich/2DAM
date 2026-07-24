from sqlalchemy import (
    create_engine, Column, Integer, String, SmallInteger, ForeignKey, DateTime
)
from sqlalchemy.orm import declarative_base, relationship, Session
from datetime import datetime

Base = declarative_base()

class Customer(Base):
    __tablename__ = 'customer'
    customer_id = Column(Integer, primary_key=True)
    first_name = Column(String(45), nullable=False)
    last_name = Column(String(45), nullable=False)
    address_id = Column(Integer)
    store_id = Column(Integer)
    rentals = relationship("Rental", back_populates="customer")

class Inventory(Base):
    __tablename__ = 'inventory'
    inventory_id = Column(Integer, primary_key=True)
    film_id = Column(Integer, ForeignKey('film.film_id'))
    film = relationship('Film')

class Rental(Base):
    __tablename__ = 'rental'
    rental_id = Column(Integer, primary_key=True)
    rental_date = Column(DateTime)
    inventory_id = Column(Integer, ForeignKey('inventory.inventory_id'))
    customer_id = Column(Integer, ForeignKey('customer.customer_id'))
    customer = relationship("Customer", back_populates="rentals")
    inventory = relationship("Inventory")

class Language(Base):
    __tablename__ = 'language'
    language_id = Column(Integer, primary_key=True)
    name = Column(String)

class Film(Base):
    __tablename__ = 'film'
    film_id = Column(Integer, primary_key=True)
    title = Column(String(255), nullable=False)
    description = Column(String)
    release_year = Column(SmallInteger)
    language_id = Column(Integer, ForeignKey("language.language_id"))
    actors = relationship('Actor', secondary="film_actor")
    language = relationship('Language')

class FilmActor(Base):
    __tablename__ = 'film_actor'
    actor_id = Column(Integer, ForeignKey('actor.actor_id'), primary_key=True)
    film_id = Column(Integer, ForeignKey('film.film_id'), primary_key=True)

class Actor(Base):
    __tablename__ = 'actor'
    actor_id = Column(Integer, primary_key=True)
    first_name = Column(String(45), nullable=False)
    last_name = Column(String(45), nullable=False)
    films = relationship('Film', secondary="film_actor")

def main():
    engine = create_engine(
        'mysql+mysqlconnector://root:1234@localhost:3309/sakila',
        echo=False
    )
    Base.metadata.create_all(engine)

    with Session(engine) as session:
        nombre = input("Nombre del cliente: ")
        apellido = input("Apellido del cliente: ")

        cliente = session.query(Customer).filter_by(first_name=nombre, last_name=apellido).first()
        if not cliente:
            cliente = Customer(first_name=nombre, last_name=apellido, address_id=1, store_id=1)
            session.add(cliente)
            session.commit()
            print("Cliente creado.")
        else:
            print("Cliente ya existe.")

        print(f"Alquileres de {nombre} {apellido}:")
        for alquiler in cliente.rentals:
            film = alquiler.inventory.film
            print(f"- {film.title}")

        resp = input("¿Quieres alquilar una película nueva? (s/n): ")
        if resp.lower() == 's':
            titulo_peli = input("Nombre de la película: ")
            film = session.query(Film).filter_by(title=titulo_peli).first()
            if not film:
                print("Película no encontrada en Sakila.")
            else:
                inventario = session.query(Inventory).filter_by(film_id=film.film_id).first()
                if not inventario:
                    print("No quedan copias disponibles.")
                else:
                    nuevo_alquiler = Rental(customer_id=cliente.customer_id, inventory_id=inventario.inventory_id, rental_date=datetime.now())
                    session.add(nuevo_alquiler)
                    session.commit()
                    print("Alquiler realizado correctamente.")

        print(f"Alquileres actualizados de {nombre} {apellido}:")
        for alquiler in cliente.rentals:
            film = alquiler.inventory.film
            print(f"- {film.title}")

if __name__ == '__main__':
    main()
