using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;


public class dialogtrue : MonoBehaviour
{
    public dialow fer;
    private bool _stay;
     
    // Start is called before the first frame update
    void Start()
    {
        fer = FindObjectOfType<dialow>(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (_stay && Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("x");
            fer.next();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fer.ShowText("нектозоветвас|привет Михаил");
        _stay = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fer.StopText();
        _stay = false;
    }
}
