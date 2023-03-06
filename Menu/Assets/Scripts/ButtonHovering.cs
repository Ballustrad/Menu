using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonHovering : MonoBehaviour
{
    private TMP_Text buttonText;
    private Color initialColor;
    private bool isMouseOver = false;
    public float highlightIntensity = 1.2f; // Intensit� de la surbrillance
    public AudioSource audioSource; // R�f�rence � l'objet AudioSource

    void Start()
    {
        buttonText = GetComponent<TMP_Text>();
        initialColor = buttonText.color;
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
        buttonText.color = initialColor * highlightIntensity;
        if (audioSource != null) // On v�rifie si l'objet AudioSource est pr�sent
        {
            audioSource.Play(); // On joue l'effet sonore
        }
    }

    void OnMouseExit()
    {
        isMouseOver = false;
        buttonText.color = initialColor;
    }
}
