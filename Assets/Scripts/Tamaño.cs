using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamaño : MonoBehaviour
{
    public float velo = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
            transform.localScale += new Vector3(velo * Time.deltaTime,
                                                velo * Time.deltaTime,
                                                velo * Time.deltaTime
                                                );
        if (Input.GetKey(KeyCode.N))
            transform.localScale -= new Vector3(velo * Time.deltaTime,
                                                velo * Time.deltaTime,
                                                velo * Time.deltaTime
                                                );
    }
}
