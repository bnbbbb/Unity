using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    // Start is called before the first frame update
    public int stage;
    public Text stageCountText;
    public Text playerCountText;

    void Awake()
    {
        
        stageCountText.text = "/ " + totalItemCount;
        
    }
    public void GetItem(int count) //playerball���� manager����������
                          // �������� �Լ��� ������!
    {
        playerCountText.text = count.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);
    }
}
