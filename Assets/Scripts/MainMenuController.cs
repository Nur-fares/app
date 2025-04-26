using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MainMenuController : MonoBehaviour
{
    public TMP_Text welcomeText;

    void Start()
    {
        string name = PlayerPrefs.GetString("username");
        string role = PlayerPrefs.GetString("role");
        string message = "Hola " + role + " " + name;
        Debug.Log(message);
        welcomeText.text = message;
    }
}