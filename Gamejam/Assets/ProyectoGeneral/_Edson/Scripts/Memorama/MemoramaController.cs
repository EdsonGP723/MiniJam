using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoramaController : MonoBehaviour
{
    [Header("Active Cards")]
    public bool C1 = false, C2 = false, C3 = false, C1c = false, C2c = false, C3c = false;
    [Header("Layouts")]
    public GameObject[] Layouts;
    
    private void Start()
    {
       
        Layouts[Random.Range(0, Layouts.Length)].SetActive(true);
    }
    private void Update()
    {
        
    }

    public void CardsBehaviour()
    {
       
    }

    public void C1Active()
    {
        C1 = true;
        
    }
    public void C1cActive()
    {
        C1c = true;
    }
    public void C2Active()
    {
        C2 = true;
    }
    public void C2cActive()
    {
        C2c = true;
    }
    public void C3Active()
    {
        C3 = true;
    }
    public void C3cActive()
    {
        C3c = true;
    }
    public void C1Deactive()
    {
        C1 = false;
    }
    public void C1cDeactive()
    {
        C1c = false;
    }
    public void C2Deactive()
    {
        C2 = false;
    }
    public void C2cDeactive()
    {
        C2c = false;
    }
    public void C3Deactive()
    {
        C3 = false;
    }
    public void C3cDeactive()
    {
        C3c = false;
    }

   
}
