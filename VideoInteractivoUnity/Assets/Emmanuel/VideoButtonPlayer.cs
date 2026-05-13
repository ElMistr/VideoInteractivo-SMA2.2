using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoButtonPlayer : MonoBehaviour
{
    [Header("Video")]
    public VideoPlayer videoPlayer;

    [Header("Botón")]
    public Button playButton;

    void Start()
    {
        // Añade el evento al botón
        playButton.onClick.AddListener(PlayVideo);
    }

    void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }
}