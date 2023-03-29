using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/**
 * @Name    MusicPlayerMenu
 * @Usage   Script that controls the progress of the initial video
 * 
 * @Author  Andrea Storci aka AndrewDrink
 */
public class MusicPlayerMenu : MonoBehaviour {

    public AudioClip[] clips;
    private AudioSource audioSource;
    [SerializeField] GameObject songName;
    TextMeshProUGUI text;
    string outText;

    // Start is called before the first frame update
    void Start() {

        text = songName.GetComponent<TextMeshProUGUI>();
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip() {
        return clips[Random.Range(0, clips.Length)];
    }

    // Update is called once per frame
    void Update() {

        if ( !audioSource.isPlaying ) {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
            outText = Truncate(audioSource.clip.ToString());
            text.text = outText;
        }
    }

    private string Truncate( string str ) {

        string str_trunc = "";
        char c;
        for ( int i = 0; i < str.Length; i++ ) {
            c = str[i];
            if ( c != '.' )
                str_trunc += c; 
            else
                break;
        }
        return str_trunc;
    }
}
