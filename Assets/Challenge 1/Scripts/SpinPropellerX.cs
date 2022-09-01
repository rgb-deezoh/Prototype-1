using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float speed = 50.0f;
    private Vector3 rotate = new Vector3(0, 0, 90);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate * speed * Time.deltaTime); 
    }
}
