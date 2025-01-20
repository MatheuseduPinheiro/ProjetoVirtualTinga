using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHome : MonoBehaviour
{

    // Vai pra regra
    public void ButtonPainel(){
        SceneManager.LoadScene(1);

    }

    public void QuitGame(){
        Application.Quit();
    }

    public void ButtonApagar(){
        SceneManager.LoadScene(6);
    }

}
