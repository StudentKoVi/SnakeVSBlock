using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public TextMesh AmoutOfFood;
    protected int AmoutofFood;
    public Transform FoodSphere;
    public SnakeTail SnakeTail;
    
    void Start()
    {
        AmoutofFood = Random.Range(3, 10);
    }

    private void Update()
    {
        TextMesh textObject = AmoutOfFood.GetComponent<TextMesh>();//находим компонент Текст у Сферы
        textObject.text = AmoutofFood.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider)
        {
            SnakeTail.Tail= SnakeTail.Tail+AmoutofFood+1;
            Debug.Log("Колличество жизней - "+SnakeTail.Tail);
            Destroy(FoodSphere.transform.gameObject);
            for (int i = 0; i<=AmoutofFood-1; i++) 
            {
                SnakeTail.AddPartOfTheBody();
            }

        }
    }

}
