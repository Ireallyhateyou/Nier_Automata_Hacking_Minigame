using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;
using TMPro;

public class Hover_On_Buttons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public TextMeshProUGUI theText;
    public TextMeshProUGUI Square;
    public Color BaseColor;
    public Color HoveringColor;
    private void Start() {
        theText.color = BaseColor; //Or however you do your color
        Square.color = BaseColor;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = HoveringColor; //Or however you do your color
        Square.color = HoveringColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = BaseColor; //Or however you do your color
        Square.color = BaseColor;
    }
}