using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    public float velocidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.localScale += Vector3.one * velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.X))
        {
            transform.localScale -= Vector3.one * velocidad * Time.deltaTime;
        }
    }
}
