using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class teleport: MonoBehaviour
{

    public GameObject Destination;
    public GameObject Player;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Teleport();
        }
    }


    private void Teleport()
    {
        Player.transform.position = new Vector2(Destination.transform.position.x, Destination.transform.position.y);
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if (Destination == null)
        {
            Gizmos.color = UnityEngine.Color.red;
            Gizmos.DrawSphere(gameObject.transform.position, 0.05f);
        }
        else
        {
            Gizmos.DrawLine(gameObject.transform.position, Destination.transform.position);
        }
    }
#endif
}
