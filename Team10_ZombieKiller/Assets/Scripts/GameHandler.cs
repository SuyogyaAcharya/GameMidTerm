using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{ 

        public static int ZombiesKilled; 
        public GameObject ZokbiesKilled_text; 
        public Text FinalScore;
        public Text FinalTime; 
        private float startTime;

        void Start () { 
                UpdateScore ();
                startTime = Time.time; 
        } 

        void Update(){         //delete this quit functionality when a Pause Menu is added!
                // if (Input.GetKey("escape")){
                //         Application.Quit();
                // } 

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

                if (SceneManager.GetActiveScene().name == "Win_Scene") {
                        FinalScore.text = "FINAL Zombies Killed: " + ZombiesKilled;
                        // Calculate the final time
                        float finalTime = Time.time - startTime;
                        // Format the final time
                        string minutes = ((int)finalTime / 60).ToString("00");
                        string seconds = (finalTime % 60).ToString("00.00");
                        FinalTime.text = "Final Time: " + minutes + ":" + seconds;
                        ZombiesKilled = 0;
                }
        } 

        public void StartGame(){
                SceneManager.LoadScene("Tutorial");
                ZombiesKilled = 0;
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