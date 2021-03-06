using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoAsteroideDestruido : MonoBehaviour
{
    public ParticleSystem meuParticleSystem;
    public AudioSource meuAudioSource;
    public float delayAutoDestruir = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        meuParticleSystem.Play(false);
        // executa o som
        meuAudioSource.Play();
        // executa a destruição do próprio objeto de som
        Destroy(gameObject, delayAutoDestruir);
    }
}
