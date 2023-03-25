using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Com.AnDr3wS7oRc1.Pesissimisgame
{
    public class InitialVideo : MonoBehaviour
    {
        [SerializeField] GameObject video;
        [SerializeField] GameObject image;
        [SerializeField] GameObject canvas;
        AudioSource audio;
        VideoPlayer videoPlayer;
        //[SerializeField] GameObject text;
        //[SerializeField] Scene loadingPanel;
        //[SerializeField] Image imageLoading;
        //[SerializeField] CanvasGroup cg;
        bool isPlayerStarted = false;

        void Start()
        {
            audio       = canvas.GetComponent<AudioSource>();
            videoPlayer = video.GetComponent<VideoPlayer>();
            //DontDestroyOnLoad(loadingPanel);
            //DontDestroyOnLoad(loadingPanel.transform.parent);
        }

        void Update()
        {
            Debug.Log(audio.time);
            videoPlayer.loopPointReached += CheckOver;
            /*if (image.active == true)
            {
                text.SetActive(true);
            }*/

            if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
                videoPlayer.gameObject.SetActive(false);
                image.SetActive(true);
                audio.time = 27;

                //SceneManager.LoadSceneAsync("LoadingScreen");
                //Console.Write('ciao');
                Debug.Log("Ciao");
            }
        }

        void CheckOver(UnityEngine.Video.VideoPlayer vp)
        {
            vp.gameObject.SetActive(false);
            image.SetActive(true);
            //RawImage rm = image.GetComponent<RawImage>();
            /*while( rm.uvRect.y != 0)
            {
                rm.uvRect = new Rect(-0, Time.deltaTime * 0.01, 1.15, 0.99);

            }*/
        }

        /*IEnumerator LoadScene(string sceneName)
        {
            image.SetActive(false);
            text.SetActive(false);
            loadingPanel.SetActive(true);
            //imageLoading.transform.Rotate(0, 0, 2f, Space.Self);
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
            while (operation.isDone)
            {
                yield return null;
            }
            StartCoroutine(FadeOutLoading(2f));
        }*/

        /*IEnumerator FadeOutLoading(float duration)
        {
            float timePassed = 0.0f;
            float startAlpha = 0.0f;

            while (timePassed < duration)
            {
                timePassed += Time.deltaTime;
                cg.alpha = Mathf.Lerp(1f, 0f, timePassed / duration);
                yield return null;
            }
            loadingPanel.SetActive(false);
            cg.alpha = 1f;
        }*/
    }
}
