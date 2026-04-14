using UnityEngine;
using UnityEngine.Video;

public class StoryManager : MonoBehaviour
{
    public VideoPlayer video;

    public VideoClip intro;
    public VideoClip lago;
    public VideoClip bienestar;
    public VideoClip canchas;

    public GameObject panelDecisiones;

    bool yaMostro = false;

    void Start()
    {
        video.clip = intro;
        video.Play();
        panelDecisiones.SetActive(false);
    }

    void Update()
    {
        // Momento del guion: "¿Para dónde vamos?"
        if (!yaMostro && video.time >= 12f)
        {
            panelDecisiones.SetActive(true);
            yaMostro = true;
        }
    }

    public void IrLago()
    {
        CambiarVideo(lago);
    }

    public void IrBienestar()
    {
        CambiarVideo(bienestar);
    }

    public void IrCanchas()
    {
        CambiarVideo(canchas);
    }

    void CambiarVideo(VideoClip clip)
    {
        panelDecisiones.SetActive(false);
        video.Stop();
        video.clip = clip;
        video.Play();
        yaMostro = false;
    }
}