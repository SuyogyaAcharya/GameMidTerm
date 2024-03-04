using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour {
     void Update () {
            // transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
     }

     void OnTriggerEnter(Collider other){
             if (other.gameObject.tag == "Player") {
                 gameObject.SetActive(false);
             }
      }
}