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

   Se creará un elemento nuevo al que añadimos nuestros jugadores:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146189150-4b31ceb9-93ee-4e7c-9fb5-05966872e2eb.png)

   Quedando como sigue:
   
   ![imagen](https://user-images.githubusercontent.com/92461845/146189423-8585a747-2742-48be-9165-e5a78357121d.png)


• Crear una zona de confinamiento de A que abarque toda la escena. 
    
    
    
• Se debe crear una zona de confinamiento de la cámara B que abarque una parte de la escena. 
    
    
    
• Añadir un objeto que genere una vibración en la cámara cuando A choca con él 
    
    
    
• Seleccionar un conjunto de teclas que permitan hacer el cambio de la cámara de los personajes a la cámara que sigue al grupo. (Habilitar/Deshabilitar el gameobject de la cámara virtual) 
    
    
    
    
    
Extra:

• Generar una vibración en la cámara cada vez que se pulse la tecla de disparo. Agregar un perfil de ruido a la cámara, y modificar las propiedades de amplitud y frecuencia al component Noise 
    
    
    
    
    
    
    
    
   
