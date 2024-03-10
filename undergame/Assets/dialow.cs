using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class dialow : MonoBehaviour
{
    private string messet;

    public int pointer;
    public float Speed = 1;
    public Color color = Color.red;

    public Text dialogs;
    // Start is called before the first frame update
    void Start()
    {
        //dialogs.text = "HOULOHUOI";
        messet = "ghbdytn";
        pointer = 0;
        StartCoroutine(nameof(sendtext));
    }

    public void SetText(string message)
    { 
        StopAllCoroutines();

        messet = message;
        dialogs.text = string.Empty;
        pointer = 0;


        StartCoroutine(nameof(sendtext));
    }

    public IEnumerator sendtext()
    {
        yield return new WaitForSeconds(Speed);
        if (pointer < messet.Length)
        {
            dialogs.text += messet[pointer];     
            dialogs.color = color;
            pointer++;

            StartCoroutine(nameof(sendtext));
        }
    }
}
