using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using System.Collections;

public class EndGame : MonoBehaviour
{
    [Header("Références")]
    public Transform pillar;                  // Le pilier à surélever
    public Transform ceilingPanel;            // Le panneau du plafond
    public Transform ceilingPivot;            // Pivot (empty placé sur le bord du plafond)
    public CanvasGroup fadeCanvas;            // Canvas avec une Image blanche plein écran
    public GameObject xrOrigin;               // XR Origin (Player)

    [Header("Manettes (GameObjects)")]
    public GameObject leftController;
    public GameObject rightController;

    [Header("Animation")]
    public float pillarRiseHeight = 3f;       // Hauteur de surélévation
    public float pillarRiseDuration = 3f;     // Durée de l’animation
    public float ceilingOpenAngle = 120f;     // Angle d’ouverture du panneau
    public float ceilingOpenDuration = 3f;    // Durée de l’ouverture
    public float fadeDuration = 5f;           // Durée du fondu blanc

    private bool triggered = false;
    private Vector3 lockedPosition;           // Position verrouillée du joueur

    void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.CompareTag("Player"))
        {
            triggered = true;

            // Désactive les manettes
            if (leftController != null) leftController.SetActive(false);
            if (rightController != null) rightController.SetActive(false);

            // Verrouille la position du joueur
            if (xrOrigin != null) lockedPosition = xrOrigin.transform.position;

            // Lance les animations
            StartCoroutine(RaisePillar());
            StartCoroutine(OpenCeilingPanel());
            StartCoroutine(FadeToWhite());
        }
    }

    void LateUpdate()
    {
        // Si le joueur est sur le pilier, on bloque sa position
        if (triggered && xrOrigin != null)
        {
            xrOrigin.transform.position = lockedPosition;
        }
    }

    IEnumerator RaisePillar()
    {
        Vector3 startPos = pillar.position;
        Vector3 endPos = startPos + Vector3.up * pillarRiseHeight;

        float elapsed = 0f;
        while (elapsed < pillarRiseDuration)
        {
            pillar.position = Vector3.Lerp(startPos, endPos, elapsed / pillarRiseDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        pillar.position = endPos;
    }

    IEnumerator OpenCeilingPanel()
    {
        float elapsed = 0f;
        float lastAngle = 0f;

        while (elapsed < ceilingOpenDuration)
        {
            float t = elapsed / ceilingOpenDuration;
            float angle = Mathf.Lerp(0f, ceilingOpenAngle, t);

            // Rotation incrémentale autour du pivot
            ceilingPanel.RotateAround(ceilingPivot.position, Vector3.right, angle - lastAngle);
            lastAngle = angle;

            elapsed += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator FadeToWhite()
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            fadeCanvas.alpha = Mathf.Lerp(0f, 1f, elapsed / fadeDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        fadeCanvas.alpha = 1f;
    }
}
