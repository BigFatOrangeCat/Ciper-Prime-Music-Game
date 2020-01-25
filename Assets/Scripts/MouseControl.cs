using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseControl : MonoBehaviour
{
    public GameObject Knob;

    private void Update()
    {

    }
    private void OnMouseDrag()
    {
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //记录鼠标位置
        currentPos.z = 0; //初始化鼠标位置为0
        gameObject.transform.position = currentPos; //移动鼠标

    }
}
