using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public float speed = 5f; // Velocidad del cubo
    public float fixedHeight = 1f; // Altura fija sobre el suelo
    private Vector3 direction; // Dirección del movimiento

    public void Initialize(Vector3 target)
    {
        // Calcula la dirección hacia el jugador, pero ignora la diferencia en altura
        direction = (target - transform.position).normalized;

        // Asegura que el cubo tenga la altura fija
        transform.position = new Vector3(transform.position.x, fixedHeight, transform.position.z);
    }

    void Update()
    {
        // Mueve el cubo en la dirección calculada, pero conserva la altura fija
        transform.position += new Vector3(direction.x, 0, direction.z) * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, fixedHeight, transform.position.z);
    }

    private void Start()
    {
        // Destruye el cubo después de 5 segundos (o el tiempo que prefieras)
        Destroy(gameObject, 5f);
    }
}
