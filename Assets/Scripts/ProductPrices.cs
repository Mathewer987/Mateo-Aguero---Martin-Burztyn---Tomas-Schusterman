using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProductPrices : MonoBehaviour
{
    public int precio;

    void Start()
    {
        Ocultar();
    }
    public void Ocultar()
    {
        gameObject.SetActive(false);
    }
    public void Mostrar()
    {
        gameObject.SetActive(true);
    }
}