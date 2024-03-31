using UnityEngine;


public class dialogtrue : MonoBehaviour
{
    public dialow fer;
    private bool _stay;
    public Color color=Color.blue;
    public Font font;
     
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
        fer.dialogs.font = font;
        fer.pert.color = color;
        fer.ShowText("некто зовет вас|привет Михаил");
        _stay = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fer.StopText();
        _stay = false;
    }
}
