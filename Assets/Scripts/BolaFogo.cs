using Unity.VisualScripting;
using UnityEngine;

public class BolaFogo : MonoBehaviour {
    [Header("Informações da Bola")]
    public float tempoDeVida = 5f;
    public float velocidade = 7f;

    [Header("Status de sistema")]
    public float direcaoAtual = 1f;

    private void Start() {
        Destroy(gameObject, tempoDeVida);

        direcaoAtual = GameObject.FindGameObjectWithTag("Player")
            .transform.localScale.x;
        transform.localScale = new Vector2(direcaoAtual, 1f);
    }

    private void Update() {
        transform.Translate(Time.deltaTime * direcaoAtual * velocidade * Vector2.right);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
        
        GerenteDeJogo gdj = GameObject.FindGameObjectWithTag("Gerente").GetComponent<GerenteDeJogo>();
        gdj.AdicionarPontos();

        Destroy(gameObject);
    }
}
