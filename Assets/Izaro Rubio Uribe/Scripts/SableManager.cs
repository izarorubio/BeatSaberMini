using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SableManager : MonoBehaviour
{
    public GameObject sableDerecho;

    void Start()
    {
        // Para saber si el sable doble est� activado en PlayerPrefs
        bool dobleSableActivo = PlayerPrefs.GetInt("SableDoble", 0) == 1;

        // Activar o desactivar el sable derecho seg�n la preferencia guardada
        sableDerecho.SetActive(dobleSableActivo);
    }
}
