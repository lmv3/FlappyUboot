using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene("FlappyUboot");
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
           Application.Quit();
        }
    }
}
