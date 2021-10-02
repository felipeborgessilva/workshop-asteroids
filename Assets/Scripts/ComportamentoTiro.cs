using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoTiro : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    // cria a variável para coletar o áudio do tiro
    public EfeitoTiroDisparado prefabEfeitos;

    // Start is called before the first frame update
    void Start()
    {
        // instancia o efeito sonoro de destruição do asteróide 
        Instantiate(
            prefabEfeitos,
            meuRigidbody.position, 
            Quaternion.identity
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
