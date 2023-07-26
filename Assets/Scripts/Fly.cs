using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float power;
    Rigidbody2D player;

    public GameObject RestartButton;
    void Start()
    {
        Time.timeScale = 1;
        player = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            player.velocity = Vector2.up * power;
        }
        else
        {
            player.velocity = Vector2.down*power;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            RestartButton.SetActive(true);
        }
    }
}
