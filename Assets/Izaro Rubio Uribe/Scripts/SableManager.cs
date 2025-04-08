using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SableManager : MonoBehaviour
{
    public GameObject sableDerecho;

    void Start()
    {
        // Leer si el jugador activó el doble sable
        bool dobleSableActivo = PlayerPrefs.GetInt("DobleSable", 0) == 1;

        sableDerecho.SetActive(dobleSableActivo);
    }
}
