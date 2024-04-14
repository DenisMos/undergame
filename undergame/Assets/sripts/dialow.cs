using System.Collections;
using Assets.sripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class dialow : MonoBehaviour
{
    private string[] messet;
    private string messegeShow;
    private int _pointer;

    public int pointer;
    public float Speed = 1;
    public Color colorText = Color.black;
    public Image pert;
    public Text dialogs;
    public GameObject dialogPanel;


    public bool BlockMove;
    public GameObject Blockable;
    private IBlockable _blockable;

    // Start is called before the first frame update
    void Start()
    {
        if (BlockMove)
        {
            _blockable = Blockable.GetComponent<IBlockable>();
            if (_blockable == null) Debug.LogError("Не выбран объект блокировки.");
        }

        gameObject.SetActive(true);
       StopText();
    }

    public void next()
    {
        StopAllCoroutines();
        _pointer++;

        Debug.Log(_pointer);

        if (_pointer >= messet.Length)
        {
            StopText();
        }
        else
        {
            dialogs.text = string.Empty;
            pointer = 0;
            messegeShow = messet[_pointer];
            StartCoroutine(nameof(sendtext));
        }
    }

    public void ShowText(string message)
    { 
        StopAllCoroutines();

        if (BlockMove)
        {
            _blockable.Block();
        }

        dialogPanel.SetActive(true);

        messet = message.Split('|');
        dialogs.text = string.Empty;
        pointer = 0;
        _pointer = 0;
        messegeShow = messet[_pointer];



        StartCoroutine(nameof(sendtext));
    }

    public void StopText()
    {
        StopAllCoroutines();

        if (BlockMove)
        {
            _blockable.Unblock();
        }

        dialogs.text = string.Empty;

        dialogPanel.SetActive(false);
    }

    public IEnumerator sendtext()
    {
        yield return new WaitForSeconds(Speed);
        if (pointer < messegeShow.Length)
        {
            dialogs.text += messegeShow[pointer];     
            pointer++;

            StartCoroutine(nameof(sendtext));
        }
    }
}
