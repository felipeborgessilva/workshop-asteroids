using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float aceleracao = 1.0f;
    public float velocidadeAngular = 180.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // se a tecla W for apertada
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * aceleracao;
            // cria a força para impulsionar a nave
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);
        }

        // se tecla A for apertada
        if (Input.GetKey(KeyCode.A))
        {
            // rotaciona o objeto sentido antihorário
            meuRigidbody.rotation += velocidadeAngular * Time.deltaTime; 
        }

        // se tecla D for apertada
        if (Input.GetKey(KeyCode.D))
        {
            // rotaciona o objeto no sentido horário
            meuRigidbody.rotation -= velocidadeAngular * Time.deltaTime; 
        }
    }
}
