using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public dialow Dialow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Dialow.color = Color.blue;
            Dialow.Speed = 0.01f;
            Dialow.SetText("����� ������ Q");
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            Dialow.color = Color.yellow;
            Dialow.Speed = 1f;
            Dialow.SetText("����� ������ P");
        }
    }
}
