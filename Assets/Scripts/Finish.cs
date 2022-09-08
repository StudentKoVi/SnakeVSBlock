using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Game game;
    private void OnCollisionEnter(Collision collision)
    {
      game.PlayerWon();
    }
}
