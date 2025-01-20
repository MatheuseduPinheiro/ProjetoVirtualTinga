using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneRegras : MonoBehaviour{

     // vai pra area
    public void ButtonObjetivo(){
         SceneManager.LoadScene(3);
    }

    //Volta pra inicio
    public void ButtonBackInicio(){
         SceneManager.LoadScene(0);
    }
}
