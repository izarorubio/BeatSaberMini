using UnityEngine;

public class SaberController : MonoBehaviour
{
    public Transform handTransform; // La transformaci�n del controlador de la mano
    public float sableLength = 1.0f; // Longitud del sable
    public GameObject sablePrefab;

    private GameObject saberInstance; // Instancia del sable

    void Start()
    {
        // Instanciar sable al inicio
        saberInstance = Instantiate(sablePrefab, handTransform.position, Quaternion.identity);
    }

    void Update()
    {
        // Actualizar posici�n y rotaci�n para que siga la mano
        saberInstance.transform.position = handTransform.position;
        saberInstance.transform.rotation = handTransform.rotation;

        // Ajustar longitud del sable
        saberInstance.transform.localScale = new Vector3(sableLength, sableLength, sableLength);
    }
}