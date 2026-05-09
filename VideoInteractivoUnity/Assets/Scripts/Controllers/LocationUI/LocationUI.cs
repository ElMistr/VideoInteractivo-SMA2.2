using UnityEngine;
using TMPro;
using System.Collections;

public class LocationUI : MonoBehaviour
{
    [Header("UI")]

    public GameObject panel;

    public TextMeshProUGUI locationText;

    [Header("Configuración")]

    public float duration = 3f;

    void Start()
    {
        panel.SetActive(false);
    }

    public void ShowLocation(string nombreLugar)
    {
        StopAllCoroutines();

        StartCoroutine(ShowRoutine(nombreLugar));
    }

    IEnumerator ShowRoutine(string nombreLugar)
    {
        // Mostrar panel
        panel.SetActive(true);

        // Cambiar texto
        locationText.text = nombreLugar;

        // Esperar
        yield return new WaitForSeconds(duration);

        // Ocultar
        panel.SetActive(false);
    }
}