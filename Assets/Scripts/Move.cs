using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velo = 2.0f;
    

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * velo * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * velo * Time.deltaTime, 0,  0);
    }
}
