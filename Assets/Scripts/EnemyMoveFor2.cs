using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveFor2 : MonoBehaviour
{
    //public float speedX;
    // public float speedY;
    // public float t;
    //  public float power;
    [Range(0, 1)] public float value;
    List<Transform> line1;
    List<Transform> line2;
    public Transform parentLine1;
    public Transform parentLine2;
    Vector3 point1;
    Vector3 point2;
    public Transform object1;
    public Transform object2;
    private float speed;
    public float speedX;
    void Start()
    {
        speed = Random.Range(6f, 15f);
        line1 = new List<Transform>();
        line2 = new List<Transform>();
        parentLine1.GetComponentsInChildren<Transform>(line1);
        parentLine2.GetComponentsInChildren<Transform>(line2);
        value = 0;
        StartCoroutine(PlusValue());
    }
    IEnumerator PlusValue()
    {
        while (value <= 1)
        {
            yield return new WaitForSeconds(0.01f);
            value += 0.001f * speed;
            Move();
        }
        StartCoroutine(MinusValue());
    }
    IEnumerator MinusValue()
    {
        while (value >= 0)
        {
            yield return new WaitForSeconds(0.01f);
            value -= 0.001f * speed;
            Move();
        }
        StartCoroutine(PlusValue());
    }
    void Move()
    {
        LerpLine1();

    }
    void LerpLine1()
    {
        object1.position = Vector3.Lerp(line1[1].position, line1[2].position, value);
        object2.position = Vector3.Lerp(line2[1].position, line2[2].position, value);
    }


    void Update()
    {
        transform.Translate(-speedX * Time.deltaTime, 0, 0);
    }
}


