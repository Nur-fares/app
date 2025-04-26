using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TextMeshProUGUI roleText;
    public TMP_Dropdown yearDropdown;
    public GameObject yearDropdownObject; // para mostrar/ocultar

    private string selectedRole = "";

    public void SetRole(string role)
    {
        selectedRole = role;
        roleText.text = "Rol seleccionado: " + role;

        // Solo mostrar el dropdown si es Alumno
        if (role == "Alumno")
        {
            yearDropdownObject.SetActive(true);
        }
        else
        {
            yearDropdownObject.SetActive(false);
        }
    }

    public void OnLoginButtonPressed()
    {
        string username = usernameInput.text;
        int yearSelectedIndex = yearDropdown.value;
        string selectedYear = yearDropdown.options[yearSelectedIndex].text;

        if (username != "" && selectedRole != "")
        {
            PlayerPrefs.SetString("username", username);
            PlayerPrefs.SetString("role", selectedRole);

            if (selectedRole == "Alumno")
            {
                PlayerPrefs.SetString("year", selectedYear);
            }

            SceneManager.LoadScene("MainMenuScene");
        }
        else
        {
            Debug.LogWarning("Por favor, completa todos los campos.");
        }
    }
}