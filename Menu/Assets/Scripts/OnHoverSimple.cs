using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverSimple : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip PointerEnterSound;
    public void PointerEnter()
    {
        audioSource.PlayOneShot(PointerEnterSound);
    }

}
