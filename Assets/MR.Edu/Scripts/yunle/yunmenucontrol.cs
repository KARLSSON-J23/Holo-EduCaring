using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yunmenucontrol : MonoBehaviour
{
    public GameObject Menu;
    // Start is called before the first frame update
    public void Start()
    {
        
    }
   
    public void OnButtonClick()
    {

        Menu.SetActive(!Menu.activeSelf);
    }
    // Update is called once per frame
    public void Update()
    {
        
    }
}
