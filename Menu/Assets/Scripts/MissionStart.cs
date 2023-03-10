using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionStart : MonoBehaviour
{
    public GameObject MissionStartPanel;
   

    public void ButtonPressed()
    {
        StartCoroutine(Coroutine1());   
    }
   IEnumerator Coroutine1()
    {
        MissionStartPanel.gameObject.SetActive(true);

        yield return  new WaitForSeconds(5);

        MissionStartPanel.gameObject.SetActive(false);
    }
}
