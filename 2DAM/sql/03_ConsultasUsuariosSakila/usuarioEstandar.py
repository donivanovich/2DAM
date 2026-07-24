import mysql.connector
from mysql.connector import Error

# ============ CONFIGURACIÓN — cambiar según tu entorno ============
DB_HOST = 'localhost'
DB_PORT = 3309
DB_NAME = 'sakila'

DB_USER = 'usuario_estandar'
DB_PASS = '1234'
# ==================================================================

def run_query(cursor, query, params=None):
    """Ejecuta una consulta y devuelve resultados o None si hay error de permiso."""
    try:
        if params:
            cursor.execute(query, params)
        else:
            cursor.execute(query)
        return cursor.fetchall()
    except Error as e:
        # Podrías filtrar por códigos de error específicos si quieres (1044, 1142, etc.)
        # pero para simplificar tratamos cualquier Error como “acceso denegado” en este contexto.
        # Imprimir el mensaje para depuración
        print(f"[!] Error al ejecutar: {query.strip().splitlines()[0]} ...")
        print("    Motivo:", e)
        return None

def main():
    conn = mysql.connector.connect(
        host=DB_HOST, port=DB_PORT, user=DB_USER, password=DB_PASS, database=DB_NAME
    )
    cursor = conn.cursor()

    print("=== Dashboard Usuario Estándar ===\n")

    # Consultas que NO debe poder hacer — esperamos None
    print("-- Intento listado staff (esperado fallo) --")
    q_staff = "SELECT staff_id, first_name, last_name FROM staff;"
    res_staff = run_query(cursor, q_staff)
    print("Resultado:", res_staff)
    print()

    print("-- Intento listado payments (esperado fallo) --")
    q_payments = "SELECT payment_id, customer_id, staff_id, amount FROM payment LIMIT 20;"
    res_payments = run_query(cursor, q_payments)
    print("Resultado:", res_payments)
    print()

    # Consultas que DEBE poder hacer — esperamos datos válidos
    print("-- Top 5 actores por duración total de películas (esperado éxito) --")
    q_actores_duracion = """
    SELECT 
        a.actor_id,
        a.first_name,
        a.last_name,
        SUM(f.length) AS total_duration
    FROM 
        actor a
    JOIN 
        film_actor fa ON a.actor_id = fa.actor_id
    JOIN 
        film f ON fa.film_id = f.film_id
    GROUP BY 
        a.actor_id, a.first_name, a.last_name
    ORDER BY 
        total_duration DESC
    LIMIT 5;
    """
    res_actores = run_query(cursor, q_actores_duracion)
    if res_actores is not None:
        for row in res_actores:
            print(row)
    print()

    print("-- Categoría con más actores (esperado éxito) --")
    q_categoria_mas_actores = """
    SELECT
        c.category_id,
        c.name,
        COUNT(DISTINCT fa.actor_id) AS num_actores
    FROM
        category c
        JOIN film_category fc ON c.category_id = fc.category_id
        JOIN film_actor fa ON fc.film_id = fa.film_id
    GROUP BY
        c.category_id, c.name
    ORDER BY
        num_actores DESC
    LIMIT 1;
    """
    res_categoria = run_query(cursor, q_categoria_mas_actores)
    if res_categoria is not None:
        for row in res_categoria:
            print(row)
    print()

    # Lógica de verificación
    # Queremos:
    # - res_staff sea None (fallo)
    # - res_payments sea None (fallo)
    # - res_actores NO sea None (éxito)
    # - res_categoria NO sea None (éxito)
    ok_no_staff = (res_staff is None)
    ok_no_payments = (res_payments is None)
    ok_actores = (res_actores is not None)
    ok_categoria = (res_categoria is not None)

    if ok_no_staff and ok_no_payments and ok_actores and ok_categoria:
        print("✅ Ejercicio completo")
    else:
        print("❌ Ejercicio no completo")
        # Info adicional para debugging
        print("Detalles de verificación:")
        print(f"  - staff fallo esperado: {ok_no_staff}")
        print(f"  - payments fallo esperado: {ok_no_payments}")
        print(f"  - actores éxito esperado: {ok_actores}")
        print(f"  - categoría éxito esperado: {ok_categoria}")

    cursor.close()
    conn.close()

if __name__ == "__main__":
    main()