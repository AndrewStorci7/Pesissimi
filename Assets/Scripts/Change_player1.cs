using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * @Name    Change_player
 * @Usage   Script show every player and svae the choosen one
 * 
 * @Author  Andrea Storci aka AndrewDrink
 */
public class Change_player1 : MonoBehaviour {

    [SerializeField] GameObject g;
    [SerializeField] GameObject btn_f;
    [SerializeField] GameObject btn_b;

    public void changePlayerFastf( GameObject a ) {
        
        g.SetActive( false );
        a.SetActive( true );
    }

    public void changePlayerBackf( GameObject a ) {
        
        g.SetActive( false );
        a.SetActive( true );
    }
}
