using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSceneScript : MonoBehaviour {
    public void OnExitButton() {
        Application.Quit();
    }

    public void OnCancelButton() {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}