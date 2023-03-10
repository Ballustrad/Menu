using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicked : MonoBehaviour
{
    public AudioSource audioSource;

    public void playButton()
    {
        audioSource.Play();
        
    }
}
