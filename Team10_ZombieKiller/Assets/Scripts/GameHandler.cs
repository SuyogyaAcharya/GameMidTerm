using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{ 

        public static int ZombiesKilled; 
        public GameObject ZokbiesKilled_text; 

        void Start () { 
                UpdateScore (); 
                } 

        void Update(){         //delete this quit functionality when a Pause Menu is added!
                if (Input.GetKey("escape")){
                        Application.Quit();
                } 

                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}
        } 

        public void AddToScore(int score){
             ZombiesKilled += score;
             UpdateScore();   
        }

        void UpdateScore () { 
                Text scoreTemp = ZokbiesKilled_text.GetComponent<Text>(); 
                scoreTemp.text = "Zombies Killed: " + ZombiesKilled; 
                } 

        public void StartGame(){
                SceneManager.LoadScene("Level1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){ 
                #if UNITY_EDITOR 
                UnityEditor.EditorApplication.isPlaying = false; 
                #else 
                Application.Quit(); 
                #endif 
        }
}