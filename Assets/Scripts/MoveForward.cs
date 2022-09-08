using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float SpeedForward = 1f;
    public Rigidbody Rigidbody;
    public float StepBack;
    public Transform Head;
    public void Forward()
    {
        Rigidbody.velocity = new Vector3(0, 0, SpeedForward);
    }
    public void Step()
    {
        Vector3 zHead = new Vector3(0, 0,-StepBack);//отталкиваем змею назад
        Head.position += zHead;
    }
    
     private void Update()
    {
        Forward();
    }

}
