using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check_click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 1 || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadSceneAsync("LoadingScreen");
        }
    }
}
