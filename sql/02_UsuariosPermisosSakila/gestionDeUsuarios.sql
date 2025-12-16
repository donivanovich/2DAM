-- Crear usuarios con contraseñas seguras.

-- Puede consultar la información del personal, menos datos personales (como fotos). 
-- Puede actualizar datos del personal. 
-- No puede modificar el resto de campos ni acceder a otras tablas.
CREATE USER 'usr_personal'@'localhost' IDENTIFIED BY 'Rrhh#2025!'; 

-- Puede  consultar, insertar y actualizar datos en las tablas rental y payment.
-- También puede consultar las tablas customer, inventory, film, store y staff para verificar información relacionada.
-- No puede eliminar registros de rentas ni de pagos.
CREATE USER 'usr_alquileres'@'localhost' IDENTIFIED BY 'Rent#2025!'; 

-- Puede realizar CRUD completo  sobre la tabla inventory.
-- Puede consultar las tablas store y film.
-- No puede modificar ni insertar datos en otras tablas.
CREATE USER 'usr_inventario'@'localhost' IDENTIFIED BY 'Inv#2025!';

-- Tiene acceso total a todos los objetos de la base de datos .
-- Puede crear y eliminar tablas, vistas, índices y usuarios.
-- (Opcional) Si se desea, se le puede permitir con WITH GRANT OPTION.
CREATE USER 'usr_admin'@'localhost' IDENTIFIED BY 'Admin#2025!';

use sakila;
CREATE OR REPLACE VIEW v_staff_seguro AS
SELECT staff_id, first-name, last_name, adress_id, email, store_id, active
FROM staff;

-- Asignar privilegios específicos sobre determinadas tablas y columnas.
GRANT SELECT ON sakila.v_staff_seguro TO 'usr_personal'@'localhost';
GRANT UPDATE (email, active) ON sakila.rental TO 'usr_personal'@'localhost';

-- Aplicar permisos de lectura, inserción, actualización y eliminación (CRUD).
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

-- Comprobar los privilegios asignados usando las (mysql.db, mysql.tables_priv, mysql.columns_priv).
SELECT user, host, db, Select_priv, Insert_priv, Update_priv, Delete_priv, Grant_priv
FROM mysql.db
WHERE db = 'sakila';

SELECT user, host, db, table_name, table_priv
FROM mysql.tables_priv
WHERE db = 'sakila';

SELECT user, host, db, table_name, column_name, column_priv
FROM mysql.columns_priv
WHERE db = 'sakila';
