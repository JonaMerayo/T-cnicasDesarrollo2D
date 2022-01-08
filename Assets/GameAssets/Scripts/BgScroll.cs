using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{
    public float speed = 0.001f;
    private Renderer r;
    // Use this for initialization
    void Start()
    {
        r = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        r.material.mainTextureOffset = offset;
    }

}
