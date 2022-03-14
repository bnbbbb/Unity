using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //����� �����ϴ� �⺻ Ŭ����

public class Playerball : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManagerLogic manager;

    bool isJump;
    Rigidbody rigid;
    AudioSource audio;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }

    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); // h = horizontal
        float v = Input.GetAxisRaw("Vertical");// v = Vertical

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }
        else if (other.tag == "finish")
        {
            //Find �迭 �Լ��� ���ϸ� �ʷ��� �� �����Ƿ� ���ϴ� ���� ����
            if(itemCount == manager.totalItemCount)
            {
                if (manager.stage == 2)
                    SceneManager.LoadScene(0);
                else
                //Game Clear!
                    SceneManager.LoadScene(manager.stage + 1);
                //ToString() ->���ڸ� ���ڿ��� �ٲ���
            }
            else
            {
                //Restart
                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
