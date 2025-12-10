- [x] Crear una tabla de Estudiantes con campos Nº, Nombre, Nº Tutor (CUSTOMER), Nombre tutor, Nota Media y Curso.

- [x] Crear una tabla de Asignatura con campos Nº, Nombre, Curso, Profesor (CUSTOMER), Nombre profesor.

- [x] Crear una tabla de Calificación con campos Nº serie, Asignatura, Curso (Asignatura), Profesor (Asignatura), Alumno, Nota.

- [x] Crear una tabla de Calificación con campos Nº serie, Asignatura, Curso (Asignatura), Profesor (Asignatura), Alumno (ALUMNOS), Nota. .

- [x] Crear lista y ficha de Calificaciones.

- [ ] Campo nota media de la tabla de estudiantes: media de las notas del estudiante por curso.

- [x] Crear una tabla de Profesor con campos: Nº profesor (Cliente), Nombre profesor(que se rellene con el nombre del cliente de la tabla cliente), Fecha incorporación al colegio, Nº asignatura (Asignatura), Nombre Asignatura (que se rellene con el nombre de la asignatura de la tabla asignaturas), Curso (que se rellene con el nombre de la asignatura de la tabla asignaturas), jubilado (Si o no), profesor tutor (si o no).

- [x] Lista y ficha de Profesor.

- [ ] Añadir campos que falten a la lista de estudiantes.

- [x] Crear una lista y una ficha de estudiantes.

- [ ] Crear una tabla de Asignaturas con campos Nº, Nombre, Nota, Profesor, Curso, Alumno. Crear la lista y la ficha de Asignaturas.

- [ ] Campo calculado tabla de Estudiantes.

- [ ] Crear un subformulario en la ficha de Estudiante que muestre la lista de asignaturas filtrada por estudiante y curso.

- [ ] Crear un botón en la ficha y en la lista de Estudiantes que saque las asignaturas filtradas por estudiante (Por propiedades).

- [x] Crear una tabla de Conf. Instituto y ficha de Conf. Instituto. campos: 1)Primary Key(code[10]), 2)Nº serie asignatura (code[20]), 3)Nº serie profesor (code[20]).

- [x] Crear ficha conf. instituto: en la página solo sacar el campo Nº serie asignatura y Nº serie profesor.

- [ ] Botón: Notas por alumno y por curso, por propiedades y por código.

- [ ] Boton: todas las notas, por propiedades y por código.

- [ ] Boton: todas las asignaturas, por propiedades y por código.

- [ ] Botón: asignaturas por curso del alumno, por propiedades y por código.

- [ ] Subformulario en la ficha de estudiantes que muestre las asignaturas del curso en el que está.

- [x] Crear campos Nota Media 1º ESO, 2ºESO, 3ºESO, 4ºESO en estudiantes.

- [ ] Botón desde la lista de profesores que saque la lista de alumnos que pertenecen a su curso, por propiedades y por código.

- [ ] Botón desde la lista de profesores que saque la lista de todos los alumnos, por propiedades y por código.

- [ ] Subformulario en la ficha de asignaturas que muestre los alumnos que están en ese curso.

- [ ] Subformulario en la ficha de estudiantes que muestre las notas de ese alumno en el curso en el que está.

- [ ] Subformulario en la ficha de estudiantes que muestre las notas de ese alumno en todos los cursos.

- [ ] Control en el botón de notas por alumno que si la nota media es 0 te saque un error de 'No hay notas registradas para este alumno'.

- [ ] Botón en lista estudiantes: Notas por alumno y por curso > 5, por propiedades y por código.

- [ ] Crear una extensión de la tabla de clientes.

- [ ] Crear una extensión de la ficha de clientes.

- [ ] Que se rellenen los datos del estudiante (Nombre y Curso) con los datos del cliente.

- [ ] Crear un botón en la ficha y en la lista de Estudiantes que saque las asignaturas filtradas por estudiante, por curso, y por nota>Nota media (Por código).

- [ ] Crear un botón en la ficha de Asignaturas que recorra la tabla de Estudiantes filtrada por el tutor = profesor y saque un mensaje con el nombre del estudiante y del profesor y si no encuentra ningún estudiante con ese filtro que saque un mensaje de error.

- [ ] Crear un botón que saque un strmenu desde la ficha de asignatura en el que las opciones sean los cursos y según se seleccione un curso se rellenará el campo Curso de la ficha de asignatura.

- [ ] Nº de serie, código en OnValidate y OnInsert.

- [x] Crear una tabla de Conf. Instituto y ficha de Conf. Instituto. 2- Crear campos: 1)Primary Key(code[10]), 2)Nº serie asignatura (code[20]), 3)Nº serie profesor (code[20]), en la página solo sacar el campo Nº serie asignatura y Nº serie profesor.

- [ ] Suscribirse a un evento estándar (OnAfterValidate de la tabla Customer en el campo City).

- [ ] Crear un evento nuevo en la tabla de Asignaturas en el OnValidate del campo notas.

- [ ] Suscribirse al evento creado en la tabla de Asignaturas y sacar un mensaje con el profesor de la asignatura.

- [ ] Suscribirse a un evento estándar para sacar un mensaje con el Nº, descripción del producto, Nº estante antiguo y Nº estante nuevo: OnAfterValidate del campo “Nº estante” de la tabla Producto

- [ ] Crear un evento nuevo en la tabla de clientes en el OnValidate del campo Curso.

- [ ] Suscribirse al evento creado en la tabla de clientes y sacar mensajes con los nombres de las asignaturas que está cursando ese estudiante en ese curso y el nombre del estudiante. Si no encuentra que saque un mensaje de error.

- [ ] Suscribirse al evento estándar OnAfterValidatePostCode de la tabla Proveedor y que muestre un mensaje con el Cód. postal antiguo y el nuevo.

- [ ] Crear un botón en la lista de profesores que recorra la tabla de profesores y saque un mensaje con el nombre de todos los profesores dados de alta.

- [x] Crear un campo en la tabla de estudiantes que sea “Refuerzo(boolean)” y en la lista y en la ficha.

- [ ] Crear botón en la ficha de estudiantes para que ese estudiante en concreto se marque el campo Refuerzo si tiene la nota media suspensa.

- [ ] Crear un botón en la lista de estudiantes que saque la lista de estudiantes con Refuerzo (por código y por propiedades).

- [x] Crear un campo en la tabla de Profesores que sea “Profesor tutor(boolean)” y en la lista y en la ficha.

- [ ] Crear un botón en la ficha de profesores que marque el campo Profesor tutor cuando el profesor sea tutor de un alumno y profesor de una asignatura y que saque mensajes de los alumnos que le tengan como tutor y las asignaturas que le tengan como profesor.

- [ ] Crear un botón en la lista de profesores que saque la lista de profesores que sean Profesor tutor (por código y por propiedades).

- [ ] Crear un botón en la lista de asignaturas y en la lista de profesores que saque la ficha de Conf. Instituto.

- [ ] Crear un botón en la ficha de Conf. Instituto que saque la lista de asignaturas.

- [ ] Crear un botón en la ficha de Conf. Instituto que saque la lista de profesores.

- [ ] Crear un campo que sea “Revisado” en la tabla de estudiantes y un botón en la ficha de estudiantes para que saque un mensaje de los estudiantes que tengan marcado el campo refuerzo y que marque el campo “Revisado”.

- [ ] Report tipo lista que muestre las asignaturas para cada estudiante y curso que salga desde un botón de la ficha de estudiante.