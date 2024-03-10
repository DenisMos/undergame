using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class dialogtrue : MonoBehaviour
{
    public dialow fer;
    // Start is called before the first frame update
    void Start()
    {
        fer = FindObjectOfType<dialow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fer.ShowText("прингпаынгаывкнгми");
    }
}
