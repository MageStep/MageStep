using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 10;
    public float jumpPower = 15;

    public float totalJumps = 3;



    private float jumpsLeft;

    public void Jump() {
        if(jumpsLeft > 0) {
        Debug.Log("Jumping");
        rb.AddForce(Vector3. up * jumpPower, ForceMode.Impulse);
        jumpsLeft -= 1;
        }
    }

    

    void Start(){
        rb = GetComponent<Rigidbody>();
        jumpsLeft = totalJumps;
    }

    void FixedUpdate() {
        rb.AddForce(Vector3.right * speed);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Ground")) {
            jumpsLeft = totalJumps;
        }
    }



}
