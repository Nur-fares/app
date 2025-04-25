using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TextMeshProUGUI roleText;

    private string selectedRole = "";

    // Esta versión NO se usa en el botón directamente
    public void SetRole(string role)
    {
        selectedRole = role;
        roleText.text = "Rol seleccionado: " + role;
    }

    // Estas SÍ se usan en los botones (una para cada rol)
    public void SetRoleProfesor()
    {
        SetRole("Profesor");
    }

    public void SetRoleAlumno()
    {
        SetRole("Alumno");
    }

    public void OnLoginButtonPressed()
    {
        string username = usernameInput.text;

        if (username != "" && selectedRole != "")
        {
            PlayerPrefs.SetString("username", username);
            PlayerPrefs.SetString("role", selectedRole);
            SceneManager.LoadScene("MainMenuScene");
        }
        else
        {
            Debug.LogWarning("Por favor, completa todos los campos.");
        }
    }
}