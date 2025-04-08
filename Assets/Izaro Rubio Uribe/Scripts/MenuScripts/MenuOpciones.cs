using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuOpciones : MonoBehaviour
{
    public TMP_Dropdown puntosDropdown;
    public Toggle dobleSableToggle;

    void Start()
    {
        // Si ya se guardó una preferencia, usarla
        if (PlayerPrefs.HasKey("DobleSable"))
        {
            bool activo = PlayerPrefs.GetInt("DobleSable") == 1;
            dobleSableToggle.isOn = activo;
        }

        dobleSableToggle.onValueChanged.AddListener(OnToggleChanged);
    }

    public void OnToggleChanged(bool isOn)
    {
        // Guardar en PlayerPrefs (1 = activado, 0 = desactivado)
        PlayerPrefs.SetInt("DobleSable", isOn ? 1 : 0);
        PlayerPrefs.Save();
    }
    public void GuardarOpciones()
    {
        OpcionesJugador.instancia.puntosObjetivo = int.Parse(puntosDropdown.options[puntosDropdown.value].text);
    }
}
