
using TMPro;
using UnityEngine;

public class Marcador : MonoBehaviour
{
    public TMP_Text puntosText;
    private int puntos = 0;

    // Sumar puntos en el marcador
    public void SumarPuntos()
    {
        puntos++;
        puntosText.text = puntos.ToString(); // Actualizar el texto de los puntos
    }
}
