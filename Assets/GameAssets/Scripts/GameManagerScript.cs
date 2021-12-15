using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //camera selection
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
        }

        else if (Input.GetKey(KeyCode.Alpha2))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }

        else if (Input.GetKey(KeyCode.Alpha3))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }

    }
}
