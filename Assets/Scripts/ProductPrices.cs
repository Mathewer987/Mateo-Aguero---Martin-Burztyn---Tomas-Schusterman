using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}