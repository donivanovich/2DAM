from sqlalchemy import (
    create_engine, Column, Integer, String, SmallInteger, ForeignKey
)
from sqlalchemy.orm import declarative_base, relationship, Session
from Models.Base import Base

from Models.Customers import Customer


class Rental(Base):
    __tablename__ = 'rental'

    rental_id = Column(Integer, primary_key = True)
    
    inventory_id = Column(Integer, ForeignKey("inventory.inventory_id"))
    customer_id = Column(String, ForeignKey("customer.customer_id"))
    staff_id = Column(String)
    return_date = Column(String)
    rental_date = Column(String)

    inventory = relationship("Inventory", back_populates = "rentals")
