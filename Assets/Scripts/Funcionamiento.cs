using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Funcionamiento : MonoBehaviour
{
    public GameObject[] productosArray1; // Referencia a los productos del array 1
    public GameObject[] productosArray2; // Referencia a los productos del array 2
    private GameObject producto1;
    private GameObject producto2;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            VerificarProductos();
            OcultarTodosLosProductos();
            GenerarProductos();
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

        // Muestra los productos seleccionados
        MostrarProducto(producto1);
        MostrarProducto(producto2);
    }

    void MostrarProducto(GameObject producto)
    {
        if (producto != null)
        {
            Debug.Log($"Mostrando producto: {producto.name}");
            producto.SetActive(true);
        }
    }
}
