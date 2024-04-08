using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class stroke_btn2 : MonoBehaviour
{
    public GameObject displayer, clipboard;
    private bool boardIsShowing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void boardActive()
    {
        displayer.SetActive(false);
        clipboard.SetActive(true);
    }

    public void disableBoard()
    {
        displayer.SetActive(true);
        clipboard.SetActive(false);
    }

    public void showboard()
    {
        if (boardIsShowing)
        {
            disableBoard();
        }
        else
        {
            boardActive();
        }

        boardIsShowing = !boardIsShowing;
    }
   
}
