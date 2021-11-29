using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public GameObject[] guns;
    public GameObject[] droppedGuns;
    public Transform hand;
    public Transform DropZone;
    public bool pistolHere = true;
    public bool rifleHere = false;
    public bool PistolActive = true;
    public bool RifleActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Alpha1) && pistolHere == true)
       {
           guns[0].SetActive(true);
           guns[1].SetActive(false);
           PistolActive = true;
           RifleActive = false;
       }

       if(Input.GetKeyDown(KeyCode.Alpha2) && rifleHere == true)
       {
           guns[0].SetActive(false);
           guns[1].SetActive(true);
           PistolActive = false;
           RifleActive = true;
       }
       if(Input.GetKeyDown(KeyCode.Q) && PistolActive == true)
       {
           guns[0].SetActive(false);
           pistolHere = false;
           PistolActive = false;
           Instantiate(droppedGuns[0], DropZone.transform.position, this.transform.rotation);
       }
       if(Input.GetKeyDown(KeyCode.Q) && RifleActive == true)
       {
           guns[1].SetActive(false);
           rifleHere = false;
           RifleActive = false;
           Instantiate(droppedGuns[1], DropZone.transform.position, this.transform.rotation);
       }
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Secondary")) 
        {
            Destroy(other.gameObject);
            guns[1].SetActive(true);
            guns[0].SetActive(false);
            rifleHere = true;
            RifleActive = true;
        }
        if(other.gameObject.CompareTag("Pistol")) 
        {
            Destroy(other.gameObject);
            guns[0].SetActive(true);
            guns[1].SetActive(false);
            pistolHere = true;
            PistolActive = true;
        }
    }
}
