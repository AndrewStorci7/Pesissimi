using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SmoothRGB : MonoBehaviour
{
    Color targetColor;
    Image btn;
    RawImage raw;
    TextMeshProUGUI text;
    [SerializeField] GameObject songContainer;
    private string nameObject;
    float alpha, alpha2;
    float constRGB = 0.1960784f;
    double valToAdd = 0.003;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameObject = songContainer.name;
        alpha = alpha == 0.6980f ? alpha : alpha + 0.005f;
        alpha2 = alpha2 == 0.8509804f ? alpha : alpha + 0.005f;
        switch (nameObject)
        {
            case "Bg":
                raw = songContainer.GetComponent<RawImage>();
                targetColor = new Color(raw.color.r, raw.color.g, raw.color.b, alpha2);
                raw.color = targetColor;
                break;
            case "SongName":
                text = songContainer.GetComponent<TextMeshProUGUI>();
                targetColor = new Color(text.color.r, text.color.g, text.color.b, alpha2);
                text.color = targetColor;
                break;
            case "Author":
                text = songContainer.GetComponent<TextMeshProUGUI>();
                targetColor = new Color(text.color.r, text.color.g, text.color.b, alpha2);
                text.color = targetColor;
                break;
            case "VideoPlayer":
                raw = songContainer.GetComponent<RawImage>();
                targetColor = new Color(raw.color.r, raw.color.g, raw.color.b, alpha2);
                raw.color = targetColor;
                break;
            case "Impostazioni":
                btn = songContainer.GetComponent<Image>();
                targetColor = new Color(btn.color.r, btn.color.g, btn.color.b, alpha);
                btn.color = targetColor;
                break;
            case "Esci":
                btn = songContainer.GetComponent<Image>();
                targetColor = new Color(btn.color.r, btn.color.g, btn.color.b, alpha);
                btn.color = targetColor; 
                break;
            case "Play":
                btn = songContainer.GetComponent<Image>();
                targetColor = new Color(btn.color.r, btn.color.g, btn.color.b, alpha);
                btn.color = targetColor;
                break;
            case "textImp":
                text = songContainer.GetComponent<TextMeshProUGUI>();
                targetColor = new Color(text.color.r, text.color.g, text.color.b, alpha);
                text.color = targetColor;
                break;
            case "textPlay":
                text = songContainer.GetComponent<TextMeshProUGUI>();
                targetColor = new Color(text.color.r, text.color.g, text.color.b, alpha);
                text.color = targetColor;
                break;
            case "textEsci":
                text = songContainer.GetComponent<TextMeshProUGUI>();
                targetColor = new Color(text.color.r, text.color.g, text.color.b, alpha);
                text.color = targetColor;
                break;
        }
    }

    private void Fn_smooth()
    {

    }
}
