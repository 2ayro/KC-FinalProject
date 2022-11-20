using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer sprite;
    bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }

    void Flip()
    {
        if (facingRight == true && Input.GetKeyDown(KeyCode.D))
        {
            sprite.flipX = true;
            facingRight = false;
        }
        else if (facingRight == false && Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = false;
            facingRight = true;
        }









    }    
}