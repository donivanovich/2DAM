from sqlalchemy import (
    create_engine, Column, Integer, String, SmallInteger, ForeignKey
)
from sqlalchemy.orm import relationship, Session

from Models.Base import Base
from Models.Films import Film
from Models.Rentals import Rental


class Inventory(Base):
   __tablename__ = 'inventory'
   
   inventory_id = Column(Integer, primary_key = True)
   film_id = Column(Integer, ForeignKey("film.film_id"))
   store_id = Column(Integer)
   film = relationship("Film", back_populates="inventories")
   rentals = relationship("Rental", back_populates="inventory")

   def __repr__(self):
        return f"<Inventory(id={self.inventory_id})>"