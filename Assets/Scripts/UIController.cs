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

    public Text fps;
    float deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        Quit.onClick.AddListener(delegate () { QuitFunction(); });
        reStart.onClick.AddListener(delegate () { reStartFunction(); });
    }

      
     void Update()
     {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float framesPerSecond = 1.0f / deltaTime;
        fps.text = $"FPS: {Mathf.Ceil(framesPerSecond)}";

        if (Input.GetKeyDown(KeyCode.Escape) && alive)
         {
             escapePresses++;
         }
         escapePresses = escapePresses % 2;
     
         if(alive == false)
         {
             escapePresses = 1;   
         }
     
         if(escapePresses == 1)
         {
            //ПАУЗА
             gamePanel.SetActive(false);
             menuPanel.SetActive(true);
         } else
         {
            //НЕ пауза
            //прости
            gamePanel.SetActive(true);
            menuPanel.SetActive(false);
         }

         if(score < 0)
         {
            alive = false;
            escapePresses = 1;
         }

        MenuHandle();
        GameHandle();
     } 
     void QuitFunction()
     {
         Application.Quit();
     }
     void reStartFunction()
     {
        Application.LoadLevel(0);
         //сам пиши сука мне лень
     }

    private void OnLevelWasLoaded(int level)
    {
        escapePresses = 0;
    }

    void MenuHandle()
     {
         if (escapePresses != 1) return;
         scoreMenu.text = $"{score}";
     
     }
     
     void GameHandle()
     {
         if (escapePresses != 0) return;
        scoreGame.text = $"{score}";
    }
}
