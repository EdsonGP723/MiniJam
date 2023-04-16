using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] int _contadorNave = 0;
    public string NombreEscena;
    // Update is called once per frame
    void Update()
    {
        
        
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        transform.position = mouseWorldPosition;

        if (_contadorNave == 3)
        {
            SceneManager.LoadScene(NombreEscena);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var Scenemanager = FindObjectOfType<SceneController>();
        if (collision.CompareTag("Asteroid"))
        {
            Scenemanager.GetComponent<SceneController>().CambioEscena();
            this.gameObject.SetActive(false); 
        }
        if (collision.CompareTag("nave"))
        {
            _contadorNave++;
            
        }
    }
}
