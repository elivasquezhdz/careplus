using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videomanager : MonoBehaviour
{

    private VideoPlayer videoPlayer;
    public GameObject video2;

    // Start is called before the first frame update
    public void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        //video2.SetActive(false); 
        //videoPlayer = seta
    }

    public void Play( )
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }


    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            video2.SetActive(true);

         }
    }

    //public void URLToVideo(string url)
    //{
    //    videoPlayer.soure = VideoSource.Url;
    //    videoPlayer.url = url;
    //    videoPlayer.Prepare();
    //    videoPlayer.prepareCompleted += ideoPlayer_PrepareCompleted;
    //}

    // Update is called once per frame
    //void Update()
    //{

    //}

    //void VideoPlayer_PrepareCompleted(VideoPlayer source)
    //{
    //}

    void VideoPlayer_PrepareCompleted(VideoPlayer source)
    {
    }

}
