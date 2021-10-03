using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJogo : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("Jogo");
    } 
}
