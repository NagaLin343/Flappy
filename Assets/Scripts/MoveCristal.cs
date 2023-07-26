using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCristal : MonoBehaviour
{
    public float speedX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speedX * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Character"&&collision.gameObject!=null)
        {
            Destroy(gameObject);
        }
        Debug.Log(collision.gameObject);
    }
    
}
