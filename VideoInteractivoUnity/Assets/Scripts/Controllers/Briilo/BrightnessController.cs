using UnityEngine;
using System.Collections;

public class BrightnessController : MonoBehaviour
{
    public CanvasGroup brightnessGroup;

    public float targetAlpha = 0.25f;

    public float fadeSpeed = 1.5f;

    public void IncreaseBrightness()
    {
        StopAllCoroutines();

        StartCoroutine(FadeBrightness(targetAlpha));
    }

    public void ResetBrightness()
    {
        StopAllCoroutines();

        StartCoroutine(FadeBrightness(0));
    }

    IEnumerator FadeBrightness(float target)
    {
        while (Mathf.Abs(brightnessGroup.alpha - target) > 0.01f)
        {
            brightnessGroup.alpha =
                Mathf.Lerp(
                    brightnessGroup.alpha,
                    target,
                    Time.deltaTime * fadeSpeed
                );

            yield return null;
        }

        brightnessGroup.alpha = target;
    }
}