using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform MainCamera;
    public Transform Head;
    public  float Speed;
    public Vector3 HeightCamera;
    void Update()
    {
        Vector3 zHead =  new Vector3(0, 0, Head.position.z);//движение игорока по оси Z
        MainCamera.position =(zHead*Speed+HeightCamera);
    }
}
