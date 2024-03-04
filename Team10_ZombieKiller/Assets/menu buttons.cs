using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
    public void Play()
    {
        SceneManagement.LoadScene(SceneManagement.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
      Application.Quit();  
      Debug.Log("Player Has Quit The Game");
    }
}
