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
        // �T�O���s�W�������� OnClick �ƥ�s���� PlayPauseAudio ��k
        playPauseButton.onClick.AddListener(PlayPauseAudio);
    }

    public void PlayPauseAudio()
    {
        if (isPaused)
        {
            // �p�G���T�w�Ȱ��A�h�~�򼽩�
            audioSource.UnPause();
            isPaused = false;
            // TODO: �b���B�����s���Ϥ��A�H��ܬ����񪬺A
        }
        else
        {
            // �p�G���T���b����A�h�Ȱ�
            audioSource.Pause();
            isPaused = true;
            // TODO: �b���B�����s���Ϥ��A�H��ܬ��Ȱ����A
        }
    }
}
