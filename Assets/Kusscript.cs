using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kusscript : MonoBehaviour {

    public float hiz;
    public float ziplamaGucu;
    public int puan;
    public AudioClip[] sesDosyalari;
    public GameObject canvas;
    public Text rekor;
    public Text puanText;
    // Use this for initialization
    void Start () {
        canvas.SetActive(false);
        puan = 0;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
  

        transform.Translate(Vector3.right * hiz * Time.deltaTime);
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);
                GetComponent<AudioSource>().PlayOneShot(sesDosyalari[3], 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        { 
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[3], 1);
        }

	}

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Tetik")
        {
            GetComponent<AudioSource>().PlayOneShot(sesDosyalari[1], 1);
            temas.gameObject.transform.parent.root.gameObject.GetComponent<Patika>().temasEdildimi = true;
            puan++;
        }
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Engel")
        {
            Oyunsonu();
        }
    }

    void Oyunsonu()
    {
        Time.timeScale = 0;
        GetComponent<AudioSource>().PlayOneShot(sesDosyalari[0], 1);
        canvas.SetActive(true);


        if(puan > PlayerPrefs.GetInt("Rekor"))
        {
            PlayerPrefs.SetInt("Rekor", puan);
        }

        puanText.text = puan.ToString();
        rekor.text = PlayerPrefs.GetInt("Rekor").ToString();
    }
    public void TekrarButton()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    
    }
