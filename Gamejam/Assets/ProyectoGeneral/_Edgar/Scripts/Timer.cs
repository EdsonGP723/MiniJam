using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField, Tooltip("Tiempo en segundos")] public float timer = 0;

    public TextMeshProUGUI texto;
    private int minutes, seconds;
    
    public GameObject PanelLost;
    //public GameObject panelJuego;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        timerUNO();
    }

    public void timerUNO()
    {

        timer -= Time.deltaTime;
        if (timer < 0) timer = 0;

        minutes = (int)(timer / 60);
        seconds = (int)(timer - minutes * 60);
        texto.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timer <= 0)
        {
            
            PanelLost.SetActive(true);
            StartCoroutine(DeRegreso());
        }
    }

    IEnumerator DeRegreso()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}