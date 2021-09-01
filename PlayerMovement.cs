using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 10;
    public float jumpPower = 15;

    public void Jump() {
        Debug.Log("Jumping");
        rb.AddForce(Vector3. up * jumpPower, ForceMode.Impulse);
    }
    public void Attack() {
        Debug.Log("Attacking");
    }

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        rb.AddForce(Vector3.right * speed);
    }


}
