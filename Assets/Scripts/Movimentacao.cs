using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    // variável de velocidade
    public float velocidade = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // verifica se a tecla Espaço foi apertada
        if(Input.GetKey(KeyCode.Space)) 
        {
            // movimenta para a direita
            transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);
        }

        // verifica se a seta para direita foi apertada
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            // movimenta para a direita
            transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);

        }

        // verifica se a seta para esquerda foi apertada
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            // movimenta para a esquerda
            transform.position += new Vector3(velocidade * -Time.deltaTime, 0.0f, 0.0f);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0.0f, velocidade * Time.deltaTime, 0.0f);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0.0f, velocidade * -Time.deltaTime, 0.0f);
        }
    }
}
