using UnityEngine;

public class JogadorMovimento : MonoBehaviour {
    [Header("Referências Públicas")]
    [Tooltip("Rigidbody é o componente que controla a física na Unity")]
    public Rigidbody2D rb;

    [Header("Variáveis de Movimento")]
    public float velocidade = 5.0f;
    [Range(5.0f, 9.0f)] public float forcaPulo = 7.0f;
    
    [Header("Status de Sistema")]
    [Tooltip("Essa variável é utilizada para mostrar quanto o usuário está se movendo e em qual direção")]
    public float movimentoX;
    public bool estaNoChao = true;
    public bool podePularDenovo = true;

    private void Update() {
        movimentoX = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(movimentoX * velocidade, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && podePularDenovo == true && estaNoChao == false) {
            podePularDenovo = false;
            Pulo();
        }

        if(Input.GetKeyDown(KeyCode.Space) && estaNoChao == true) {
            estaNoChao = false;
            Pulo();
        }
    }

    public void Pulo() {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("chao")) {
            estaNoChao = true;
            podePularDenovo = true;
        }
    }
}
