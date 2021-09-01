using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator _Anim;
    // Start is called before the first frame update
    void Start()
    {
       _Anim = this.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _Anim.SetTrigger("DoorTrigger");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _Anim.SetTrigger("DoorTrigger");
        }
    }
}
