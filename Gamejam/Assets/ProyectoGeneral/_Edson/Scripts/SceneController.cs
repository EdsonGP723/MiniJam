using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int[] Scenes;
    public void ScenesLod()
    {
        
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void CambioEscena()
    {
        SceneManager.LoadScene(Scenes[Random.Range(0,Scenes.Length)]);
    }
}
