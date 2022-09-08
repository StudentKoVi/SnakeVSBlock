using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public TextMesh  Number;
    public int RndNum;
    public Transform block;
        
    private void Start()
    {
        RndNum = Random.Range(1, 20);
    }
     
    private void Update()
    {
        TextMesh textObject =Number.GetComponent<TextMesh>();//находим компонент Текст у Блока
        textObject.text = RndNum.ToString();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out MoveForward back))  
        {
            RndNum -= 1;//уменьшаем прочность блока 
            back.Step();
            
            if (RndNum <= 0) Destroy(block.transform.gameObject);//убераем Блок после 0
            //Destroy(GetComponent<BoxCollider>()); еще есть вот такой вариант 
        }

    }
}
