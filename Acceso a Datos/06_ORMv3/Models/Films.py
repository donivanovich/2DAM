from sqlalchemy import (
    create_engine, Column, Integer, String, SmallInteger, ForeignKey
)

from sqlalchemy.orm import relationship, Session
from Models.Base import Base

class Film(Base):
    __tablename__ = 'film'

    film_id = Column(Integer, primary_key = True)
    title = Column(String)
    inventories = relationship("Inventory", back_populates="film")
