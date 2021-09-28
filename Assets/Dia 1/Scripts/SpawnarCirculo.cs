using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarCirculo : MonoBehaviour
{
    // cria a variável do objeto que irá spawnar na tela 
    public GameObject prefabCirculo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // verifica se a tecla enter foi pressionada
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // instancia na cena o objeto e a posição do mesmo
            Instantiate(prefabCirculo, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}
