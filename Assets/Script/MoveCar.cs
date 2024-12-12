using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(direction.normalized * speed);
    }
}
