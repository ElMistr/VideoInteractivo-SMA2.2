using UnityEngine;
using System.Collections;

public class VignetteController : MonoBehaviour
{
    public CanvasGroup vignetteGroup;

    public float fadeSpeed = 2f;

    public void ShowVignette()
    {
        StopAllCoroutines();

        StartCoroutine(FadeIn());
    }

    public void HideVignette()
    {
        StopAllCoroutines();

        StartCoroutine(FadeOut());
    }

    IEnumerator FadeIn()
    {
        while (vignetteGroup.alpha < 1)
        {
            vignetteGroup.alpha += Time.deltaTime * fadeSpeed;

            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        while (vignetteGroup.alpha > 0)
        {
            vignetteGroup.alpha -= Time.deltaTime * fadeSpeed;

            yield return null;
        }
    }
}