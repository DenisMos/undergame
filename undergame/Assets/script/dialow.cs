using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class dialow : MonoBehaviour
{
    private string messet;

    public int pointer;
    public float Speed = 1;
    public Color colorText = Color.black;
    public Text dialogs;
    public GameObject dialogPanel;
    // Start is called before the first frame update
    void Start()
    {
       StopText();
    }

    public void ShowText(string message)
    { 
        StopAllCoroutines();

        dialogPanel.SetActive(true);

        messet = message;
        dialogs.text = string.Empty;
        pointer = 0;


        StartCoroutine(nameof(sendtext));
    }

    public void StopText()
    {
        StopAllCoroutines();

        dialogs.text = string.Empty;

        dialogPanel.SetActive(false);
    }

    public IEnumerator sendtext()
    {
        yield return new WaitForSeconds(Speed);
        if (pointer < messet.Length)
        {
            dialogs.text += messet[pointer];     
            pointer++;

            StartCoroutine(nameof(sendtext));
        }
    }
}
