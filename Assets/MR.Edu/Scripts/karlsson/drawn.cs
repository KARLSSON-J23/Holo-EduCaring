using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawn : MonoBehaviour
{
    [SerializeField] GameObject brush;
    [SerializeField] GameObject clipboard;
    TrailRenderer top;
    public static bool isPress;

    

    private void Start()
    {
        top = brush.GetComponent<TrailRenderer>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {

        top.emitting = true;
        Debug.Log("撞ing" );
    }
    void OnCollisionEnter(Collision touchObject)
    {
        top.time = float.PositiveInfinity;
        Debug.Log("haha是我啦"+touchObject.gameObject.name);

        

    }
    private void OnCollisionExit(Collision collision)
    {
        top.emitting = false;
        Debug.Log("stop撞" );
    }
}
