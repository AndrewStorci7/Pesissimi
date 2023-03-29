using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @Name    SmoothImage
 * @Usage   Script that change th eposition of a RectTransform on loading scene
 * 
 * @Author  Andrea Storci aka AndrewDrink
 */ 
public class SmoothImage : MonoBehaviour
{
    [SerializeField] Image img;
    RectTransform rect;
    Vector3 pos = new Vector3(0, 780, 0);
    Vector3 pos2 = new Vector3(0, -780, 0);
    bool active = false;
    bool activeFn = false;
    float speed = 3f;

    public void ViewPanel()
    {
        rect = img.GetComponent<RectTransform>();
        if(!active)
        {
            while(rect.position.y != 0)
            {
                pos.y -= Time.deltaTime * speed;
                rect.position = pos;
            }
            active = true;
        } else
        {
            while(rect.position.y != 780)
            {
                pos2.y += Time.deltaTime - speed;
                rect.position = pos2;
            }
            active = false;
        }
    }
}
