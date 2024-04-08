using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;


public class OnValueUpdated : MonoBehaviour
{
    // Start is called before the first frame update
    static int i = 0;
    public static int size;
    public GameObject otherObject;
    // private PinchSlider slider;
    void Start()
    {
        // size = otherObject.GetComponent<int>();
        otherObject = GameObject.Find("sliderSize");
        // System.Console.WriteLine("start");
    }

    // Update is called once per frame
    void Update()
    {
        // System.Console.WriteLine("update");
    }

    public void test()
    {
        
        i ++;
        
        UnityEngine.Debug.Log("size:" + otherObject );
        
    }
   
}
