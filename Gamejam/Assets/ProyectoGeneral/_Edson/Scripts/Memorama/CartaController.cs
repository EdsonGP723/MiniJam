using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartaController : MonoBehaviour
{
    public GameObject Carta;
    public Image CartaCol;
    // Start is called before the first frame update
    void Start()
    {
        BlackCol();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhiteCol()
    {
        CartaCol = Carta.GetComponent<Image>();
        CartaCol.color = Color.white;
    }

    public void BlackCol()
    {
        CartaCol = Carta.GetComponent<Image>();
        CartaCol.color = Color.black;
    }
}
