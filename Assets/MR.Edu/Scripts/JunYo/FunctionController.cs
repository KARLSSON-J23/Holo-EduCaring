using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FunctionController : MonoBehaviour
{
    public List<GameObject> functions = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FunctionViewControl(int index)
    {
        for(int i=0;i<functions.Count;i++)
        {
            functions[i].SetActive(false);
            if(i==index)
            {
                functions[i].SetActive(true);
            }
        }

    }
}
