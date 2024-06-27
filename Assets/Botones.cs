using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public InputField InputResultado;
    public GameObject PanelJuego;
    public GameObject PanelLeyenda;
    public GameObject PanelNotificaciones;
    public Text EstadoResultado;
    public Text txtBtnVolverAJugar;
    public Scene SeleccionarJuegos;
    int Resultado;



    // Start is called before the first frame update
    void Start()
    {
        PanelJuego.SetActive(true);
        PanelLeyenda.SetActive(false);
        PanelNotificaciones.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnResponder()
    {
        if (InputResultado.text == "")
        {
            PanelJuego.SetActive(false);
            PanelLeyenda.SetActive(true);
        }

        else if (InputResultado.text != "")
        {
            Resultado = int.Parse(InputResultado.text);

            if (Resultado == 10)
            {
                PanelJuego.SetActive(false);
                PanelLeyenda.SetActive(false);
                PanelNotificaciones.SetActive(true);
                EstadoResultado.text = "La respuesta es correcta";
                txtBtnVolverAJugar.text = "Reiniciar el desafío";
            }

            else
            {
                PanelJuego.SetActive(false);
                PanelLeyenda.SetActive(false);
                PanelNotificaciones.SetActive(true);
                EstadoResultado.text = "La respuesta es incorrecta";
                txtBtnVolverAJugar.text = "Volver a intentarlo";

            }
        }
    }

    public void btnCancelar()
    {
        PanelJuego.SetActive(true);
        PanelLeyenda.SetActive(false);
        PanelNotificaciones.SetActive(false);
    }

    public void btnSalir()
    {
        PanelJuego.SetActive(false);
        PanelLeyenda.SetActive(false);
        PanelNotificaciones.SetActive(false);


    }

    public void btnVolverAJugar()
    {
        if (txtBtnVolverAJugar.text == "Volver a intentarlo")
        {
            PanelJuego.SetActive(true);
            PanelLeyenda.SetActive(false);
            PanelNotificaciones.SetActive(false);
        }

        else if (txtBtnVolverAJugar.text == "Reiniciar el desafío")
        {
            //nueva secuencia de cosas
        }
    }


}
