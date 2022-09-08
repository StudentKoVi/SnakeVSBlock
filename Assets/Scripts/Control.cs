using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Vector3 MousePosition;
    
    public Transform Player;

    public float Speedx = 0.01f;
    

    void Update()
    {//управление мышью вправо/влево
        if (Input.GetMouseButton(0))
        {
            //Ограничения по вылету с дороги
            if (Player.transform.localPosition.x >= 7.5) Player.transform.position = new Vector3(7.4f, 0.5f, 0);

            if (Player.transform.localPosition.x <= -7.5) Player.transform.position = new Vector3(-7.4f, 0.5f, 0);
            
            //Передаем передвижение мыши в передвижение "головы"
            Vector3 delta = Input.mousePosition - MousePosition;
            Player.transform.Translate(delta.x * Speedx, 0, 0);
              
        }
        MousePosition = Input.mousePosition;
       
        
    }
    
}
