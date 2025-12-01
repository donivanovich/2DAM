import mysql.connector
from mysql.connector import Error

# ================= CONFIGURACIÓN — cambia estos valores =================
DB_HOST = 'localhost'
DB_PORT = 3309
DB_NAME = 'sakila'

DB_USER = 'trabajador_videoclub'
DB_PASS = 'password'
# ========================================================================

def run_query(cursor, query, params=None):
    """Ejecuta consulta, devuelve resultados o None si error (por permisos u otro)."""
    try:
        if params:
            cursor.execute(query, params)
        else:
            cursor.execute(query)
        return cursor.fetchall()
    except Error as e:
        print(f"[!] Error al ejecutar: {query.strip().splitlines()[0]} ...")
        print("    Motivo:", e)
        return None

def main():
    conn = mysql.connector.connect(
        host=DB_HOST, port=DB_PORT, user=DB_USER, password=DB_PASS, database=DB_NAME
    )
    cursor = conn.cursor()

    print("=== Acceso Trabajador / Alquileres ===\n")

    # Consultas que NO debe poder hacer — staff y customer
    print("-- Intento acceder a staff (esperado fallo) --")
    q_staff = "SELECT staff_id, first_name, last_name FROM staff;"
    res_staff = run_query(cursor, q_staff)
    print("Resultado:", res_staff)
    print()

    print("-- Intento acceder a customer (esperado fallo) --")
    q_customer = "SELECT customer_id, first_name, last_name FROM customer;"
    res_customer = run_query(cursor, q_customer)
    print("Resultado:", res_customer)
    print()

    # Consultas que DEBE poder hacer — los alumnos las completan

    # 1) Película más rentable (suma del amount de los rentals / pagos más alta)
    print("-- Película más rentable --")
    q_peli_mas_rentable = """
    SELECT
        f.film_id,
        f.title,
        SUM(p.amount) AS total_ingresos
    FROM
        film f
        JOIN inventory i ON f.film_id = i.film_id
        JOIN rental r ON i.inventory_id = r.inventory_id
        JOIN payment p ON r.rental_id = p.rental_id
    GROUP BY
        f.film_id, f.title
    ORDER BY
        total_ingresos DESC
    LIMIT 1;
    """
    res_rentable = run_query(cursor, q_peli_mas_rentable)
    if res_rentable is not None:
        for row in res_rentable:
            print(row)
    print()

    # 2) Película menos rentable
    print("-- Película menos rentable --")
    q_peli_menos_rentable = """
    SELECT
        f.film_id,
        f.title,
        SUM(p.amount) AS total_ingresos
    FROM
        film f
        JOIN inventory i ON f.film_id = i.film_id
        JOIN rental r ON i.inventory_id = r.inventory_id
        JOIN payment p ON r.rental_id = p.rental_id
    GROUP BY
        f.film_id, f.title
    ORDER BY
        total_ingresos ASC
    LIMIT 1;
    """
    res_menos_rentable = run_query(cursor, q_peli_menos_rentable)
    if res_menos_rentable is not None:
        for row in res_menos_rentable:
            print(row)
    print()

    # 3) Película más alquilada (mayor número de rentals)
    print("-- Película más alquilada --")
    q_peli_mas_alquilada = """
    SELECT
        f.film_id,
        f.title,
        COUNT(r.rental_id) AS num_alquileres
    FROM
        film f
        JOIN inventory i ON f.film_id = i.film_id
        JOIN rental r ON i.inventory_id = r.inventory_id
    GROUP BY
        f.film_id, f.title
    ORDER BY
        num_alquileres DESC
    LIMIT 1;
    """
    res_mas_alq = run_query(cursor, q_peli_mas_alquilada)
    if res_mas_alq is not None:
        for row in res_mas_alq:
            print(row)
    print()

    # 4) Película menos alquilada
    print("-- Película menos alquilada --")
    q_peli_menos_alquilada = """
    SELECT
        f.film_id,
        f.title,
        COUNT(r.rental_id) AS num_alquileres
    FROM
        film f
        JOIN inventory i ON f.film_id = i.film_id
        JOIN rental r ON i.inventory_id = r.inventory_id
    GROUP BY
        f.film_id, f.title
    ORDER BY
        num_alquileres ASC
    LIMIT 1;
    """
    res_menos_alq = run_query(cursor, q_peli_menos_alquilada)
    if res_menos_alq is not None:
        for row in res_menos_alq:
            print(row)
    print()

    # Verificar si “ejercicio completo”
    # Condiciones esperadas:
    # - res_staff es None
    # - res_customer is None
    # - res_rentable no es None
    # - res_menos_rentable no es None
    # - res_mas_alq no es None
    # - res_menos_alq no es None

    ok_no_staff = (res_staff is None)
    ok_no_customer = (res_customer is None)
    ok_rentable = (res_rentable is not None)
    ok_menos_rentable = (res_menos_rentable is not None)
    ok_mas_alq = (res_mas_alq is not None)
    ok_menos_alq = (res_menos_alq is not None)

    if ok_no_staff and ok_no_customer and ok_rentable and ok_menos_rentable and ok_mas_alq and ok_menos_alq:
        print("✅ Ejercicio completo")
    else:
        print("❌ Ejercicio no completo")
        print("Detalles verificación:")
        print(f"  - staff fallo esperado: {ok_no_staff}")
        print(f"  - customer fallo esperado: {ok_no_customer}")
        print(f"  - rentable éxito esperado: {ok_rentable}")
        print(f"  - menos rentable éxito esperado: {ok_menos_rentable}")
        print(f"  - más alquilada éxito esperado: {ok_mas_alq}")
        print(f"  - menos alquilada éxito esperado: {ok_menos_alq}")

    cursor.close()
    conn.close()

if __name__ == "__main__":
    main()