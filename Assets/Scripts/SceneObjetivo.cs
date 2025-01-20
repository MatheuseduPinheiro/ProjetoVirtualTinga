using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneObjetivo : MonoBehaviour
{
    public void jogar(){
        SceneManager.LoadScene(1);
    }

    public void ButtonBackRegras()
    {
        SceneManager.LoadScene(2); 
    }
}
