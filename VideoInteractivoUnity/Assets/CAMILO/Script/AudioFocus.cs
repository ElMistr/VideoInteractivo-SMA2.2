using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFocus : MonoBehaviour
{
    public AudioSource sonido;

    bool activo = false;

    public void Focalizar()
    {
        activo = !activo;

        if (activo)
            sonido.volume = 1f;   // sube sonido
        else
            sonido.volume = 0.2f; // baja sonido
    }
}
