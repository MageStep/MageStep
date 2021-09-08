using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistController : MonoBehaviour
{
    public float lifeSpan = 0.2f;

    void Start() {
        Destroy(this.gameObject, lifeSpan);
    }

    // make sure collider is a trigger
    void OnTriggerEnter(Collider other) {
        Debug.Log("I've hit " + other.name);
        if(other.gameObject.CompareTag("Enemy")) {
            Debug.Log("I've hit an enemy!");
            Destroy(other.gameObject);
        }
    }
}
