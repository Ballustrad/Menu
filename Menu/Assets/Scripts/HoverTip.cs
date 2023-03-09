using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip : MonoBehaviour
{
    [Header("TextTip")]
    public GameObject HoverTipPrefab;
    public TMPro.TextMeshProUGUI textWindow;
    public string tipToShow;
    public void PointerEnter()
    {
       textWindow.text = tipToShow;
       HoverTipPrefab.SetActive(true);
       
    }
    public void PointerExit()
    {
        HoverTipPrefab.SetActive(false);
    }

}
