using UnityEngine;

public class choca : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer sprite;
    int X = 1;
    int Y = 1;
    public float velocidad = 3;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(X * velocidad, Y * velocidad);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ParedX"))
        {
            X = X * -1;
            sprite.flipX = true;
        }
        else if (other.gameObject.CompareTag("ParedX1"))
        {
            X = X * -1;
            sprite.flipX = false;
        }
        
        if (other.gameObject.CompareTag("ParedY"))
        {
            Y = Y * -1;
            sprite.flipY = true; 
        }else if (other.gameObject.CompareTag("ParedY1"))
        {
            Y = Y * -1;
            sprite.flipY = false;
        }        
    }
}