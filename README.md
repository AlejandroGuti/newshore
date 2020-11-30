# newshore

Buen día.
Aquí se encontrará lo que se alcanzó a hacer del proyecto solicitado, tanto del front como del back.

Se debe cumplir con el análisis diseño e implementación de la solución en lenguaje C# (Core con entity Framework) orientado a la web como API y contiene:
• Arquitectura de diseño (N-Capas)
• Programación orientada a objetos (Clases, Herencia, Polimorfismo)
• Front-end (HTML, CSS)
• Consume Web APIs (REST)
• Versionamiento código (GitHub)
• Base de datos SQL Server.

Se buscó seguir los principios SOLID y contiene:

• Control de excepciones (Try-Catch)
• 
• GIT Advanced
o Distintas ramas (crear una rama alterna a la rama principal con al menos un cambio visible)
o Pull request (dejar una creada y agregar el link al README.txt) se hicieron 2 pull de las 3 ramas existentes, no se borraron, pueden ser vistas fácilmente.

3
PROBLEMA 1 Modelado Clases, logrado con mejoras, con el fin de no tener mucha repetición dentro de la data de transporte, se genera una búsqueda previa, para visualizar si el transporte ya fue creado y así realizar la relación sin duplicidad de objetos, pudo haber más mejoras, pero no considere apropiado modificar mucho el modelo inicial.

PROBLEMA 2 Maquetación web, aunque se logró tener el end point de back funcional, el tiempo no fue suficiente para poder terminar la parte del front (Igualmente mi enfoque es backend) Pdta. se logró el login como front con Angular satisfactoriamente, y el paso a una página en blanco que ya estaba armando para este punto, elementos usados:
Para la solución es necesario hacer uso de CSS con una clara definición de las clases y elementos a utilizar.
2. Se valorará uso de framework orientados a la vista tales como Bootstrap, Materialize.

PROBLEMA 3 Servicio API: Logrado en su totalidad.
PROBLEMA 4 Guardar resultado en BD. Punto logrado en cuanto al API, este también comprende una relación con el usuario dentro de la tabla, para posibles consultas futuras o edición de selecciones.

PROBLEMA 5 Envío de Itinerario (opcional Perfil Senior – Edwin / Mauricio): aunque sabía cómo hacerlo, con una librería que escribe pdfs y maquetando dentro del mismo obteniendo de la base de datos, guardando también en el www.root o una localización x, el tiempo no me fue suficiente para realizarlo.


*******************Requisitos de funcionamiento.

Se debe cambiar la cadena de conexión, esta se debe modificar dentro del \NewShoreAPI\appsettings.json en ConnectionStrings, proyecto DB first, inicia con una semilla
y un usuario admin en la base de datos, también se abrió el cors para el funcionamiento del api a referencias externas, en caso que no se pueda conectar angular al api corriendo localmente, se debe cambiar en \NewShoreAPI\Startup.cs en ConfigureServices ... add cors.... with origins... aunque no debería porque actualmente está configurado para cualquier origen y petición.

Proyecto realizado en VisualStudio2019 y angular con VisualStudio core, base de datos SQL server.

Agradecimientos a los interesados.
