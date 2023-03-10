using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverTipImage : MonoBehaviour
{
    [Header("ImageTip")]
    public GameObject HoverTipPrefab;
    
    
    public void PointerEnter()
    {
       
        HoverTipPrefab.SetActive(true);

    }
    public void PointerExit()
    {
        HoverTipPrefab.SetActive(false);
    }
}
