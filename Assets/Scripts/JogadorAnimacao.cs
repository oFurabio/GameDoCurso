using UnityEngine;

public class JogadorAnimacao : MonoBehaviour {
    [Header("Referências Públicas")]
    public Animator anim;
    public JogadorMovimento controleMovimento;
    public SpriteRenderer controleSprite;

    [Header("Status de Sistema")]
    public bool jogadorEstaAndando;

    private void Update() {
        jogadorEstaAndando = controleMovimento.movimentoX != 0;

        anim.SetBool("andando", jogadorEstaAndando);
        anim.SetBool("no chao", controleMovimento.estaNoChao);

        if (controleMovimento.movimentoX > 0) {
            controleSprite.flipX = false;
        }

        if (controleMovimento.movimentoX < 0) {
            controleSprite.flipX = true;
        }
    }
}
