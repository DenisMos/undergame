using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class yron : MonoBehaviour
{
    [SerializeField]
    [Range(0, 1f)]
    private float damage;

    public Image Image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Image.fillAmount -= damage;   

        if (Image.fillAmount == 0)
        {
            var c = SceneManager.GetActiveScene();
            SceneManager.LoadScene(c.name, LoadSceneMode.Single);
        }
    }
}