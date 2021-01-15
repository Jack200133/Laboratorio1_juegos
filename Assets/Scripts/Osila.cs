using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osila : MonoBehaviour

{

    public float velo = 2.0f;
    public Vector3 Posog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Posog = new Vector3(-0.57f, 3.59f, -1.49f);
        transform.position = Posog + new Vector3(0, Mathf.Sin(Time.time), 0);
    }
}
