using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour {
    Scene GameScene;
    void Start() {}
    void Update() {}

    public void OnPlayButton() {
        // GameObject[] gameObjects = GameScene.GetRootGameObjects();
    }

    public void OnExitButton() {
        SceneManager.LoadScene("ExitScene", LoadSceneMode.Single);
    }
}
