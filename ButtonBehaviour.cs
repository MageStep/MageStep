using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public bool buttonIsBad = true;
    public bool original = false;

    private ScoreKeeper manager;

    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<ScoreKeeper>();
        if(original == false)
        {
            StartCoroutine(EndOfLife());
        }
        // delete after 2-3 seconds
    }

    void Update()
    {
            // get larger
        this.transform.localScale += Vector3.one * Time.deltaTime;
        

        // lose health if bad. 
    }

    IEnumerator EndOfLife()
    {
        yield return new WaitForSeconds(Random.Range(2f, 3f));
        if(buttonIsBad)
        {
            //get reference to gameManager
            manager.ChangeHealth();
        }
        Destroy(this.gameObject);
    }

    public void Pressed() {
        if(buttonIsBad) {
            Debug.Log("We've destroyed a bad button.");
        } else {
            Debug.Log("Oh No! We've destroyed a good button.");
        }
        Destroy(this.gameObject);
    }

    
}
