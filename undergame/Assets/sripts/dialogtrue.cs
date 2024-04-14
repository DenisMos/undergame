using System.Linq;
using UnityEngine;


public class dialogtrue : MonoBehaviour
{
    public dialow fer;
    private bool _stay;
    public Color color=Color.blue;
    public Font font;

    public bool OnlyOne;
    private bool _only;

    public string[] Messegas;
     
    // Start is called before the first frame update
    void Start()
    {
        fer = FindObjectOfType<dialow>(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (_stay && Input.GetKeyDown(KeyCode.G))
        {
            fer.next();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ѕроверка что код должен работать один раз
        if (OnlyOne)
        {
            _only = true;
        }
        if (_only) return;
      

        fer.dialogs.font = font;
        fer.pert.color = color;
        fer.ShowText(Messegas.Aggregate((x,y) => $"{x}|{y}"));
        _stay = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fer.StopText();
        _stay = false;
    }
}
