using UnityEngine;
using System.Collections;

public class Biblio : MonoBehaviour
{
    public GameObject library;          // La bibliothèque à déplacer
    public Collider[] bookZones;        // Les 4 zones de déclenchement
    public string[] bookTags;           // Les tags des 4 livres

    public float moveDistance = 5f;     // Distance de déplacement vers la droite
    public float moveDuration = 2f;     // Durée de l'animation (en secondes)

    private bool[] booksPlaced;         // État de chaque livre
    private bool hasMoved = false;      // Empêche de rejouer l'animation

    void Start()
    {
        booksPlaced = new bool[bookZones.Length];
    }

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < bookZones.Length; i++)
        {
            if (other.CompareTag(bookTags[i]) && other == bookZones[i])
            {
                booksPlaced[i] = true;
                CheckAllBooksPlaced();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < bookZones.Length; i++)
        {
            if (other.CompareTag(bookTags[i]) && other == bookZones[i])
            {
                booksPlaced[i] = false;
            }
        }
    }

    void CheckAllBooksPlaced()
    {
        foreach (bool placed in booksPlaced)
        {
            if (!placed) return; // Si un livre manque, on ne bouge pas
        }

        if (!hasMoved) // Déclenche une seule fois
        {
            StartCoroutine(MoveLibrarySmooth());
            hasMoved = true;
        }
    }

    IEnumerator MoveLibrarySmooth()
    {
        Vector3 startPos = library.transform.position;
        Vector3 endPos = startPos + Vector3.right * moveDistance;

        float elapsed = 0f;

        while (elapsed < moveDuration)
        {
            library.transform.position = Vector3.Lerp(startPos, endPos, elapsed / moveDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        library.transform.position = endPos; // Assure la position finale
    }
}
