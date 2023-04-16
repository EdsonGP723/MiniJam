using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MemoramaController : MonoBehaviour
{
    public string Scene;
    [Header("Active Cards")]
    public bool C1 = false, C2 = false, C3 = false, C1c = false, C2c = false, C3c = false;
    [Header("Cards Gone")]
    [SerializeField]private bool c1, c2, c3, c1c, c2c, c3c;
    [Header("Layouts")]
    public GameObject[] Layouts;
    public GameObject Card1; 
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card1c;
    public GameObject Card2c;
    public GameObject Card3c;
    private void Start()
    {
        Layouts[Random.Range(0, Layouts.Length)].SetActive(true);

        Card1 = GameObject.FindGameObjectWithTag("1");
        Card2 = GameObject.FindGameObjectWithTag("2");
        Card3 = GameObject.FindGameObjectWithTag("3");
        Card1c = GameObject.FindGameObjectWithTag("1.1");
        Card2c = GameObject.FindGameObjectWithTag("2.1");
        Card3c = GameObject.FindGameObjectWithTag("3.1");

    }
    private void Update()
    {
        CardsBehaviour();
        if (c1! && c2! && c3! && c1c! && c2c! && c3c!)
        {
            SceneManager.LoadScene(Scene);
        }
    }

    public void CardsBehaviour()
    {
       if(C1 == true && C1c == true)
        {
            Card1.SetActive(false);
           
            Card1c.SetActive(false);
            C1Deactive();
            C1cDeactive();

            c1 = true;
            c1c = true;
        }
       if(C2 == true && C2c == true)
        {
            Card2.SetActive(false);
            Card2c.SetActive(false);

            C2Deactive();  
            C2cDeactive();

            c2 = true;
            c2c = true; 
        }
       if (C3 == true && C3c == true)
        {
            Card3.SetActive(false);
            Card3c.SetActive(false);
            C3Deactive();
            C3cDeactive();

            c3 = true;
            c3c = true;
        }
       
       if(C1 == true && C2 == true)
        {
            var c1 = Card1.GetComponent<CartaController>();
            c1.BlackCol();
            C1Deactive();
            var c2 = Card2.GetComponent<CartaController>();
            c2.BlackCol();
            C2Deactive();
        }

        if (C1 == true && C3 == true)
        {
            var c1 = Card1.GetComponent<CartaController>();
            c1.BlackCol();
            C1Deactive();
            var c3 = Card3.GetComponent<CartaController>();
            c3.BlackCol();
            C3Deactive();
        }

        if (C1 == true && C2c == true)
        {
            var c1 = Card1.GetComponent<CartaController>();
            c1.BlackCol();
            C1Deactive();
            var c2c = Card2c.GetComponent<CartaController>();
            c2c.BlackCol();
            C2cDeactive();
        }

        if (C1 == true && C3c == true)
        {
            var c1 = Card1.GetComponent<CartaController>();
            c1.BlackCol();
            C1Deactive();
            var c3c = Card3c.GetComponent<CartaController>();
            c3c.BlackCol();
            C3cDeactive();
        }

        if (C1c == true && C2c == true)
        {
            var c1c = Card1c.GetComponent<CartaController>();
            c1c.BlackCol();
            C1cDeactive();
            var c2c = Card2c.GetComponent<CartaController>();
            c2c.BlackCol();
            C2cDeactive();
        }

        if (C1c == true && C2 == true)
        {
            var c1c = Card1c.GetComponent<CartaController>();
            c1c.BlackCol();
            C1cDeactive();
            var c2 = Card2.GetComponent<CartaController>();
            c2.BlackCol();
            C2Deactive();
        }

        if (C1c == true && C3c == true)
        {
            var c1c = Card1c.GetComponent<CartaController>();
            c1c.BlackCol();
            C1cDeactive();
            var c3c = Card3c.GetComponent<CartaController>();
            c3c.BlackCol();
            C3cDeactive();
        }

        if (C1c == true && C3 == true)
        {
            var c1c = Card1c.GetComponent<CartaController>();
            c1c.BlackCol();
            C1cDeactive();
            var c3 = Card3.GetComponent<CartaController>();
            c3.BlackCol();
            C3Deactive();
        }

        if (C2 == true && C3 == true)
        {
            var c2 = Card2.GetComponent<CartaController>();
            c2.BlackCol();
            C2Deactive();
            var c3 = Card3.GetComponent<CartaController>();
            c3.BlackCol();
            C3Deactive();
        }

        if (C2 == true && C3c == true)
        {
            var c2 = Card2.GetComponent<CartaController>();
            c2.BlackCol();
            C2Deactive();
            var c3c = Card3c.GetComponent<CartaController>();
            c3c.BlackCol();
            C3cDeactive();
        }

        if (C2c == true && C3c == true)
        {
            var c2c = Card2c.GetComponent<CartaController>();
            c2c.BlackCol();
            C2cDeactive();
            var c3c = Card3c.GetComponent<CartaController>();
            c3c.BlackCol();
            C3cDeactive();
        }

        if (C2c == true && C3 == true)
        {
            var c2c = Card2c.GetComponent<CartaController>();
            c2c.BlackCol();
            C2cDeactive();
            var c3 = Card3.GetComponent<CartaController>();
            c3.BlackCol();
            C3Deactive();
        }
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
