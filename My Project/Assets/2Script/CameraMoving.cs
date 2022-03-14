using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset;
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        //Hierachy에서 Player을 찾고싶으면 GameObject 가져오고
        //.누르고 FindGameObjectWithTag
        Offset = transform.position - playerTransform.position;
    }


    void LateUpdate() //보통 UI, 카메라 이동은 LateUpdate에서 이뤄짐
        // Update에서 연산을 다 하고 뒤에 따라 붙기 때문에
    {
        transform.position = playerTransform.position + Offset;
    }
}
