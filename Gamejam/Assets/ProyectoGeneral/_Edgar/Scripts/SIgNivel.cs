using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SIgNivel : MonoBehaviour
{
    public string NombreEscena;
    private int _contadorNave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(NombreEscena);
        }
        if (collision.CompareTag("nave"))
        {
            _contadorNave++;
            if (_contadorNave == 3)
            {
                SceneManager.LoadScene(NombreEscena);
            }
        }
    }
}
