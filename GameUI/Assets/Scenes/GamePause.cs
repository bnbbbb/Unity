using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject GamePanel;

    public void Menu_button()
    {
        Time.timeScale = 0; //게임 일시정지
        GamePanel.SetActive(true);
    } 
}
