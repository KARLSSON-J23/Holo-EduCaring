using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class stroke_btn1 : MonoBehaviour
{
    public GameObject displayer;
    public VideoPlayer videoPlayer;
    private bool isPlaying = false;
    
    // Start is called before the first frame update
    void Start()
    {
        string assetsFolderPath = Application.dataPath;
        Debug.Log("AssetsPath：" + assetsFolderPath);
        if (displayer != null)
        {
            videoPlayer = displayer.GetComponent<VideoPlayer>();
                VideoClip clip = videoPlayer.clip;
            // 確認是否找到VideoPlayer組件
            if (videoPlayer != null)
            {
                // 在這裡你可以對videoPlayer進行一些操作
                // 例如播放、暫停、設置影片等等
                setVideo(clip, videoPlayer);
            }
            else
            {
                Debug.LogWarning("VideoPlayer組件不存在於指定的GameObject上。");
            }
        }
        else
        {
            Debug.LogWarning("目標GameObject尚未指派。請確保指派了正確的GameObject。");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public  void playVideo()
    {
       
        if (isPlaying)
        {
            PauseVideo();
        }
        else
        {
            PlayVideo();
        }
    }
    public void PlayVideo()
    {
        videoPlayer.Play();
        isPlaying = true;
        Debug.Log("Video is playing");
    }
    public void setVideo(VideoClip videoName, VideoPlayer videoPlayer)
    {
        videoPlayer.clip = videoName;
    }

    // 暫停影片
    public void PauseVideo()
    {
        videoPlayer.Pause();
        isPlaying = false;
        Debug.Log("Video is Pause");
    }
}
