using UnityEngine;


public class dialogtru2 : MonoBehaviour
{
    public dialow fer;
    private bool _stay;
     
    // Start is called before the first frame update
    void Start()
    {
        fer = FindObjectOfType<dialow>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_stay && Input.GetKeyDown(KeyCode.X))
        {
            fer.next();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        fer.ShowText("некто зовет вас|привет Михаил");
        _stay = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        fer.StopText();
        _stay = false;
    }
}
