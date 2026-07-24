from sqlalchemy import Column, Integer, String
from sqlalchemy.orm import relationship
from Models.Base import Base

class Address(Base):
    __tablename__ = "address"

    address_id = Column(Integer, primary_key=True)
    address = Column(String(255))
    district = Column(String(50))
    postal_code = Column(String(10))
    phone = Column(String(20))
