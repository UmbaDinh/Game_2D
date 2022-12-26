using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public float speed = 0.8f;
    public float range = 3;

    float startingX;
    int dir = 1;
    void Start()
    {
        startingX = transform.position.x;
    }
    private bool isFacingRight = true;
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime * dir);
        
        if (transform.position.x < startingX || transform.position.x > startingX + range)
            dir *= -1;

        if (transform.position.x < startingX || transform.position.x > startingX + range)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
