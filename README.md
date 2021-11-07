# TecnicasDesarrollo2D. 01-Introducción a los sprites.

En esta actividad realizaremos pruebas con las herramientas para el manejo y edición de Sprites en un juego 2D que proporciona Unity. Los Sprites son uno de los elementos básicos en las aplicaciones 2D en Unity. Tienen componente Transform, como todo objeto en la escena y un componente Renderer.
    
• Podemos utilizar Sprites o Atlas de Sprites como Assets. 
    
• Las animaciones de los elementos de la escena se generan a partir de un conjunto de Sprites. Si las imágenes de una animación están en un Atlas deben ser extraídas antes de generar la animación. 
    
• Los Sprites se pueden mover mediante el Transform o mediante Físicas. En esta práctica seguimos moviendo objetos utilizando el Transform. 

<strong>Descripción entrega</strong>:

En esta ocasión, como primer contacto son los sprites y juegos 2D, se ha creado una pequeña demo de mecánica muy sencilla, con Assets obtenidos de la AssetStore. La idea era probar las animaciones y las máquinas de estados, así como iniciarse en los scprits para desarrollo de juegos en dos dimensiones.
    
<strong>Actividades a realizar</strong>:

1. Obtener assets que incorpores a tu proyecto: Sprites individuales y Atlas de Sprites. 

Se ha usado un buen número de Sprites individuales para animar los arqueros protagonistas de la actividad:

![CapturaSpritesArquero](https://user-images.githubusercontent.com/92461845/140629880-be73809a-8996-4d4a-b713-826f9e4187a4.PNG)

Como ejemplo de Atlas de Sprites he buscado por la web un atlas para una exlosión que sufrirá el arquero de la derecha de la pantalla:

![CapturaSpritesAtlasExplos](https://user-images.githubusercontent.com/92461845/140629917-ca89e9ac-3c15-4585-ab0a-d1e03d38fd0a.PNG)
    
2. Incorporar los recursos del punto 1 en el proyecto y generar al menos 2 animaciones para uno de los personajes. 

El personaje principal tiene varias animaciones, como ataque, caminar... Los dos "Enemigos" tienen ambos animación Idle, LookingAround para vigilar y animación cuando son vencidos.
    
3. Busca en el inspector de objetos la propiedad Flip y comprueba qué pasa al activarla desactivarla en alguno de los ejes. 

Se comprueba y se usa más tarde esta propiedad, desde el Script del protagonista, para sus cambios de dirección en eje X.
    
4. Mover uno de los personajes con el eje horizontal virtual que definen las teclas de flechas.

Se aplica este movimiento al protagonista o personaje del jugador (arquero del centro de la pantalla).
    
5. Hacer saltar el personaje y cambiar de dirección cuando se pulsa la barra espaciadora.

Aplicado, al pulsar la barra este salta y cambia de dirección, se puede ver en animación Gameplay.
    
6. Crear una animación para otro personaje, que se active cuando el jugador pulse la tecla x.

Al pulsar dicha tecla X, los arqueros enemigos ejecutan animación de mirar hacia los lados y vuelven a la animación original (Idle).
    
7. Agregar un objeto que al estar el personaje a una distancia menor que un umbral se active una animación, por ejemplo explosión o cualquier otra que venga en el atlas de sprites.
    
Al acercarse el protagonista a las columnas, si mira en la dirección adecuada y dispara, se ejecuta animación de explosión de los elementos que caen sobre los enemigos y las animaciones de "caida definitiva" de dichos enemigos.

</br>
</br>
</br>

Muestra Gameplay:

![SpritesGif](https://user-images.githubusercontent.com/92461845/140630065-335c9e9c-542a-4276-8bd2-55adebf3422e.gif)

