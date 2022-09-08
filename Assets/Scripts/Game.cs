using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    
   public enum State
    {
        Playing,
        Win,
        Loss,
    }
    
    public State state { get; private set; }

    public void PlayerWon()
    {
        if (state != State.Playing) return;
        state = State.Win;
        Debug.Log("You Won");
        Level++;
        Win();
        Debug.Log("Счетчик уровлей - "+Level);
        

    }

    public void PlayerDied()
    {
        if (state != State.Playing) return;
        state = State.Loss;
        Debug.Log("You Lose");
        Loss();
        //ReloadScene();
        Debug.Log("Счетчик уровлей - "+Level);
    }
    public int Level // Сохроняем уровень
    {
        get => PlayerPrefs.GetInt("Level", 0);
        set 
        {
            PlayerPrefs.SetInt("Level",value);
            PlayerPrefs.Save();
        }
    }
    private void Update()
    {
        if (state == State.Loss)
        {
           
        }
    }

    public void ReloadScene()//Смена уровней
    {
        if (Level == 0) SceneManager.LoadScene(0);

        if (Level == 1) SceneManager.LoadScene(1);

        if (Level == 2) SceneManager.LoadScene(2);

        if (Level >= 3)
        {
            SceneManager.LoadScene(0);
            Level = 0;
        }
    }

    public GameObject ConvasLoss;
    public GameObject ConvasWon;
   void Win() 
    {
        ConvasWon.SetActive(true);
        Time.timeScale =0;
    }
    void Loss() 
    {
        ConvasLoss.SetActive(true);
        Time.timeScale = 0;
    }


}
