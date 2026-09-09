using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void CarregarJogoDoCoelho()
    {
        SceneManager.LoadScene("Coelinho");
    }

    public void FecharJogoEPararProjeto()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
