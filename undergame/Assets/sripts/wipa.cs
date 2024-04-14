using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class wipa : MonoBehaviour
{
    private bool _stay;
    public bool _act;

    public GameObject[] Target;
    public SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.flipY = _act;

        foreach (var t in Target)
        { 
            t.SetActive(!_act);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_stay && Input.GetKeyDown(KeyCode.Q))
        {
            _act = !_act;
            SpriteRenderer.flipY = _act;
            foreach (var t in Target)
            {
                t.SetActive(!_act);
            }
    }
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _stay = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _stay = false;
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        if (Target == null && Target.Length == 0) return;

        foreach (var t in Target) 
        {
            Gizmos.DrawLine(gameObject.transform.position, t.transform.position);
            Gizmos.DrawWireCube(t.transform.position, t.transform.localScale / 5);
        }
    }

#endif
}
