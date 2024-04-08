using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class menucontrol : MonoBehaviour
{
    public GameObject TextView;
    public GameObject FunctionMenu;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
   
    public void OnButtonClick()
    {
        if(TextView.activeSelf == false)
        {
            TextView.SetActive(true);
            FunctionMenu.SetActive(true);
        }
        
    }
    // Update is called once per frame
    public void Update()
    {
        
    }
}
