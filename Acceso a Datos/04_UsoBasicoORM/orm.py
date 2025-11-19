from sqlalchemy import (
    create_engine, Column, Integer, String, SmallInteger, ForeignKey
)
from sqlalchemy.orm import declarative_base, relationship, Session

#Obligatorio del ORM
Base = declarative_base()


class FilmActor(Base):
    __tablename__ = 'film_actor'
    actor_id = Column(Integer, ForeignKey('actor.actor_id'), primary_key=True)
    film_id = Column(Integer, ForeignKey('film.film_id'), primary_key=True)

    def __repr__(self):
        return f"<FilmActor(actor_id={self.actor_id}, film_id={self.film_id})>"

class Actor(Base):
    __tablename__ = 'actor'
    actor_id = Column(Integer, primary_key=True)
    first_name = Column(String(45), nullable=False)
    last_name = Column(String(45), nullable=False)
    films = relationship('Film', secondary="film_actor")

    def __repr__(self):
        return f"<Actor(id={self.actor_id}, name={self.first_name} {self.last_name})>"

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

    def __repr__(self):
        return f"<Film(id={self.film_id}, title={self.title})>"


def main():
# Cambiado a MySQL con puerto 3309, usuario root, contraseña 1234
    engine = create_engine(
        'mysql+mysqlconnector://root:1234@localhost:3309/sakila',
        echo=False
    )
    Base.metadata.create_all(engine)
    
    with Session(engine) as session:
        actor1 = Actor(first_name='pepe', last_name='kk')
        film1 = Film(title='Example Film', description='Un film de ejemplo', release_year=2025, language_id=1)
        film1.actors.append(actor1)
        session.add_all([actor1, film1])
        session.commit()

        #session.query(Film) = equivale a select * from film
        #....filter_by(title='example Film') =  where title like 'example Film'
        #.first() = limit 1
        film = session.query(Film).filter_by(title='Example Film').first()
        print("********************************")
        print(f"Película: {film.title}, Idioma: {film.language.name}, Actores: {[f'{a.first_name} {a.last_name}' for a in film.actors]}")
        print("********************************")
        actor = session.query(Actor).filter_by(first_name='pepe', last_name='kk').first()
        print(f"Actor: {actor.first_name} {actor.last_name}, Películas: {[f.title for f in actor.films]}")

if __name__ == '__main__':
    main()