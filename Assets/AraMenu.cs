using UnityEngine;
using System.Collections;

public class AraMenu : MonoBehaviour
{

    public bool acik;
    public bool ayarlarbool;
    public GameObject Panel;
    public GameObject AyarlarPanel;
    void Update()
    {
        if (ayarlarbool)
        {
            AyarlarPanel.SetActive(true);
        }
        if (!ayarlarbool)
        {
            AyarlarPanel.SetActive(false);
        }
    }
    public void butonlar(string isim)
    {
        if (isim == "ayarlar")
        {
            ayarlarbool = true;
        }
    }
}