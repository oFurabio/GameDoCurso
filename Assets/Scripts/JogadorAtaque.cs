using UnityEngine;

public class JogadorAtaque : MonoBehaviour {
    [Header("Referências Públicas")]
    public GameObject bolaDeFogo;
    public Transform pontoDeTiro;

    [Header("Tempo de Recarga")]
    public float tempoEntreAtaques = 1.5f;
    public float cronometro;

    private void Update() {
        cronometro = cronometro + Time.deltaTime;

        if (Input.GetKey(KeyCode.Return)) {
            if (cronometro >= tempoEntreAtaques) {
                Ataque();
            }
        }
    }

    public void Ataque() {
        Instantiate(bolaDeFogo, pontoDeTiro.position, Quaternion.identity);
        cronometro = 0f;
    }
}
