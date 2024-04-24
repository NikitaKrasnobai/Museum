using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Film2Film : MonoBehaviour
{
    public GameObject FilmCube;
    public Canvas FilmCanvas;
    public VideoPlayer videoPlayer;
    string videoUrl = "";


    // Start is called before the first frame update
    void OnMouseDown()
    {
        PlayerPrefs.SetString("FilmName", "http://kinosotik.com/download/brilliantovaya-ruka?original");
        videoUrl = PlayerPrefs.GetString("FilmName");

        videoPlayer.url = videoUrl;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();

        FilmCanvas.gameObject.SetActive(false);
        FilmCube.gameObject.SetActive(true);
    }
}
