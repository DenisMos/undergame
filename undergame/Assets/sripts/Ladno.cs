using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladno : MonoBehaviour
{
    [SerializeField] private SpriteRenderer ladn;

    private void loo()
    {
        var red = Mathf.Cos(Time.time);
        var green = Mathf.Cos(Time.time);

        ladn.color = new Color(red,green,0);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loo();
    }
}
