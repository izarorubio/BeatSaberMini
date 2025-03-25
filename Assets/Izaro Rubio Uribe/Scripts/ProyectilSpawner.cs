using System.Collections;
using UnityEngine;

public class ProyectilSpawner : MonoBehaviour
{
    public GameObject proyectilPrefab; 
    public Transform jugadorTransform; // Transform del jugador (cámara)
    public float distancia = 10f; // Distancia fija desde el jugador
    // Tiempos entre instancias
    public float tiempoSpawnMin = 2f; 
    public float tiempoSpawnMax = 3f;
    // Rango para variar la dirección del cubo
    public float destinationOffsetRange = 2f;
    // Para detener los proyectiles cuando finalice
    private bool juegoTerminado = false;


    void Start()
    {
        // Iniciar bucle
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (!juegoTerminado) // Bucle para instanciar cubos (solo sigue si el juego no ha terminado)
        {
            // Calcular offset aleatorio para variar la dirección
            float offset = Random.Range(-destinationOffsetRange, destinationOffsetRange);

            // Calcular  posición de instanciación
            Vector3 spawnPos = jugadorTransform.position + (jugadorTransform.forward * distancia);
            spawnPos += jugadorTransform.right * offset;

            // Fijar altura en la generación del proyectil
            spawnPos.y = 1f;

            // Instanciar cubo/proyectil
            GameObject cube = Instantiate(proyectilPrefab, spawnPos, Quaternion.identity);

            // Dar dirección hacia el jugador con un ligero offset
            cube.AddComponent<ProyectilMov>().Initialize(jugadorTransform.position, offset);

            // Esperar un tiempo aleatorio (2-3'') antes de instanciar el siguiente cubo
            yield return new WaitForSeconds(Random.Range(tiempoSpawnMin, tiempoSpawnMax));
        }
    }

    // Detener el instanciar cubos (FIN)
    public void DetenerDisparos()
    {
        juegoTerminado = true;
        Debug.Log("Fin del juego, no se lanzan más cubos");
    }

}
