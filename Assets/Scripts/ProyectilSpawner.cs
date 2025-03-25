using System.Collections;
using UnityEngine;

public class ProyectilSpawner : MonoBehaviour
{
    public GameObject proyectilPrefab; 
    public Transform jugadorTransform; // Transform del jugador (c�mara)
    public float distancia = 10f; // Distancia fija desde el jugador
    // Tiempos entre instancias
    public float tiempoSpawnMin = 2f; 
    public float tiempoSpawnMax = 3f;
    // Rango para variar la direcci�n del cubo
    public float destinationOffsetRange = 2f; 

    void Start()
    {
        // Iniciar bucle
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true) // Bucle infinito para instanciar cubos
        {
            // Calcular offset aleatorio para variar la direcci�n
            float offset = Random.Range(-destinationOffsetRange, destinationOffsetRange);

            // Calcular  posici�n de instanciaci�n
            Vector3 spawnPos = jugadorTransform.position + (jugadorTransform.forward * distancia);
            spawnPos += jugadorTransform.right * offset;

            // Fijar altura en la generaci�n del proyectil
            spawnPos.y = 1f;

            // Instanciar cubo/proyectil
            GameObject cube = Instantiate(proyectilPrefab, spawnPos, Quaternion.identity);

            // Dar direcci�n hacia el jugador con un ligero offset
            cube.AddComponent<ProyectilMov>().Initialize(jugadorTransform.position, offset);

            // Esperar un tiempo aleatorio (2-3'') antes de instanciar el siguiente cubo
            yield return new WaitForSeconds(Random.Range(tiempoSpawnMin, tiempoSpawnMax));
        }
    }

}
