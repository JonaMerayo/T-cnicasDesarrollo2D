# TecnicasDesarrollo2D - Actividad 4 TÉCNICAS
Actividades relativas al Tema de desarrollo 2D de la asignatura de Fundamentos

Desarrollar ejemplos que implementen los siguientes casos: 

   • Scroll con movimiento del fondo. El personaje salta sobre objetos que aparecen en la escena. 
   
   <b>Para el scroll del fondo: </b>
   
   he creado una pequeña escena como ejemplo ("ExampleScrollFondo"), aplicando este efecto a las montañas del fondo que se desplazarán de derecha a izda, para dar efecto de movimie<b> nto. He subido al personaje a una plataforma inmovil para mejorar el realismo de la escena (si está en suelo no produce animación y se ve poco creíble):
   
   ![01 BackgroundScroll](https://user-images.githubusercontent.com/92461845/148611379-f646407f-22a8-4a0c-b8aa-37ed4901598e.gif)

   Para ello hemos añadido las montañas, como textura (con Wrap Moden en Repeat), a un Quad colocado al fondo en el eje Z. Para ello hemos actuado sobre el offset del Quad de la siguiente manera:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148611845-e525d324-1ecb-4409-8541-7ceca46b97bd.png)

   
   <b>Para los objetos sobre los que salta el jugador: </b>
   
   He añadido unas plataformas que se desplazan en el eje x de dcha a izda sobre las que puede saltar (a modo de ejemplo):
   
   ![02 BackgroundScrollAndPlatforms2](https://user-images.githubusercontent.com/92461845/148616704-7bb451be-2246-42e7-86f5-0cb2a9b4f203.gif)
   
   <br /><br />
    
   • Scroll con movimiento del personaje. El fondo se repite hasta que pare el juego. 
   
   Cuando el jugador se mueve el fondo se repetirá hasta el infinito (desde aquí se ha añadido los ejemplos a la escena "PlayerParallaxScene"):
   
   ![04 BgMvtoPsjeMasRedu](https://user-images.githubusercontent.com/92461845/148617368-4a022207-70ff-48ac-8ddb-08e3413f954f.gif)
   
   Para ello estiramos el fondo (poniendo los Sprites en modo (Draw Mode: Tiled) en su componente Sprite Renderer). Después les aplicamos el script para su repetición infinita:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148617769-6c271d40-9503-46fe-85c3-3f7fc22f4edc.png)

   En este caso, hemos puesto el Sky del cielo de fondo unido a la cámara y sin script, para que simlemente se desplace con esta, dado que es una parte del fondo con un solo color y sin elementos que puedan provocar incoherencias en el efecto deseado.
   
   <br /><br />
    
   • Fondo con efecto parallax. El efecto empieza cuando el jugador empieza a moverse, esto se debe comunicar mediante eventos. 
   
   El efecto parallax ya implementado y visto en el ejemplo anterior:
   
   ![04 BgMvtoPsjeMasRedu](https://user-images.githubusercontent.com/92461845/148617950-f34d6e1a-3367-4a56-a67c-d70ee21de879.gif)

   Se ha implementado colocando los sprites en diferentes niveles de orden en capas y añadiendo, a través del script, distintas velocidades de movimiento basadas en el movimiento de nuestro personaje. Dando a los elementos más alejados una velocidad menor respecto al personaje, y a los más cercanos una velocidad mayor. La parte del script que lo controlará es:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148618187-8eff4d6c-b059-48de-b54b-ec5a6f28c1b6.png)

   Donde podremos seleccionar el parallaxEffectMultiplier para cada elemento, para conseguir el efecto deseado (tener en cuenta que un 1 en esté parametro indicaría moverse a la misma velocidad que el personaje). 
   
   • Utilizar la técnica de pool de objetos para ir creando elementos en el juego sobre los que debe saltar el jugador evitándolos o para adquirir puntos si salta sobre ellos. 
    


