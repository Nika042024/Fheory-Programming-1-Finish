using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMain : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }
   
}
