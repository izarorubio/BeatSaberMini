using UnityEngine;

public class SaberCollision : MonoBehaviour
{
    public ParticleSystem hitEffect; // Efecto de partículas cuando se corta un cubo

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        // Comprobamos si el objeto con el que colisionamos tiene el tag "Cube"
        if (other.CompareTag("Cube"))
        {
         
            // Destruye el cubo cuando sea golpeado
            Destroy(other.gameObject);
            FindAnyObjectByType<Marcador>().SumarPuntos(); // Sumar puntos en el marcador

        }
    }
}
