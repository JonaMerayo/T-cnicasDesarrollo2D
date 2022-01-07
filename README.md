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
   
   
   
   

   
   
    
   • Scroll con movimiento del personaje. El fondo se repite hasta que pare el juego. 
    
   • Fondo con efecto parallax. El efecto empieza cuando el jugador empieza a moverse, esto se debe comunicar mediante eventos. 
    
   • Utilizar la técnica de pool de objetos para ir creando elementos en el juego sobre los que debe saltar el jugador evitándolos o para adquirir puntos si salta sobre ellos. 
    
Seguir el procedimiento habitual para las entregas: enlace a repositorio github con gif animado de ejecución y scripts. Fichero zip en el campus virtual con el repositorio comprimido.

