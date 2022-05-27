using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool gameOver = false;
    [SerializeField]
    private int _runestowin = 0;

    public bool winner = false;
    public GameObject screenWinner;
    public GameObject screenLoser;

    public void Awake()
    {
         Instance= this;
    }

    public void GameOver()
    {
          gameOver = true;  
    }

    public void playerwinner (int ObjectToWin) 
    {
        if(gameOver==false)
        {
            if(_runestowin<=3)
            {
                _runestowin = _runestowin + ObjectToWin;
                    if(_runestowin==3)
                {
                    winner=true;
                    InterfaceManager();
                    gameOver = true;    

                }
            }
        }
    }
    public void PlayerLose(bool gameStatus)
    {
        if (gameOver==false && gameStatus==true)
        {
            gameOver = gameStatus;
            InterfaceManager(); 
        }
     
    }

    public void InterfaceManager()
    {
        if(winner==true) 
        {
            screenWinner.SetActive(true);
        }
        if (gameOver==true)
        {
            screenLoser.SetActive(true);
        }
    }
}




