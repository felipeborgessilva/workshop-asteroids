using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float velocidadeMaxima = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        // coleta uma direção aleatória
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // atualiza na colisão do objeto
    void OnTriggerEnter2D(Collider2D outro) {
        // destrói o objeto do contexto
        Destroy(gameObject);
    }

}
