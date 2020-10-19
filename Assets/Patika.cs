using UnityEngine;
using System.Collections;


public class Patika : MonoBehaviour {


    public bool temasEdildimi;
    public GameObject borular;


    // Use this for initialization
    void Start () {

        temasEdildimi = false;
    }
	
	// Update is called once per frame
	void Update () {

        if(temasEdildimi)
        {
            Invoke("Ileriata", 2.9f);
            temasEdildimi = false;
        }
	
	}


    void Ileriata()
    {

        transform.position = transform.position + new Vector3(7.5f, 0, 0);

        float yPoz = Random.Range(0.01f,3.44f);
        borular.transform.localPosition = new Vector3(0, yPoz, 0.19f);

    }
}
