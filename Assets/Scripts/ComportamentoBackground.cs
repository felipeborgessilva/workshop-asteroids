using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoBackground : MonoBehaviour
{
    // cria a variável
    public MeshRenderer meuMashRenderer; 
    // cria variável da velocidade do background
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // calculo para o deslocamento lateral do background
        meuMashRenderer.material.mainTextureOffset += new Vector2(velocidade * Time.deltaTime, 0);
    }
}
