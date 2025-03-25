
using TMPro;
using UnityEngine;

public class Marcador : MonoBehaviour
{
    public TMP_Text puntosText;
    private int puntos = 0;
    private int totalPuntos = 5;

    private ProyectilSpawner spawner;

    void Start()
    {
        // Buscar spawner en la escena
        spawner = FindObjectOfType<ProyectilSpawner>();
    }

    // Sumar puntos en el marcador
    public void SumarPuntos()
    {
        puntos++;
        puntosText.text = puntos.ToString(); // Actualizar el texto de los puntos

        // Si llega al total de puntos (nº de paredes)...
        if (puntos == totalPuntos)
        {
            puntosText.text = "FIN";

            FinDelJuego();
        }
    }

    //Llamar a detener lanzamiento de cubos si se finaliza el juego
    private void FinDelJuego()
    {
        Debug.Log("Juego Terminado!");
        if (spawner != null)
        {
            spawner.DetenerDisparos();
        }
    }
}
