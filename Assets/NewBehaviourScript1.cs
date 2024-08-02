using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Image target;
    public Image mouse;
    public float angleOffset;


    void Update()
    {
       Debug.Log($"Mouse: {Input.mousePosition}");
        mouse.rectTransform.anchoredPosition = Input.mousePosition;
        var screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log($"Screen Point: {screenPoint}");

        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y,dir.x)*Mathf.Rad2Deg+angleOffset;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
}
