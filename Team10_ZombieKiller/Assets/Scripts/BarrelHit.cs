using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHit : MonoBehaviour{

    private GameHandler gameHandler;
    public int points = -1;
    public GameObject barrelArt;
    //public AudioSource boom_SFX;
    public GameObject boom_VFX;
    private CameraShake cameraShake;

    void Start(){
        gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
        cameraShake = GameObject.FindWithTag("MainCamera").GetComponent<CameraShake>();
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            barrelArt.SetActive(false);
            cameraShake.ShakeCamera(0.15f, 0.3f);
            gameObject.GetComponent<Collider>().enabled = false;
            gameHandler.AddToScore(points);
            //boom_SFX.Play();
            GameObject boomVFX = Instantiate(boom_VFX, transform.position, Quaternion.identity);
            StartCoroutine(DestroyBarrel(boomVFX));
        }
    }

    IEnumerator DestroyBarrel(GameObject VFX){
        yield return new WaitForSeconds(1f);
        Destroy(VFX);
        Destroy(gameObject);
    }
}
