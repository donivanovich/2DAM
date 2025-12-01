import datetime
from Models.Base import Base
from Models.Rentals import Rental
from Models.Inventories import Inventory
from Models.Films import Film

from sqlalchemy import (
    create_engine
)
from sqlalchemy.orm import Session


engine = create_engine(
    'mysql+mysqlconnector://root:1234@localhost:3309/sakila',
    echo=False
)

Base.metadata.create_all(engine)

class FilmRepository():
    def getFilmByName(name):
        with Session(engine) as session:
            return session.query(Film).filter_by(title=name).all()
        
    def createNewFilm(title, language_id=1):
        with Session(engine) as session:
            new_film = Film(title=title, language_id=language_id)
            session.add(new_film)
            session.commit()
            return new_film.film_id