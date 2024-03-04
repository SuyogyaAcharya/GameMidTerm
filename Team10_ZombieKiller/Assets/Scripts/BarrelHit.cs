using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHit : MonoBehaviour{

    private GameHandler gameHandler;
    public int points = -1;
    //public AudioSource deathCry_SFX;

    void Start(){
        gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            gameObject.GetComponent<Collider>().enabled = false;
            gameHandler.AddToScore(points);
            //deathCry_SFX.Play();
            StartCoroutine(DestroyBarrel());
        }
    }

    IEnumerator DestroyBarrel(){
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
