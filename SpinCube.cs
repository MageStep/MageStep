using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{

    Vector3 spinDirection = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        print("I exist!");
        print("Starting SpinCube script.");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) {
            GetComponent<Renderer>().material.color = Random.ColorHSV();
            spinDirection = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        }
        
        transform.Rotate(spinDirection);
    }
}
