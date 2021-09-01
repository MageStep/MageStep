using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{
     public GameObject aiPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)) {
            // create a copy
            GameObject copy = Instantiate(aiPrefab);
            //move it to spawner's location
            copy.transform.position = this.transform.position;
            //move it up above spawner
            copy.transform.Translate(Vector3.up);

        }
    }
}
