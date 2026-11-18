import datetime
from Models.Base import Base
from Models.Customers import Customer
from Models.Stores import Store
from Models.Addresses import Address 

from sqlalchemy import (
    create_engine
)
from sqlalchemy.orm import Session


engine = create_engine(
    'mysql+mysqlconnector://root:1234@localhost:3309/sakila',
    echo=False
)

Base.metadata.create_all(engine)

class CustomerRepository():

    def getCustomerByFullName(first_name, last_name):

        with Session(engine) as session:

            return session.query(Customer).filter_by(first_name=first_name, last_name=last_name).all()


    
    def createNewCustomer(first_name, last_name, store_id, address_id):

        with Session(engine) as session:

            customer = Customer(first_name=first_name, last_name=last_name, store_id=store_id, address_id = address_id, create_date=datetime.datetime.now())

            session.add(customer)

            session.commit()

            return customer.customer_id
