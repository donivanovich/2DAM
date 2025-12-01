from sqlalchemy import (
    create_engine, Column, Integer, String, SmallInteger, ForeignKey
)
from sqlalchemy.orm import declarative_base, relationship, Session

from Models.Base import Base



class Customer(Base):
    __tablename__ = 'customer'

    customer_id = Column(Integer, primary_key = True)
    first_name = Column(String)
    last_name = Column(String)
    email = Column(String)
    store_id = Column(Integer, ForeignKey("store.store_id"))
    address_id = Column(Integer, ForeignKey("address.address_id"))
    create_date = Column(String)