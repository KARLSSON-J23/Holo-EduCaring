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
        Debug.Log("AssetsPath�G" + assetsFolderPath);
        if (displayer != null)
        {
            videoPlayer = displayer.GetComponent<VideoPlayer>();
                VideoClip clip = videoPlayer.clip;
            // �T�{�O�_���VideoPlayer�ե�
            if (videoPlayer != null)
            {
                // �b�o�̧A�i�H��videoPlayer�i��@�Ǿާ@
                // �Ҧp����B�Ȱ��B�]�m�v������
                setVideo(clip, videoPlayer);
            }
            else
            {
                Debug.LogWarning("VideoPlayer�ե󤣦s�b����w��GameObject�W�C");
            }
        }
        else
        {
            Debug.LogWarning("�ؼ�GameObject�|�������C�нT�O�����F���T��GameObject�C");
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

    // �Ȱ��v��
    public void PauseVideo()
    {
        videoPlayer.Pause();
        isPlaying = false;
        Debug.Log("Video is Pause");
    }
}
