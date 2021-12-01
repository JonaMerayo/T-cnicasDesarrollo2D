# TecnicasDesarrollo2D. 01- Mapas y físicas.

En esta actividad realizaremos pruebas con el motor de físicas 2D y el editor de mapas 2D que proporciona Unity. Los componentes de mayor interés son:

    • Rigidbody: Acceso a las simulaciones físicas. 
    
    • Collider: Detección de las colisiones. 
    
Uno de los objetivos primordiales de la práctica es comprender los distintos tipos de GameObject desde el punto de vista físico y las interacciones que les están permitidas:

    • Dinámicos. 
    
    • Cinemáticos. 
    
    • Estáticos. 
    
Es imprescindible comprender las interacciones posibles entre los distintos tipos de objetos desde el punto de vista del efecto que tienen las colisiones y los eventos que pueden disparar.

Respecto al mapa de juego, se debe trabajar con los objetos:

• Grid

![imagen](https://user-images.githubusercontent.com/92461845/144261360-df4ab90a-14e9-49cf-a5ea-5dcec6fee537.png)

• Tilemap

![imagen](https://user-images.githubusercontent.com/92461845/144261435-c13174a7-2b7b-4efc-b387-c2e1de82a222.png)

• Tile Palette

![imagen](https://user-images.githubusercontent.com/92461845/144261808-9549368d-aefe-43f9-8dae-c1781f75039c.png)

• Tile map collider

![imagen](https://user-images.githubusercontent.com/92461845/144261977-78b796d2-763c-4df4-b4e4-c851f006bdce.png)

• Composite collider

En este caso he elegido la opción de map collider
    
    
    
<strong>Actividades a realizar:</strong>

Partiendo de la escena implementada para la tarea de Sprites:

Pensando en una adaptación 2D del juego, selecciona un Sprite que te sirva para representar el personaje. 

Mapa de Juego

1. Obtener assets que incorpores a tu proyecto para la generación de un mapa plano
    ![Tiles_64x64](https://user-images.githubusercontent.com/92461845/144262435-e4a5f60e-b400-4859-8c18-b1d15c007118.png)

2. Incorporar los recursos del punto 1 en el proyecto y generar al menos 2 paletas
    Se han generado 3 paletas:
    ![imagen](https://user-images.githubusercontent.com/92461845/144261834-b51852df-69e2-478e-91c7-5b55165228ef.png)

3. Generar un mapa convencional, incluir obstáculos y paredes.
    ![imagen](https://user-images.githubusercontent.com/92461845/144262191-0d04ae09-6462-4669-875e-c81ff2cbdd42.png)

 
</br>
</br>

Muestra Gameplay Mapa:
![GifActividadMapasYFisicas](https://user-images.githubusercontent.com/92461845/144260361-9483387e-7c8f-4c65-9983-9f1debc54f30.gif)   
</br>
    
    
    
    
    
    Lo que viene a continuación está pendiente de documentar:
1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. 
    
1. Ninguno de los objetos será físico. 
2. Un objeto tiene físicas y el otro no.
3. Ambos objetos tienen físicas.
4. Ambos objetos tienen físcas y uno de ellos tiene 10 veces más masa que el otro.
5. Un objeto tiene físicas y el otro es IsTrigger.
6. Ambos objetos son físicos y uno de ellos está marcado como IsTrigger.
7. Uno de los objetos es cinemático.
En el repositorio de las prácticas crear un documento Markdown en el que expliques los resultados obtenidos.


2. Incluir scripts para cada uno de los tipos de objetos anteriores y prográmales eventos OnCollision y OnTrigger que muestren un mensaje con cada uno de los tipos de evento en consola. 


3. Incorpora elementos físicos en tu escena que respondan a las siguientes restricciones:
1. Objeto estático que ejerce de barrera infranqueable. 
2. Zona en la que los objetos que caen en ella son impulsados hacia adelante. 
3. Objeto que es arrastrado por otro a una distancia fija. 
4. Objeto que al colisionar con otros sigue un comportamiento totalmente físico.
5. Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos.




