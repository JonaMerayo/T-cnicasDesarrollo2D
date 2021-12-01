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
</br></br></br></br></br>
    
    
    
    
    
    Lo que viene a continuación está pendiente de documentar:
1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. 
    
• Ninguno de los objetos será físico. 

Ninguno de los dos se desplazará y quedarán estáticos al no ser afectado por la gravedad.

![GifLaboratorioFísicas1](https://user-images.githubusercontent.com/92461845/144283102-1f1e9036-3b59-42b1-8dac-22c383ab0eef.gif)

• Un objeto tiene físicas y el otro no.

En este caso, al añadir un Rigidbody 2D a la madera, está cae al verse afectada por la gravedad.

![GifLaboratorioFísicas2](https://user-images.githubusercontent.com/92461845/144283474-549873e2-fe47-4888-be48-6f9d81dcfe8e.gif)

• Ambos objetos tienen físicas.

También veremos como cae la Luna (asteroide).

![GifLaboratorioFísicas3](https://user-images.githubusercontent.com/92461845/144283830-0b3ee11a-8866-42d5-9829-3dc7f26de2b2.gif)

• Ambos objetos tienen físcas y uno de ellos tiene 10 veces más masa que el otro.

El nuevo objeto, más pesado, se modifica añadiendo 10 veces la masa inicial de 1 en la parte del Rigidbody.

![imagen](https://user-images.githubusercontent.com/92461845/144284381-241e528b-96ac-4098-8365-c05e9071f5d9.png)

Realmente, incluso dejandolos caer a mayor altura, no se aprecia una diferencia clara en la caida.

![GifLaboratorioFísicas4](https://user-images.githubusercontent.com/92461845/144285395-1e9c10fd-969d-4bf7-baf7-1c68fe16d8b1.gif)

• Un objeto tiene físicas y el otro es IsTrigger.

Eliminamos el Rigidbody 2D de la madera y le añadimos un collider Trigger:

![imagen](https://user-images.githubusercontent.com/92461845/144286106-7d1988aa-5e91-4ea5-adfc-d03ef7ef0e6f.png)

Esta se mantendrá en el aire y no reacccionará a la colisión (aunque si la detectará):

![GifLaboratorioFísicas5](https://user-images.githubusercontent.com/92461845/144286309-65af8e74-138e-4f9e-b7a0-8d959f188060.gif)

• Ambos objetos son físicos y uno de ellos está marcado como IsTrigger.

En este caso he cogido desde el punto anterior y he devuelto el Rigidbody a la madera. Para ver colisión, he aumentado la Gravity scale del peso y, además le he añadido un collider no Trigger, el de la madera se mantiene Trigger. El resultado será:

![GifLaboratorioFísicas6](https://user-images.githubusercontent.com/92461845/144289528-99038b24-a9b8-45a4-ba27-1532aebfa71d.gif)

• Uno de los objetos es cinemático.

En la misma madera, al marcar el objeto como Kinematic, se desmarcan las opciones del Collider:

![imagen](https://user-images.githubusercontent.com/92461845/144290604-f62726da-402c-49cf-9ba2-982ee1cf8f13.png)

Teniendo en cuenta que ambos objetos tienen collider y ninguno en Trigger, el resultado es:

![GifLaboratorioFísicas7](https://user-images.githubusercontent.com/92461845/144291110-c11fce0b-87b5-4e28-8c19-caad6faf76a6.gif)

</br></br></br></br></br>
2. Incluir scripts para cada uno de los tipos de objetos anteriores y prográmales eventos OnCollision y OnTrigger que muestren un mensaje con cada uno de los tipos de evento en consola. 

En los primeros laboratorios no ha habido collisiones, por lo cual no se detecta ni Trigger ni Collision en ninguno.

Añado tanto al peso como a la madera un script para detectar ambos eventos al entrar en ellos (Enter), con log identificativo en pantalla:

![imagen](https://user-images.githubusercontent.com/92461845/144330826-47d5779f-52d7-4f68-b9cd-b98bacdad53a.png)

Y ejecuto las pruebas en los supuestos con colisión:

• Un objeto tiene físicas y el otro es IsTrigger.

Ambos detectan el Trigger pero ninguno la colisión física:

![imagen](https://user-images.githubusercontent.com/92461845/144331148-dbbbedf4-31ae-44dc-9958-e4b2645f9bab.png)

• Ambos objetos son físicos y uno de ellos está marcado como IsTrigger.

Nuevamente ambos detectan el Trigger pero ninguno la colisión física:

![imagen](https://user-images.githubusercontent.com/92461845/144331250-62fe493a-f3b4-42cc-b413-3a2e47f5f0b2.png)

• Uno de los objetos es cinemático.

Ambos detectan la colisión física:

![imagen](https://user-images.githubusercontent.com/92461845/144330699-0c821fdc-1ee4-42c7-aac5-872a67f87df6.png)




</br></br></br></br></br>
3. Incorpora elementos físicos en tu escena que respondan a las siguientes restricciones:

• Objeto estático que ejerce de barrera infranqueable. 

• Zona en la que los objetos que caen en ella son impulsados hacia adelante. 

• Objeto que es arrastrado por otro a una distancia fija. 

• Objeto que al colisionar con otros sigue un comportamiento totalmente físico.

• Incluye dos capas que asignes a diferentes tipos de objetos y que permita evitar colisiones entre ellos.






