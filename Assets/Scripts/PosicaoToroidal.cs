using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoToroidal : MonoBehaviour
{

    const float MARGEM = 0.5f;
    public Rigidbody2D meuRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // coleta a camera
        Camera camera = GameplayCamera.instancia.minhaCamera;

        var maxX = camera.orthographicSize * camera.aspect;
        var maxY = camera.orthographicSize;

        float LimiteEsquerda = -maxX;
        float LimiteDireita = maxX;
        float LimiteBaixo = -maxY;
        float LimiteCima = maxY;

        Vector2 pos = meuRigidbody.position;

        if (pos.x < LimiteEsquerda - MARGEM)
        {
            pos.x = LimiteDireita + MARGEM;
        }
        else if(pos.x > LimiteDireita + MARGEM)
        {
            pos.x = LimiteEsquerda - MARGEM;
        }

        if (pos.y < LimiteBaixo - MARGEM)
        {
            pos.y = LimiteCima + MARGEM;
        }
        else if(pos.y > LimiteCima + MARGEM)
        {
            pos.y = LimiteBaixo - MARGEM;
        }

        meuRigidbody.position = pos;
    }
}
