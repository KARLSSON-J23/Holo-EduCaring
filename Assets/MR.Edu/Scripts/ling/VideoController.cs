using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Microsoft.MixedReality.Toolkit.UI;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public PressableButton pressableButton;
    private bool isPlaying = true;

    public void Start()
    {
        // 獲取 PressableButton 組件
        pressableButton = GetComponent<PressableButton>();

        // 添加按鈕點擊事件的監聽器
        pressableButton.ButtonPressed.AddListener(ToggleVideo);
    }

    public void ToggleVideo()
    {
        // 根據影片的當前狀態進行暫停或播放
        if (isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }

        // 切換播放狀態
        isPlaying = !isPlaying;
    }
}
