using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public static System.Action EventoAsteroideDestruido = null;
    public Rigidbody2D meuRigidbody;
    public ComportamentoAsteroide prefabAsteroidMenor;
    public float velocidadeMaxima = 2.0f;
    public int quantidadeFragmentos = 3;

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
        // destrói o projétil quando acerta o alvo
        Destroy(outro.gameObject);
        
        for (int i = 0; i < quantidadeFragmentos; i++)
        {
            Instantiate(
                prefabAsteroidMenor, 
                meuRigidbody.position, 
                Quaternion.identity
            );
        }

        if (EventoAsteroideDestruido != null)
        {
            EventoAsteroideDestruido();
        }

    }

}
