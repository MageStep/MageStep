using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{

    public AnimationCurve curve;

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
            StartCoroutine(ResetPlatform());
        }
    }

    IEnumerator ResetPlatform()
    {
        yield return new WaitForSeconds(1);             // platform has a delay before falling
        rb.isKinematic = false;                         // let the platform fall
        yield return new WaitForSeconds(3);             // wait 3 seconds
        this.transform.position = startingPosition;  
          //reset the platform position   
        rb.isKinematic = true; 
        StartCoroutine(LerpPosition());                         // make the platform not move
    }

    IEnumerator LerpPosition() {
        Vector3 endPosition = this.transform.position;

        float elapsedTime = 0f;

        float returnInterval = 1f;

        while(elapsedTime < returnInterval) 
        {
            this.transform.position = Vector3.Lerp(endPosition, startingPosition, curve.Evaluate(elapsedTime / returnInterval));
            yield return null;
        }

    }

}

    