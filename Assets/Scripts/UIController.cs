using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public int score;
    public bool alive = true;
    public int escapePresses = 1;

    public GameObject gamePanel;
    public GameObject menuPanel;

    public Button reStart;
    public Button Quit;


    public Text scoreGame;
    public Text scoreMenu;

    // Start is called before the first frame update
    void Start()
    {
        //Quit.onClick.AddListener(delegate () { QuitFunction(); });
        //Quit.onClick.AddListener(delegate () { reStartFunction(); });
    }

    // Update is called once per frame
    //void Update()
    //{   
    //    if(Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        escapePresses++;
    //    }
    //    escapePresses = escapePresses % 2;

    //    if(alive == false)
    //    {
    //        escapePresses = 1;   
    //    }

    //    if(escapePresses == 1)
    //    {
    //        gamePanel.SetActive(false);
    //        menuPanel.SetActive(true);
    //    }
    //} 
    //void QuitFunction()
    //{
    //    Application.Quit();
    //}
    //void reStartFunction()
    //{
    //    reStart.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Restart";
        
    //    //сам пиши сука мне лень
    //}

    //void MenuHandle()
    //{
    //    if (escapePresses != 1) return;
    //    scoreMenu.text = $"{score}";

    //}

    //void GameHandle()
    //{
    //    if (escapePresses != 0) return;
    //}
}
