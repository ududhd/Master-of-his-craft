using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    float move;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    }
}
