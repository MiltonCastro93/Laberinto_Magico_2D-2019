using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public void nivel1() {
        SceneManager.LoadScene("Nivel01");
    }

    public void salir() {
        Application.Quit();
    }

}
