using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
    public Canvas Karakter;
    public Canvas Hazırlayanlar;
         
	
	// Use this for initialization
	void Start () 
		
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
        Karakter.enabled = false;
        Hazırlayanlar.enabled = false;

    }
	
	
	public void ExitPress()
		
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}
	
	public void NoPress()
		
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		
	}
	
	public void StartLevel()
		
	{
        //Application.LoadLevel (1);
        Karakter.enabled = true;
	}
	
	public void ExitGame()
		
	{
		Application.Quit ();
	}
    public void tuna()
    {
        Application.LoadLevel(1);
    }
    public void ayda()
    {
        Application.LoadLevel(2);
    }
    public void melih()
    {
        Application.LoadLevel(7);
    }
    public void maşuk()
    {
        Application.LoadLevel(6);
    }
    public void erkan()
    {
        Application.LoadLevel(5);
    }
    public void hakan()
    {
        Application.LoadLevel(10);
    }
    public void yunus()
    {
        Application.LoadLevel(8);
    }
    public void yusuf()
    {
        Application.LoadLevel(9);
    }
    public void emre()
    {
        Application.LoadLevel(4);
    }
    public void elleran()
    {
        Application.LoadLevel(3);
    }
    public void Hazirlayanlar()
    {
        Hazırlayanlar.enabled = true;
        Debug.Log("hhhh");
    }
    public void cikis()
    {
        Hazırlayanlar.enabled = false;
    }
}
