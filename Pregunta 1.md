# Examen_Parcial_DOSCII


Explicar con sus propias palabras:
- Diseño de software.-
Diseño consiste en Arquitectura y diseño detallado,pero diseño  detallado no es arquitectura
Se entiende como el proceso por el que un agente crea una especificación de un
artefacto de software, pensado para cumplir unos objetivos io requerimientos funcionales,
utilizando un conjunto de componentes sujeto a restricciones 

El diseño como un proceso tiene este flujo
equerimientos-->Diseño-->Desarrollo-->Test--> Mantenimiento 

Considerando que el Nivel de abstraccion para el diseño de software es de bajo nivel con un 
enfoque especifico dedetalles como especificacion de la codificacion y diseño detallado de los componentes .

- Favorecer la composición de objetos frente a la herencia de clases.-


- Drivers arquitecturales y conceptos de diseño.-

Una arquitectura bien diseñada y adecuadamente comunicada importante para lograr acuerdos que guíen
al equipo. se tienen estos 5 drivers arquitecturales :

1 Propósito del diseño : Se debe tener claro el propósito del diseño que desea lograr como primer punto.

2 Atributos de calidad : es una propiedad de calidad del software de su ciclo de desarrollo,pudiendo manifestarse 
                         como características,capacidades o restricciones de una función específica o un conjunto de funciones del                                software
3 Funcionalidad primaria :En términos de diseño arquitectónico, lo que importa es la asignación de funcionalidad a los elementos,
4 Preocupaciones arquitectónicas : consideran aspectos adicionales que deben considerarse como parte del diseño
                                   arquitectónico,pero que no se expresan como requisitos tradicionales.
5 Restricciones : es una decisión sobre la cual tienes poco o ningún control para un arquitecto.


- Domain Driven Design (DDD).-
DDD es un conjunto de herramientas que le ayudan a diseñar e implementar software que ofrece
un alto valor,tanto estratégica como tácticamente.
DDD es un conjunto de técnicas avanzadas para ser utilizado en proyectos de software complejos.
Muchos equipos de desarrollo de software no dan diseño ni siquiera un pensamiento pasajero.
 
--El costo para el negocio suele ser el precio más alto pagado por tales diseños inexistentes.
-- Esto sucede a menudo debido a la presión para entregar versiones de software en un horario implacable.
-- Pensar en el costo de DDD ,pero tomando en cuenta es mas caro arreglar un mal diseño.

- Comand Query Responsibility Segregation (CQRS).-

Se define asi como Command Query Responsability Segregation, es un estilo arquitectónico en el que 
tenemos dos subsistemas diferenciados, uno responsable de los comandos, y otro responsable de las consultas.
Por comando entendemos un petición por parte del usuario u otro sistema, para realizar una operación
de negocio, que evolucione el sistema de un estado a otro. Cada uno de estos subsistemas tiene un 
diseño, modelo de información y mecanismo de persistencia diferente, optimizado para las tareas que
deba afrontar. 

En particular, CQRS solo debe usarse en partes específicas de un sistema (BoundedContext  DDD)
y no en el sistema en su conjunto. En esta forma de pensar, cada contexto limitado necesita sus propias
 decisiones sobre cómo debe modelarse. 

Tiene como atributos de calidad :  Escalabilidad,performance y simplicidad

- Event Driven Architecture.-
La Arquitectura dirigida por eventos, Event-driven architecture o EDA, es un patrón de arquitectura software que promueve la producción, detección, consumo de, y reacción a eventos. Un evento puede ser definido como un cambio significativo en un estado.
Son eventes arquitectonicos manejados por eventos los cuales trabajan mediante mensajes de colas  por servicios NServicesbus
con herramientas desde Pivotal con RabbitMQ localhost o por la nube .Esta arquitectura trabaja con mensajes,comandos con event storming.

- Microservices.-

Los Microservicios son una solución a las falencias de la arquitectura monolíticas.dado que las  Arquitecturas monolíticas son
de una sola pieza con un nivel de complejidad más alta.En caso de desplieguese hace toda la pieza.El fallo en una parte de la aplicación,provoca el fallo de toda la aplicación.

Es un enfoque para desarrollar una sola aplicación  como un conjunto de pequeños servicios, cada uno de los cuales se ejecuta en su propio proceso y se comunica  con mecanismos ligeros, a menudo una API de recursos HTTP. Estos servicios se basan en las capacidades comerciales y se pueden implementar de forma independiente mediante maquinaria de implementación totalmente automatizada. 

Los Microservicios tienes estas caracteristicas :
1)Son procesos independientes
2)Se comunican, predominantemente, sobre API. (API = Application Programming Interface. Es una capa de abstracción) o API REST 
3)Alto nivel de autonomía
4)Son pequeños, se enfocan en hacer una sola cosa y la hacen bien!

- Event Sourcing.-
Garantiza que cada cambio en el estado de una aplicación se capture en un objeto de evento, y que estos objetos
de evento se almacenen en la secuencia en que se aplicaron durante la misma vida útil que el estado de la aplicación.

Consideremos un ejemplo simple que ver con las notificaciones de envío.state storage  y event source  este ultimo nos brinda
mas detalles de la bitacora de lo sucedido en ese evento ta les como si la orden fue recibida ,confirmada,o si fue cancelada
por el usuario a diferencia de la informaicon que nos pueda dar state storage menos detallado .
