using TMPro;
using UnityEngine;

public class GerenteDeJogo : MonoBehaviour {
    [Header("Referências Públicas")]
    public GameObject alvo;
    public TextMeshProUGUI textoPontos;

    [Header("Configuração Jogo")]
    public int pontosPorAlvo = 10;
    public float intervaloCriacao = 2f;
    private int pontosTotais = 0;

    private void Start() {
        InvokeRepeating(nameof(CriarAlvos), 0f, intervaloCriacao);
    }

    private void Update() {
        textoPontos.text = pontosTotais.ToString();
    }

    public void AdicionarPontos() {
        pontosTotais = pontosTotais + pontosPorAlvo;
    }

    private void CriarAlvos() {
        float chance = Random.value;
        float x;
        float y;

        if (chance < 0.5f) {
            x = -10f;
        } else {
            x = 10f;
        }

        y = Random.Range(-3.5f, 0.5f);

        GameObject novoAlvo = Instantiate(alvo, new Vector2(x, y), Quaternion.identity);

        Alvo scriptDoAlvoNovo = novoAlvo.GetComponent<Alvo>();

        if (x < 0) {
            scriptDoAlvoNovo.direcao = 1f;
        } else {
            scriptDoAlvoNovo.direcao = -1f;
        }
    }
}






