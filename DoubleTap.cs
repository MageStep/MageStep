using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTap : MonoBehaviour
{
    [Tooltip("The amount of time between taps to count as a double tap")]
    [Range(0.05f, 1f)]
    public float interval = 0.5f;

    float timer = 0;
    bool tapped = false;

    private PlayerMovement movement;

    void Start() {
        movement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(tapped) {
                Debug.Log("Double Tap");
                movement.Attack();
                tapped = false;
                timer = 0;
                GetComponent<Renderer>().material.color = Color.blue;
            }
            else {
                tapped = true;
                GetComponent<Renderer>().material.color = Color.red;
            }
        } //end of if(Input...)

        if(tapped) {
            timer += Time.deltaTime;
            if(timer > interval) {
                Debug.Log("Single Tap");
                movement.Jump();
                tapped = false;
                timer = 0;
            }
        }
    }
}
