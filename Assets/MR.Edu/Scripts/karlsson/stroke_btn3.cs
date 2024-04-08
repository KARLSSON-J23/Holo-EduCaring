using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stroke_btn3 : MonoBehaviour
{
    [SerializeField] GameObject brush;
    TrailRenderer top;
    // Start is called before the first frame update
    void Start()
    {
        top = brush.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clearBoard()
    {
        top.time = 0;
        Debug.Log("clear");
    }
}
