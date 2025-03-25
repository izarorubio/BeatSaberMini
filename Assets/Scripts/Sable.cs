using UnityEngine;

public class Sable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Si el objeto con el que colisiona tiene tag "Cube"...
        if (other.CompareTag("Cube"))
        {
            // Destruir el cubo al golpear
            Destroy(other.gameObject);
            // Sumar puntos en el marcador
            FindAnyObjectByType<Marcador>().SumarPuntos();

        }
    }
}
