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

class InventoryRepository():

    def GetFirstFilmInventoryById(id):
        with Session(engine) as session:
            return session.query(Inventory).filter_by(film_id=id).first()
        
    def createNewInventoryForFilm(film_id, store_id=1 ):
        with Session(engine) as session:
            new_inventory = Inventory(film_id=film_id, store_id=store_id)
            session.add(new_inventory)
            session.commit()
            return new_inventory.inventory_id
