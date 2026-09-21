using UnityEngine;

public class Alvo : MonoBehaviour {
    [Header("Movimento")]
    public float velocidade = 5f;
    public float direcao = -1f;

    private void Update(){
        transform.Translate(velocidade * direcao * Time.deltaTime * Vector2.right);
    }
}
