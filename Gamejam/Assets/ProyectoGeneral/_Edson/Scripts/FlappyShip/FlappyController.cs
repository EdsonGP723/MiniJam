using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    // Update is called once per frame
    void Update()
    {
        
        
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        transform.position = mouseWorldPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var SceneManager = FindObjectOfType<SceneController>();
        if (collision.CompareTag("Asteroid"))
        {
            SceneManager.GetComponent<SceneController>().ScenesLod();
            this.gameObject.SetActive(false); 
        }
    }
}
