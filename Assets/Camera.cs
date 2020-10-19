using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public GameObject kus;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(kus.gameObject.transform.position.x +0.8f, 3.24f, -6.267f);
	
	}
}
