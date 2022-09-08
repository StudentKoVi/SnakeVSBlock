using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public int Tail;
    public TextMesh Health;

    public Game Game;

    public int Interval=10;
    private float Speed=5;
    public GameObject BodyPrefab;
    List<GameObject> PartsOfTheTail = new List<GameObject>();//список частей хвоста змеи
    List<Vector3> MovementHistory = new List<Vector3>();//список Маркеров по которым движется змея
    

    private void Start()
    {
        AddPartOfTheBody();
        AddPartOfTheBody();
        AddPartOfTheBody();
      
    }
    private void Update()
    {
        TextMesh textObject = Health.GetComponent<TextMesh>();//находим компонент Текст у Головы
        textObject.text = Tail.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Tail--;
        if (Tail <= 0) 
        {
            Game.PlayerDied();
        }
    }

    private void FixedUpdate()
    {
        MovementHistory.Insert(0, transform.position);
        int index = 0;
        foreach (var tail in PartsOfTheTail) 
        { 
            Vector3 mark = MovementHistory[Mathf.Min(index*Interval,MovementHistory.Count-1)];
            Vector3 moveDirection = mark - tail.transform.position;
            tail.transform.position += moveDirection* Speed*Time.deltaTime;
            index++;
        }
    }
   
    public void AddPartOfTheBody()
    {
        GameObject bady = Instantiate(BodyPrefab);
        PartsOfTheTail.Add(bady);
    }
    
}
