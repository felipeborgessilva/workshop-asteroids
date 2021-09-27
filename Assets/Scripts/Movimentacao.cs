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
    }
}
