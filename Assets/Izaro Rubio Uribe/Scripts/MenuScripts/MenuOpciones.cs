using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuOpciones : MonoBehaviour
{
    public Toggle sableDobleToggle;
    public TMP_Dropdown puntosDropdown;

    public void GuardarOpciones()
    {
        OpcionesJugador.instancia.usarSableDoble = sableDobleToggle.isOn;
        OpcionesJugador.instancia.puntosObjetivo = int.Parse(puntosDropdown.options[puntosDropdown.value].text);
    }
}
