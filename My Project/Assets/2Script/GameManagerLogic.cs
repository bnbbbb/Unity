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
    public void GetItem(int count) //playerball에서 manager가져왔으니
                          // 공개적인 함수를 만들자!
    {
        playerCountText.text = count.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);
    }
}
