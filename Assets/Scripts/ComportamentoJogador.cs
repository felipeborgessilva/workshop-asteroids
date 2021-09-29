using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float aceleracao = 1.0f;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 10.0f;
    public Animator animator;
    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;

    void  Start() {
        // animator = GetComponent<Animator>();
    }

    void Update() {
        // se a tecla espaço foi apertada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(
                prefabProjetil, 
                meuRigidbody.position, 
                Quaternion.identity
            );
            projetil.velocity = transform.up * velocidadeProjetil;
        }    
    }

    // Update is called once per frame - Estudar sobre FixedUpdate - Usado para movimentação de personagem
    void FixedUpdate()
    {
        // se a tecla seta pra cima for apertada
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direcao = transform.up * aceleracao;
            // cria a força para impulsionar a nave
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);
            // animator.SetBool("taCorrendo", true);
        } else {
            // animator.SetBool("taCorrendo", false);
        }

        // se tecla seta pra esquerda for apertada
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // rotaciona o objeto sentido antihorário
            meuRigidbody.rotation += velocidadeAngular * Time.deltaTime; 
        }

        // se tecla seta pra direita for apertada
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // rotaciona o objeto no sentido horário
            meuRigidbody.rotation -= velocidadeAngular * Time.deltaTime; 
        }

        // verifica se a velocidade é maior que a máxima
        if (meuRigidbody.velocity.magnitude > velocidadeMaxima)
        {
            // atribui o valor máximo de velocidade ao objeto
            meuRigidbody.velocity = Vector2.ClampMagnitude(
                meuRigidbody.velocity,
                velocidadeMaxima
            );
        }
    }

    // atualiza na colisão do objeto
    void OnTriggerEnter2D(Collider2D outro) {
        // destrói o objeto do contexto
        Destroy(gameObject);
    }

}
