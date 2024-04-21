using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bertot : MonoBehaviour
{  
    public SpriteRenderer SpriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SpriteRenderer.enabled = true;
    }
}
