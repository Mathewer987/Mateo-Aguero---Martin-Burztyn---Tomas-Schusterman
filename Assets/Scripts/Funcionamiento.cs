using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Funcionamiento : MonoBehaviour
{
    public GameObject[] productosArray1; // Referencia a los productos del array 1
    public GameObject[] productosArray2; // Referencia a los productos del array 2
    public GameObject producto1;
    public GameObject producto2;
    public Text txtPrecio1;
    public Text txtPrecio2;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            VerificarProductos();
            OcultarTodosLosProductos();
            GenerarProductos();
            // Muestra los productos seleccionados
            producto1.SetActive(true);
            producto2.SetActive(true);
        }
        catch (System.Exception ex)
        {
            Debug.LogError(ex.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void VerificarProductos()
    {
        if ((productosArray1 == null || productosArray1.Length == 0) ||
            (productosArray2 == null || productosArray2.Length == 0))
        {
            throw new System.Exception("No hay productos en uno de los arrays.");
        }
    }

    void OcultarTodosLosProductos()
    {
        Debug.Log("Ocultando todos los productos en ambos arrays");
        foreach (GameObject producto in productosArray1)
        {
            if (producto != null)
            {
                producto.SetActive(false);
            }
        }
        foreach (GameObject producto in productosArray2)
        {
            if (producto != null)
            {
                producto.SetActive(false);
            }
        }
    }

    void GenerarProductos()
    {
        int indiceProducto1 = Random.Range(0, productosArray1.Length);
        int indiceProducto2 = Random.Range(0, productosArray2.Length);

        Debug.Log($"Producto 1 index: {indiceProducto1}");
        Debug.Log($"Producto 2 index: {indiceProducto2}");

        producto1 = productosArray1[indiceProducto1];
        producto2 = productosArray2[indiceProducto2];
        StartCoroutine(WaitForMilliseconds());
        txtPrecio1.text = producto1.GetComponent<ProductPrices>().precio.ToString();
        txtPrecio2.text = producto2.GetComponent<ProductPrices>().precio.ToString();
    }
    IEnumerator WaitForMilliseconds()
    {
        yield return new WaitForSeconds(.05f);
        producto1.SetActive(true);
        producto2.SetActive(true);
    }
}