using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgParallaxMvment : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxEffectMultiplier;
    [SerializeField] private bool infiniteHorizontal;
    [SerializeField] private bool infiniteVertical;

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private float textureSizeX;
    private float textureSizeY;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        Sprite thisSprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = thisSprite.texture;
        textureSizeX = texture.width / thisSprite.pixelsPerUnit;
        textureSizeY = texture.height / thisSprite.pixelsPerUnit;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * parallaxEffectMultiplier.x, deltaMovement.y * parallaxEffectMultiplier.y, 0);
        lastCameraPosition = cameraTransform.position;

        if (infiniteHorizontal)
        {
            if (Mathf.Abs(cameraTransform.position.x -transform.position.x) >= textureSizeX)
            {
                float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureSizeX;
                transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
            }
        }

        if (infiniteVertical)
        {
            if (Mathf.Abs(cameraTransform.position.y -transform.position.y) >= textureSizeY)
            {
                float offsetPositionY = (cameraTransform.position.y - transform.position.y) % textureSizeY;
                transform.position = new Vector3(transform.position.x, cameraTransform.position.y + offsetPositionY);
            }
        }

    }

}
