using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilaciones : MonoBehaviour
{

    public float amplitud = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(Time.time), 1) * amplitud;
    }
}
