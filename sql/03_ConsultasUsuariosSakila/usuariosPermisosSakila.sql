DROP USER IF EXISTS 'usuario_estandar'@'localhost';
CREATE USER 'usuario_estandar'@'localhost' IDENTIFIED BY '1234';
GRANT SELECT ON sakila.actor TO 'usuario_estandar'@'localhost';
GRANT SELECT ON sakila.category TO 'usuario_estandar'@'localhost';
GRANT SELECT ON sakila.film TO 'usuario_estandar'@'localhost';
GRANT SELECT ON sakila.film_actor TO 'usuario_estandar'@'localhost';
GRANT SELECT ON sakila.film_category TO 'usuario_estandar'@'localhost';
FLUSH PRIVILEGES;

DROP USER IF EXISTS 'trabajador_videoclub'@'localhost';
CREATE USER 'trabajador_videoclub'@'localhost' IDENTIFIED BY 'password';
GRANT SELECT ON sakila.film TO 'trabajador_videoclub'@'localhost';
GRANT SELECT ON sakila.inventory TO 'trabajador_videoclub'@'localhost';
GRANT SELECT ON sakila.rental TO 'trabajador_videoclub'@'localhost';
GRANT SELECT ON sakila.payment TO 'trabajador_videoclub'@'localhost';
FLUSH PRIVILEGES;

DROP USER IF EXISTS 'trabajador_encargado'@'localhost';
CREATE USER 'trabajador_encargado'@'localhost' IDENTIFIED BY 'supersegura';
GRANT SELECT ON sakila.customer TO 'trabajador_encargado'@'localhost';
GRANT SELECT ON sakila.rental TO 'trabajador_encargado'@'localhost';
GRANT SELECT ON sakila.payment TO 'trabajador_encargado'@'localhost';
FLUSH PRIVILEGES;