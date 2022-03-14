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
        //Hierachy���� Player�� ã������� GameObject ��������
        //.������ FindGameObjectWithTag
        Offset = transform.position - playerTransform.position;
    }


    void LateUpdate() //���� UI, ī�޶� �̵��� LateUpdate���� �̷���
        // Update���� ������ �� �ϰ� �ڿ� ���� �ٱ� ������
    {
        transform.position = playerTransform.position + Offset;
    }
}
