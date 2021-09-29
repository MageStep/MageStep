using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void ChangeScene(int index) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }
}