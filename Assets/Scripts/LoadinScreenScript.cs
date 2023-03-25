using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadinScreenScript : MonoBehaviour
{
    VideoPlayer videoplayer;

    void Awake()
    {
        videoplayer = GetComponent<VideoPlayer>();
        videoplayer.loopPointReached += CheckOver;
    } 


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadSceneAsync("start_menu");
    }
}
