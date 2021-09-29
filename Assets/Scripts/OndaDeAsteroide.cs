using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaDeAsteroide : MonoBehaviour
{
    public ComportamentoAsteroide prefabAsteroide;
    public int quantosAsteroides = 3;

    // Start is called before the first frame update
    void Start()
    {
        // loop para gerar os asteroides
        for (int i = 0; i < quantosAsteroides; i++)
        {
            // criando randomicamente valor para o eixo x
            float x = Random.Range(-7.0f, 7.0f); //TODO - melhorar a forma de pegar os valores da tela do jogo
            // criando randomincamente valor para o eixo y
            float y = Random.Range(-4.0f, 4.0f); //TODO - melhorar a forma de pegar os valores da tela do jogo
            // cria a variável com o valor da posição
            Vector3 posicao = new Vector3(x, y, 0.0f);
            // intancia a posição no objeto
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }

}
