import mysql.connector
from mysql.connector import Error

# ================= CONFIGURACIÓN — cámbialo según tu entorno =================
DB_HOST = 'localhost'
DB_PORT = 3309
DB_NAME = 'sakila'

DB_USER = 'trabajador_encargado'
DB_PASS = 'supersegura'
# ============================================================================

def run_query(cursor, query, params=None):
    """Ejecuta una consulta y retorna resultados, o None si error (por permisos u otro)."""
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

    print("=== Acceso Empleado / Encargado ===\n")

    # Consultas que NO debe poder hacer — categorías y actores
    print("-- Intento ver categorías de películas (esperado fallo) --")
    q_categories = "SELECT category_id, name FROM category;"
    res_categories = run_query(cursor, q_categories)
    print("Resultado:", res_categories)
    print()

    print("-- Intento ver actores (esperado fallo) --")
    q_actors = "SELECT actor_id, first_name, last_name FROM actor;"
    res_actors = run_query(cursor, q_actors)
    print("Resultado:", res_actors)
    print()

    # Consultas que DEBE poder hacer — completadas por alumnos

    # 1) Cliente que más veces ha alquilado
    print("-- Cliente con más alquileres --")
    q_mas_alquileres = """
    SELECT
        c.customer_id,
        c.first_name,
        c.last_name,
        COUNT(r.rental_id) AS veces_alquilado
    FROM
        customer c
        JOIN rental r ON c.customer_id = r.customer_id
    GROUP BY
        c.customer_id, c.first_name, c.last_name
    ORDER BY
        veces_alquilado DESC
    LIMIT 1;
    """
    res_mas_alq = run_query(cursor, q_mas_alquileres)
    if res_mas_alq is not None:
        for row in res_mas_alq:
            print(row)
    print()

    # 2) Cliente más rentable (suma de amount)
    print("-- Cliente más rentable --")
    q_mas_rentable = """
    SELECT
        c.customer_id,
        c.first_name,
        c.last_name,
        SUM(p.amount) AS gasto_total
    FROM
        customer c
        JOIN payment p ON c.customer_id = p.customer_id
    GROUP BY
        c.customer_id, c.first_name, c.last_name
    ORDER BY
        gasto_total DESC
    LIMIT 1;
    """
    res_mas_rent = run_query(cursor, q_mas_rentable)
    if res_mas_rent is not None:
        for row in res_mas_rent:
            print(row)
    print()

    # 3) Cliente con menos alquileres
    print("-- Cliente con menos alquileres --")
    q_menos_alquileres = """
    SELECT
        c.customer_id,
        c.first_name,
        c.last_name,
        COUNT(r.rental_id) AS veces_alquilado
    FROM
        customer c
        JOIN rental r ON c.customer_id = r.customer_id
    GROUP BY
        c.customer_id, c.first_name, c.last_name
    ORDER BY
        veces_alquilado ASC
    LIMIT 1;
    """
    res_menos_alq = run_query(cursor, q_menos_alquileres)
    if res_menos_alq is not None:
        for row in res_menos_alq:
            print(row)
    print()

    # 4) Cliente menos rentable (gasto más bajo)
    print("-- Cliente menos rentable --")
    q_menos_rentable = """
    SELECT
        c.customer_id,
        c.first_name,
        c.last_name,
        SUM(p.amount) AS gasto_total
    FROM
        customer c
        JOIN payment p ON c.customer_id = p.customer_id
    GROUP BY
        c.customer_id, c.first_name, c.last_name
    ORDER BY
        gasto_total ASC
    LIMIT 1;
    """
    res_menos_rent = run_query(cursor, q_menos_rentable)
    if res_menos_rent is not None:
        for row in res_menos_rent:
            print(row)
    print()

    # Verificación final para “ejercicio completo”
    ok_no_categories = (res_categories is None)
    ok_no_actors = (res_actors is None)
    ok_mas_alq = (res_mas_alq is not None)
    ok_mas_rent = (res_mas_rent is not None)
    ok_menos_alq = (res_menos_alq is not None)
    ok_menos_rent = (res_menos_rent is not None)

    if ok_no_categories and ok_no_actors and ok_mas_alq and ok_mas_rent and ok_menos_alq and ok_menos_rent:
        print("✅ Ejercicio completo")
    else:
        print("❌ Ejercicio no completo")
        print("Detalles verificación:")
        print(f"  - categories fallo esperado: {ok_no_categories}")
        print(f"  - actors fallo esperado: {ok_no_actors}")
        print(f"  - más alquileres éxito esperado: {ok_mas_alq}")
        print(f"  - más rentable éxito esperado: {ok_mas_rent}")
        print(f"  - menos alquileres éxito esperado: {ok_menos_alq}")
        print(f"  - menos rentable éxito esperado: {ok_menos_rent}")

    cursor.close()
    conn.close()

if __name__ == "__main__":
    main()
