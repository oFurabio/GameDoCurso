using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    private bool jogoPausado = false;
    public GameObject painelDePausa;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            AlternarJogoPausado();
        }
    }

    public void AlternarJogoPausado() {
        jogoPausado = !jogoPausado;

        if(jogoPausado == true) {
            Time.timeScale = 0f;
            painelDePausa.SetActive(true);
        }

        if(jogoPausado == false) {
            Time.timeScale = 1f;
            painelDePausa.SetActive(false);
        }
    }

    public void ReiniciarOJogoAtual() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VoltarAoMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
