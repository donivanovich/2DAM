from sqlalchemy import Column, Integer, String, ForeignKey
from sqlalchemy.orm import relationship
from Models.Base import Base

class Store(Base):
    __tablename__ = "store"

    store_id = Column(Integer, primary_key=True)
    address_id = Column(Integer, ForeignKey("address.address_id"))