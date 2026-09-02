using UnityEngine;

public class Movement : MonoBehaviour
{
    //variável 1
    //variável 2
    //variável 3

    float entradaX;
    public Animator controleAnimacao;
    public SpriteRenderer controleSprite;


    void Start() {
        
    }

    void Update() {

        controleAnimacao.SetBool("andando", entradaX != 0f);
        controleSprite.flipX = entradaX < 0f;
    }
}
