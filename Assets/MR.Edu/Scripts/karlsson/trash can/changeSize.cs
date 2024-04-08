using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSize : MonoBehaviour
{


    //GameObject slider;
    float changeRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add(GameObject ball)
    {
        
        float x = ball.transform.localScale.x;
        float y = ball.transform.localScale.y;
        float z = ball.transform.localScale.z;
        Debug.Log("(" + x + "," + y + "," + z + ")");
        ball.transform.localScale = new Vector3(x + changeRate, y + changeRate, z + changeRate);
    }
    public void reduce(GameObject ball)
    {
        
        float x = ball.transform.localScale.x;
        float y = ball.transform.localScale.y;
        float z = ball.transform.localScale.z;

        if(x > 0 && y > 0 && z >0)
        {
            Debug.Log("(" + x + "," + y + "," + z + ")");
            ball.transform.localScale = new Vector3(x - changeRate, y - changeRate, z - changeRate);
        }
        
    }
    public void gate(GameObject door)
    {

    }
}
