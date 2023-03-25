using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;
using System.Text;
using TMPro;

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
