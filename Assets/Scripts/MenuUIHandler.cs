using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void StartNew2()
    {
        SceneManager.LoadScene(2);
    }
    public void StartNew3()
    {
        SceneManager.LoadScene(3);
    }
}
