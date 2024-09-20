using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProp : MonoBehaviour
{
    private float rotateProp = 15.0f;
    private float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotateProp * Time.deltaTime * speed);
    }
}