using UnityEngine;

public class Time : MonoBehaviour
{
    public float StartTime;
    public float EndTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartTime += 0.1f;
        if(StartTime >= EndTime)
        {
            Destroy(gameObject);
        }
    }
}
