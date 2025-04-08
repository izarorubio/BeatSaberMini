using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;



public class SeleccionadorNiveles : MonoBehaviour
{
    [SerializeField] private string escenaNivelElegido;

    private void Start()
    {

        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        if (interactable != null)
        {
            interactable.selectEntered.AddListener(CambiarEscenaNivel);
        }
    }

    private void CambiarEscenaNivel(SelectEnterEventArgs args)
    {
        FindObjectOfType<MenuOpciones>()?.GuardarOpciones(); // Guardamos opciones
        SceneManager.LoadScene(escenaNivelElegido);
    }
}
