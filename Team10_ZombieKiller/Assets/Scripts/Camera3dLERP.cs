using UnityEngine;

public class Camera3DLERP : MonoBehaviour {
    private Transform target;     // drag intended Player object into Inspector slot
    public float smoother = 5f;
    public Vector3 offset;     // set the offset in the editor

    void Start(){
       target = GameObject.FindWithTag("CameraFocus").GetComponent<Transform>();
    }

    void FixedUpdate () {
       Vector3 newPos = target.position + offset;
       Vector3 smPos = Vector3.Lerp (transform.position, newPos, smoother * Time.deltaTime);
       transform.position = smPos;

      //Vector3 targetFocus = new Vector3(target.position.x, target.position.y + 3f, target.position.z + 22f);
       transform.LookAt (target);
    }
}