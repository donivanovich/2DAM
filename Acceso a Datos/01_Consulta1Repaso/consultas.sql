-- SQL Queries for film rental analysis

-- 10 peliculas mas largas
SELECT title, length FROM film ORDER BY length DESC LIMIT 10;

-- Actores pelicula mas larga
SELECT a.actor_id, a.first_name, a.last_name FROM actor a JOIN film_actor fa ON a.actor_id = fa.actor_id JOIN film f ON fa.film_id = f.film_id WHERE f.length = (SELECT MAX(length) FROM film);

-- Pelicula mas veces alquilada
SELECT f.title, COUNT(r.rental_id) AS total_rentals FROM film f JOIN inventory i ON f.film_id = i.film_id JOIN rental r ON i.inventory_id = r.inventory_id GROUP BY f.film_id ORDER BY total_rentals DESC LIMIT 1;

-- Tienda mas clientes
SELECT store_id, COUNT(DISTINCT customer_id) as customer_count FROM rental GROUP BY store_id ORDER BY customer_count DESC LIMIT 1;

-- Empleado mas alquileres
SELECT staff_id, COUNT(rental_id) AS rentals_count FROM rental GROUP BY staff_id ORDER BY rentals_count DESC LIMIT 1;

-- Pelicula mas alquilada por empleado
SELECT staff_id, f.title, COUNT(r.rental_id) AS rentals_count FROM rental r JOIN inventory i ON r.inventory_id = i.inventory_id JOIN film f ON i.film_id = f.film_id GROUP BY staff_id, f.film_id ORDER BY staff_id, rentals_count DESC;

-- Pelicula mas alquilada por tienda
SELECT store_id, f.title, COUNT(r.rental_id) AS rentals_count FROM rental r JOIN inventory i ON r.inventory_id = i.inventory_id JOIN film f ON i.film_id = f.film_id GROUP BY store_id, f.film_id ORDER BY store_id, rentals_count DESC;

-- Tienda mas alquileres pendientes devolver
SELECT r.store_id, COUNT(r.rental_id) AS pending_returns FROM rental r WHERE r.return_date IS NULL GROUP BY r.store_id ORDER BY pending_returns DESC LIMIT 1;

-- Alquiler mas largo
SELECT rental_id, TIMESTAMPDIFF(MINUTE, rental_date, return_date) AS rental_duration_minutes FROM rental WHERE return_date IS NOT NULL ORDER BY rental_duration_minutes DESC LIMIT 1;

-- Peliculas duracion par
SELECT title, length FROM film WHERE length % 2 = 0;

-- Actor peliculas mas alquiladas
SELECT a.actor_id, a.first_name, a.last_name, COUNT(r.rental_id) AS total_rentals FROM actor a JOIN film_actor fa ON a.actor_id = fa.actor_id JOIN inventory i ON fa.film_id = i.film_id JOIN rental r ON i.inventory_id = r.inventory_id GROUP BY a.actor_id ORDER BY total_rentals DESC LIMIT 1;

