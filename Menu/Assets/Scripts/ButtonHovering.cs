using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonHovering : MonoBehaviour
{
    private TMP_Text buttonText;
    private Color initialColor;
    private bool isMouseOver = false;
    public float highlightIntensity = 1.2f; // Intensité de la surbrillance
    public AudioSource audioSource; // Référence à l'objet AudioSource

    void Start()
    {
        buttonText = GetComponent<TMP_Text>();
        initialColor = buttonText.color;
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
        buttonText.color = initialColor * highlightIntensity;
        if (audioSource != null) // On vérifie si l'objet AudioSource est présent
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
