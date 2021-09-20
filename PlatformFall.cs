using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{

    Rigidbody rb;

    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        startingPosition = this.transform.position;
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            rb.isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
