using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gerta : MonoBehaviour
{
    [SerializeField]
    private Image _hitbar;

    [SerializeField]
    private float _health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _hitbar.fillAmount = _health;

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            fertya(0.05f);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            fertya(-0.05f);

        }
    }

    public void fertya(float health)
    {
        _health -= health;
    }
}
