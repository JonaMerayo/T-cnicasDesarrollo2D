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
    
   • <b>Fondo con efecto parallax.</b> El efecto empieza cuando el jugador empieza a moverse, esto se debe comunicar mediante eventos. 
   
   El efecto parallax ya implementado y visto en el ejemplo anterior:
   
   ![04 BgMvtoPsjeMasRedu](https://user-images.githubusercontent.com/92461845/148617950-f34d6e1a-3367-4a56-a67c-d70ee21de879.gif)

   Se ha implementado colocando los sprites en diferentes niveles de orden en capas y añadiendo, a través del script, distintas velocidades de movimiento basadas en el movimiento de nuestro personaje. Dando a los elementos más alejados una velocidad menor respecto al personaje, y a los más cercanos una velocidad mayor. La parte del script que lo controlará es:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148618187-8eff4d6c-b059-48de-b54b-ec5a6f28c1b6.png)

   Donde podremos seleccionar el parallaxEffectMultiplier para cada elemento, para conseguir el efecto deseado (tener en cuenta que un 1 en esté parametro indicaría moverse a la misma velocidad que el personaje). 
   
   <br /><br />
   
   <b>Para iniciar el movimiento mediante eventos:</b>
   
   Se ha creado la función delegada en el script del player, que enviará una señal a los elementos suscritos en su primer movimiento (so controla que solo se envíe una vez, para optimización, con el booleano "yetMoved":
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644316-d5c3d58b-303e-40a8-a4e7-6d37186119be.png)

   ![imagen](https://user-images.githubusercontent.com/92461845/148644383-b0e9b046-bb75-4489-a17d-e6f6878159e9.png)
 
   
   Después he añadido la opción de selección de si esperar o no al inicio del movimiento del jugador mediante código, con el parámetro público Booleano "waitForPlayerStart". Si este está activo el elemento se suscribirá al elemento delegado y no iniciará su movimiento hasta recibir la señal. Para eso en el evento Start() añadiremos:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644504-e4f78ca7-1d94-45cc-bf91-322f941c7d6e.png)

   
   • Utilizar la técnica de pool de objetos para ir creando elementos en el juego sobre los que debe saltar el jugador evitándolos o para adquirir puntos si salta sobre ellos. 
    
   Por último, para ir Instanciando objetos sobre los que el jugador saltará, hemos añadido una Corrutina al GameManager (que también se puede suscribir al inicio de movimiento del jugador), está instanciará el GameObject elegido, en la posición indicada, a frecuencias según parametros, todo esto hecho público para poder ajustarlo en el editor:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644643-1806e99a-03cd-4011-a214-c103af45f088.png)
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644674-b37a71a5-64b7-4cd4-b0fe-1d827371c67a.png)

   Los objetos son, como se puede ver en el fragmento de código anterior, recogidos de un pool de objetos precreados llamado PoolManager:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644730-c0bb20cf-1407-473b-b0ed-cf9b7c1c8ae5.png)
   
   En este caso, el objeto será un prefab de un sprite que será destruido (devuelto al pool) saltando sobre él o pasado un tiempo de vida definible también en nuestro editor. Este prefab será nuestro vampiro:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644929-b7e93b10-e106-412d-bd1f-404d09f9bd27.png)

   He creado una función para Entregar(GetNext) y otra para volver a Recoger(ReturnToPool) los elementos en el PoolManager (y una opción de instanciar alguno a mayores si se quedase sin ellos, cosa que habría que intentar evitar en pro del mejor rendimiento de nuestro juego):
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148644820-3b46d172-18da-40bf-97f3-b33409cc0cdf.png)

   Ya hemos visto como el GameManager usa el método GetNext(). Para devolver el elemento al pool una vez lo hemos "destruido", en los Scripts de Destroy del prefab he añadido la función:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/148645051-16c5babb-a760-4ef0-a06b-f7d78abf4474.png)

   Con esto usaremos y devolveremos los elementos precreados en el PoolManager, en lugar de instanciarlos y destruirlos una y otra vez, mejorando notablemente el rendimiento del juego. También vemos en el gif que al saltar y "destruir" al vampiro obtenemos 10 puntos (borde superior izdo):

   ![05 PoolAndVamps](https://user-images.githubusercontent.com/92461845/148645256-b1d2002c-2174-4581-a78c-cafe6a5bff9d.gif)


