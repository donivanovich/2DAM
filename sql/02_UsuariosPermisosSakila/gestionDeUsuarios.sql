CREATE USER 'usr_personal'@'localhost' IDENTIFIED BY 'Rrhh#2025!';
CREATE USER 'usr_alquileres'@'localhost' IDENTIFIED BY 'Rent#2025!';
CREATE USER 'usr_inventario'@'localhost' IDENTIFIED BY 'Inv#2025!';
CREATE USER 'usr_admin'@'localhost' IDENTIFIED BY 'Admin#2025!';

use sakila;
CREATE OR REPLACE VIEW v_staff_seguro AS
SELECT staff_id, first-name, last_name, adress_id, email, store_id, active
FROM staff;

GRANT SELECT ON sakila.v_staff_seguro TO 'usr_personal'@'localhost';
GRANT UPDATE (email, active) ON sakila.rental TO 'usr_personal'@'localhost';

GRANT SELECT, INSERT, UPDATE ON sakila.rental TO 'usr_alquileres'@'localhost';
GRANT SELECT, INSERT, UPDATE ON sakila.payment TO 'usr_alquileres'@'localhost';

GRANT SELECT ON sakila.customer TO 'usr_alquileres'@'localhost';
GRANT SELECT ON sakila.inventory TO 'usr_alquileres'@'localhost';
GRANT SELECT ON sakila.film TO 'usr_alquileres'@'localhost';
GRANT SELECT ON sakila.store TO 'usr_alquileres'@'localhost';
GRANT SELECT ON sakila.staff TO 'usr_alquileres'@'localhost';

GRANT SELECT, INSERT, UPDATE, DELETE ON sakila.inventory TO 'usr_inventario'@'localhost';
GRANT SELECT ON sakila.store TO 'usr_inventario'@'localhost';
GRANT SELECT ON sakila.film TO 'usr_inventario'@'localhost';

GRANT ALL PRIVILEGES ON sakila.* TO 'usr_admin'@'localhost' WITH GRANT OPTION;

SELECT user, host, db, Select_priv, Insert_priv, Update_priv, Delete_priv, Grant_priv
FROM mysql.db
WHERE db = 'sakila';

SELECT user, host, db, table_name, table_priv
FROM mysql.tables_priv
WHERE db = 'sakila';

SELECT user, host, db, table_name, column_name, column_priv
FROM mysql.columns_priv
WHERE db = 'sakila';
