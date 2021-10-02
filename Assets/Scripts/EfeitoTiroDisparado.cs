using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoTiroDisparado : MonoBehaviour
{
    // coleta o áudio do objeto
    public AudioSource meuAudioSource;
    // cria variável para o delay da destruição do efeito
    public float delayAutoDestruir = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // inicia o som
        meuAudioSource.Play();
        // destrói o obejto com delay
        Destroy(gameObject, delayAutoDestruir);
    }

}
