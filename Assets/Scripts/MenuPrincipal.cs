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
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
