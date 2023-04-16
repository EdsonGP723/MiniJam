using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int[] Scenes;
    public void ScenesLod()
    {
        SceneManager.LoadScene(Scenes[Random.Range(0,4)]);
    }
}
