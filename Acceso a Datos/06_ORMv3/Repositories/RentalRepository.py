import datetime
from Models.Base import Base
from Models.Rentals import Rental
from Models.Inventories import Inventory
from Models.Customers import Customer

from sqlalchemy import (
    create_engine
)
from sqlalchemy.orm import Session


engine = create_engine(
    'mysql+mysqlconnector://root:1234@localhost:3309/sakila',
    echo=False
)

Base.metadata.create_all(engine)

class RentalRepository():

    def getRentalsByCustomerId(id):

        with Session(engine) as session:

            return session.query(Rental).filter_by(customer_id=id).all()


    def createRental(customer_id, inventory_id, staff_id):

        with Session(engine) as session:

            rental = Rental(customer_id=customer_id, inventory_id=inventory_id, staff_id=staff_id, rental_date=datetime.datetime.now())

            session.add(rental)

            session.commit()

            return rental.rental_id
    
    def deleteRental(customer_id, inventory_id):
        with Session(engine) as session:
            rental = session.query(Rental).filter(
            Rental.customer_id == customer_id,
            Rental.inventory_id == inventory_id
        ).first()
        if rental:
            session.delete(rental)
            session.commit()
            return True  # Indica que se eliminó
        else:
            return False  # No se encontró registro para eliminar