using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    private Vector3 initialScale;
    private bool isMouseOver = false;
    public float scaleFactor = 1.2f; // Facteur d'échelle de l'objet
    public AudioSource audioSource; // Référence à l'objet AudioSource

    void Start()
    {
        initialScale = transform.localScale;
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
        transform.localScale = initialScale * scaleFactor;
        if (audioSource != null) // On vérifie si l'objet AudioSource est présent
        {
            audioSource.Play(); // On joue l'effet sonore
        }
    }

    void OnMouseExit()
    {
        isMouseOver = false;
        transform.localScale = initialScale;
    }

    void Update()
    {
        if (isMouseOver && Input.GetMouseButtonDown(0)) // Si la souris est sur l'objet et que l'utilisateur clique dessus
        {
            transform.localScale = initialScale; // On remet la taille initiale de l'objet
        }
    }
}
