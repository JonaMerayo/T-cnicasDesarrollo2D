# TecnicasDesarrollo2D. 03- Controlador de cámara.

Desarrollar una escena 2D en la que se incluyan dos personajes A, B que se controlan desde el teclado. Se deben contemplar los siguientes requisitos:

Escena base:

![imagen](https://user-images.githubusercontent.com/92461845/146187809-c00cf590-1370-4adf-983b-7c20acccced6.png)


• Cámara con seguimiento al personaje A. Se debe configurar el seguimiento hacia adelante. Esta cámara es la que debe tener la máxima prioridad. 
    
   Se ha creado una VCamA para seguir al personaje A, para ello se le ha puesto este personaje en Follow. Para configurar el seguimiento hacia adelante se ha modificado el Screen X a 0.2 (provocando un enfoque delantero sobre el personaje, se le ha dado prioridad 10.
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146188485-c329e1e5-c44d-4f25-80d8-1a485267b96d.png)

    
• Cámara con seguimiento al personaje B. Debe configurarse una zona de seguimiento del personaje B más amplia que la de A. 
    
   Se ha creado una VCamB para seguir al personaje B, para ello se le ha puesto este personaje en Follow. Para ampliar la zona de seguimiento he ampliado el campo "Field of view" a 80 (en VCamA estaba en 60).
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146189739-ad2f5b98-0a7a-495a-8401-399e968af4eb.png)

    
• Cámara que hace el seguimiento de ambos personajes. 
    
   Se ha creado una VCamBoth  para seguir a ambos personajes, para ello, en Follow, hacemos click en engranaje y seleccionamos "Convert to target group":
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146188982-4b6adfa8-0c9d-4387-8d7b-d318493cda5f.png)

   Se creará un elemento nuevo al que añadimos nuestros jugadores (más adelante he quitado a los jugadores como hijos de esté elemento dado que genera errores, solo añadirlos en el Inspector de elementos):
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146202448-eb63b233-bd0f-4660-ba0f-414fcf031185.png)

   Quedando como sigue:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146189423-8585a747-2742-48be-9165-e5a78357121d.png)


• Crear una zona de confinamiento de A que abarque toda la escena. 
    
  Primero, para crear los límites añadimos un EmptyObject con CompositeCollider2D de tipo polígono,	agregamos un Rigidbody Static y un BoxCollider2D que se ajuste a la zona de conﬁnamiento marcado (la he ampliado hasta los límites de visualización de la escena):   
  
  ![imagen](https://user-images.githubusercontent.com/92461845/146191737-ae14d057-fecc-43b3-af4c-fd0725146371.png)

  En la VCamA añadiremos una extensión, en la parte inferior, llamada "Cinemachine confiner" y como elemento "Bounding Shape 2D" le añadiremos el Confiner creado en el paso anterior:
  
  ![imagen](https://user-images.githubusercontent.com/92461845/146193964-3b097599-f0ae-43b4-b822-744207e1d1ed.png)


• Se debe crear una zona de confinamiento de la cámara B que abarque una parte de la escena. 
    
  Siguiendo los pasos anteriores creo el ConfinerB, reduciendo el tamaño del collider para que abarque una zona de escena menor:
  
  ![imagen](https://user-images.githubusercontent.com/92461845/146195426-bd27a36d-1806-4dcc-adb4-8499f9176749.png)

   Y añado el mismo a VCamB:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146195722-fc53a3e1-d0ff-4fe8-8523-f6c49b61b45d.png)
   
    
• Añadir un objeto que genere una vibración en la cámara cuando A choca con él 
    
   Primero añado una caja a la que le coloco un elemento "Cinemachine Collision Impulse Source" al que añado un Noise modificado por mi (explicado en último paso de la actividad), como se puede apreciar:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146239804-05357d9a-9a46-46f3-a978-cafa8dc74221.png)
   
  Una vez que hacemos que la caja emita el impulso al colisionar con el PlayerA (especificado en el "Impulse Channel"), deberemos añadir un listener en la cámara virtual elegida para que actue al recibir el impulso de la fuente (caja). Para ello añado la extensión "Cinemachine Impulse Listener" a dicha cámara:
  
  ![imagen](https://user-images.githubusercontent.com/92461845/146243287-62e76129-1ecf-4631-a0e6-545d3be41ca5.png)

Comprobamos que se ejecuta la vibración al contacto con PlayerA:

   ![GifImpulsoCamara](https://user-images.githubusercontent.com/92461845/146244010-133ce66f-fa1e-4f0f-9fc2-35c1ca25c7a0.gif)

      
• Seleccionar un conjunto de teclas que permitan hacer el cambio de la cámara de los personajes a la cámara que sigue al grupo. (Habilitar/Deshabilitar el gameobject de la cámara virtual) 
    
    
    
    
    
Extra:

• Generar una vibración en la cámara cada vez que se pulse la tecla de disparo. Agregar un perfil de ruido a la cámara, y modificar las propiedades de amplitud y frecuencia al component Noise 
    
    
    
    
    
    
    
    
   
