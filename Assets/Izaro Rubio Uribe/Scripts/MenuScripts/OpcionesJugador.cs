using UnityEngine;

public class OpcionesJugador : MonoBehaviour
{
    public static OpcionesJugador instancia;

    public bool usarSableDoble = false;
    public int puntosObjetivo = 5;

    private void Awake()
    {
        if (instancia != null && instancia != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
