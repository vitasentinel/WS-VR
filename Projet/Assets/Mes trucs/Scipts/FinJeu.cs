using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinJeu : MonoBehaviour
{

    public GameObject manetteGauche;
    public GameObject manetteDroite;
    public Transform player;
    public Vector3 targetpos = new Vector3(0f, 4f, 0f);

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            manetteGauche.SetActive(false);
            manetteDroite.SetActive(false);
            player.transform.position = Vector3.Slerp(player.transform.position, targetpos, Time.deltaTime * 2f);
            FadeToWhite();
            
        }
    }


    [Header("Références")]
    public Image whiteOverlay;      // Assigne l'Image blanche dans l’inspecteur

    [Header("Paramètres")]
    public float fadeDuration = 1f; // Durée du fondu

    // Fondu vers blanc (alpha 0 -> 1)
    public void FadeToWhite()
    {
        StopAllCoroutines();
        StartCoroutine(FadeImageAlpha(1f));
    }

    // Fondu depuis blanc (alpha 1 -> 0)
    public void FadeFromWhite()
    {
        StopAllCoroutines();
        StartCoroutine(FadeImageAlpha(0f));
    }

    // Fondu vers le blanc, attente, puis fondu inverse
    public void FadeWhiteInHoldOut(float holdSeconds = 0.5f)
    {
        StopAllCoroutines();
        StartCoroutine(FadeInHoldOut(holdSeconds));
    }

    public IEnumerator FadeImageAlpha(float targetAlpha)
    {
        if (whiteOverlay == null) yield break;

        Color c = whiteOverlay.color;
        float startAlpha = c.a;
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float k = Mathf.Clamp01(t / fadeDuration);
            c.a = Mathf.Lerp(startAlpha, targetAlpha, k);
            whiteOverlay.color = c;
            yield return null;
        }

        c.a = targetAlpha;
        whiteOverlay.color = c;
    }

    private IEnumerator FadeInHoldOut(float holdSeconds)
    {
        // Vers blanc
        yield return FadeImageAlphaRoutine(1f);
        // Pause (blanc plein)
        yield return new WaitForSeconds(holdSeconds);
        // Retour depuis blanc
        yield return FadeImageAlphaRoutine(0f);
    }

    // Petite aide pour chaîner les fades dans une même coroutine
    private IEnumerator FadeImageAlphaRoutine(float targetAlpha)
    {
        float startAlpha = whiteOverlay.color.a;
        float t = 0f;
        Color c = whiteOverlay.color;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float k = Mathf.Clamp01(t / fadeDuration);
            c.a = Mathf.Lerp(startAlpha, targetAlpha, k);
            whiteOverlay.color = c;
            yield return null;
        }

        c.a = targetAlpha;
        whiteOverlay.color = c;
    }
}
