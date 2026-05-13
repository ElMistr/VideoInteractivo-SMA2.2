using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchController : MonoBehaviour
{

    [Header("UI")]

    public CanvasGroup glitchGroup;

    [Header("Configuración")]

    public float fadeSpeed = 2f;

    [Range(0, 1)]
    public float maxGlitch = 1f;

    private float currentGlitch = 0;

    // ACTIVAR GLITCH
    public void ActivateGlitch()
    {
        StopAllCoroutines();

        StartCoroutine(FadeGlitch(maxGlitch));
    }

    // DESACTIVAR TODO
    public void RemoveGlitch()
    {
        StopAllCoroutines();

        StartCoroutine(FadeGlitch(0));
    }

    // LIMPIAR PARCIAL
    public void ReduceGlitch(float amount)
    {
        currentGlitch -= amount;

        currentGlitch = Mathf.Clamp01(currentGlitch);

        glitchGroup.alpha = currentGlitch;
    }

    IEnumerator FadeGlitch(float target)
    {
        while (Mathf.Abs(currentGlitch - target) > 0.01f)
        {
            currentGlitch =
                Mathf.Lerp(
                    currentGlitch,
                    target,
                    Time.deltaTime * fadeSpeed
                );

            glitchGroup.alpha = currentGlitch;

            yield return null;
        }

        currentGlitch = target;

        glitchGroup.alpha = currentGlitch;
    }
}
