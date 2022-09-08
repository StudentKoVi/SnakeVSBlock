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
        TextMesh textObject =Number.GetComponent<TextMesh>();//������� ��������� ����� � �����
        textObject.text = RndNum.ToString();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out MoveForward back))  
        {
            RndNum -= 1;//��������� ��������� ����� 
            back.Step();
            
            if (RndNum <= 0) Destroy(block.transform.gameObject);//������� ���� ����� 0
            //Destroy(GetComponent<BoxCollider>()); ��� ���� ��� ����� ������� 
        }

    }
}
