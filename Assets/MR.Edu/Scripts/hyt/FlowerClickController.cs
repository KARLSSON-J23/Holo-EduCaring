using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

public class FlowerClickController : MonoBehaviour
{
    public void FlowerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("FlowerClicked!");
        GameObject petal1 = GameObject.Find("petal1");

        // 確保找到了petal1
        if (petal1 != null)
        {
            // 取得petal1的Transform組件
            Transform petal1Transform = petal1.transform;
            petal1Transform.position = new Vector3(petal1Transform.position.x, petal1Transform.position.y + 0.05f, petal1Transform.position.z);
        }
        else
        {
            Debug.Log("petal1 not found!");
        }
    }
    public void FlowerHoverEntered(ManipulationEventData eventData)
    {
        Debug.Log("Flower Hover!");
    }
}
