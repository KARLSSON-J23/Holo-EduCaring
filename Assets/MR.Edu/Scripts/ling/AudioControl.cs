using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioSource;
    public Button playPauseButton;

    private bool isPaused = false;

    public void Start()
    {
        // 確保按鈕上有對應的 OnClick 事件連接到 PlayPauseAudio 方法
        playPauseButton.onClick.AddListener(PlayPauseAudio);
    }

    public void PlayPauseAudio()
    {
        if (isPaused)
        {
            // 如果音訊已暫停，則繼續播放
            audioSource.UnPause();
            isPaused = false;
            // TODO: 在此處更改按鈕的圖片，以顯示為播放狀態
        }
        else
        {
            // 如果音訊正在播放，則暫停
            audioSource.Pause();
            isPaused = true;
            // TODO: 在此處更改按鈕的圖片，以顯示為暫停狀態
        }
    }
}
