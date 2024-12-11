using UnityEngine;


public class Teleport : MonoBehaviour 
{
    public Vector3 Teleport_Point;

    private void OnTriggerStay2D(Collider2D autogon)
    {
        autogon.transform.position = Teleport_Point;
    }

}

