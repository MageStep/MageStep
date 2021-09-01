using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapTest : MonoBehaviour
{
    Renderer m_Renderer;
    public float interval = 0.5f;
   
    int tapCount = 0;
    float lastTapTime = 0;
    bool cubeIsLarge = false;

    void Start()
    {
        Debug.Log("<color=green>DoubleTap Starting</color>");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            // combined assignment operator
            tapCount += 1;
            Debug.Log("<color=cyan>I've been tapped " + tapCount + " time(s)!</color>");

            // Time.realtimeSinceStartup
            if(lastTapTime > Time.realtimeSinceStartup - interval) {
                // doubleTap! Turns Red
                print("DoubleTap");
                if(cubeIsLarge) {
                    this.transform.localScale = Vector3.one;
                }
                else {
                    this.transform.localScale = Vector3.one * 2;
                }
                cubeIsLarge = !cubeIsLarge;
                lastTapTime = 0;
                GetComponent<Renderer>().material.color = Color.red;
                

            }
            else {
                print("SingleTap");
                lastTapTime = Time.realtimeSinceStartup;
                GetComponent<Renderer>().material.color = Color.blue;
            }
        }
        

    }
}
