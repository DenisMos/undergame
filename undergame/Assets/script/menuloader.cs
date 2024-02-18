using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuloader : MonoBehaviour
{
    public void joki(string joki)
    {
        SceneManager.LoadScene(joki);
    }
}
