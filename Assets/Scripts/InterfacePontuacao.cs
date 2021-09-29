using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfacePontuacao : MonoBehaviour
{
    public TMP_Text textoPontuacao;
    public int pontuacao;

    void Awake() 
    {
        // atribui texto vazio para a pontuação
        textoPontuacao.text = "";

        ComportamentoAsteroide.EventoAsteroideDestruido += AsteroideFoiDestruido;
    }

    void OnDestroy()
    {
        ComportamentoAsteroide.EventoAsteroideDestruido -= AsteroideFoiDestruido;
    } 

    void AsteroideFoiDestruido()
    {
        // acrescenta mais 100 pontos na variável de pontuação
        pontuacao += 100;
        // chama a função que atualiza a pontuação
        AtualizaTextoPontuacao();
    }    


    void AtualizaTextoPontuacao()
    {
        textoPontuacao.text = pontuacao.ToString();
    }

}
