using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
  
    public Game game;
    public void OnClickRestartOrNext()
    {
        
        Time.timeScale = 1;
        game.ReloadScene();
       
    }
   
}
