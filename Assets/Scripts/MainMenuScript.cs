using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;
using System.Text;
using TMPro;

/**
 * @Name    MainMenuScript
 * @Usage   Script that create a new Lobby, Room
 *          Also allow the player to enter an existing Room or Lobby
 * 
 * @Author  Andrea Storci aka AndrewDrink
 */
public class MainMenuScript : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField create;
    [SerializeField] TMP_InputField join;

    const string abc = "ABCDEFGHIJKLMNOPKRSTUVWXYZ";
    void Awake()
    {
        create.text = CreateLobbyCode();
        PhotonNetwork.ConnectUsingSettings();
    }

    public string CreateLobbyCode()
    {
        string code = "";
        for (int i = 0; i < 5; i++)
        {
            code += abc[Random.Range(0, abc.Length)];
        }
        Debug.Log(code);
        return code;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    /*public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }*/



    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene("Game");
    }
}
