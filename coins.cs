﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public GameHandler GH;
    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
        GH.coins++;
        Destroy(other.gameObject);
        }
    }
}
