using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour{

    public string nextScene = "Level2";
    
    void OnTriggerEnter(Collider other) {
        //if (other.CompareTag("Player"))
        if (other.gameObject.tag == "Player"){
                LoadNextScene(); 
            }
    }

    void LoadNextScene() {
            SceneManager.LoadScene(nextScene);
    }
}
