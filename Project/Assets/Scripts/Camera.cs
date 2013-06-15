using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public Texture2D pauseButton;
	public Texture2D playButton;
	private Texture2D currentButton;
	public GUISkin transparentBorder,homeIconSkin;
	public Texture2D menuBG;
	public Texture2D HomeIcon,HomeIconPressed;
	// Use this for initialization
	
	
	void Start () 
	{
		Time.timeScale = 1;
		currentButton = pauseButton;
		Screen.orientation = ScreenOrientation.Landscape;
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		//int xpos = Screen.width-(playButton.width + Screen.width/9);
		
		//HI BRADEN!!! BASING BUTTON POSITIONS ON PIXEL OFFSET WON'T ALLOW YOU TO SCALE BY SCREEN SIZE
		//you need to use screen.width and screen.height or zero for everything GUI related
		GUI.skin = transparentBorder;			
		if (Time.timeScale == 0)
		{
			GUI.DrawTexture(new Rect(Screen.width-Screen.width/8.4f,0,Screen.width/7,Screen.height),menuBG);//Transparent bar
			if(GUI.Button(new Rect(Screen.width-(Screen.width/7.7f),Screen.height*7/9,Screen.width/7,Screen.height/7),HomeIcon))//Home button
			{
				HomeIcon = HomeIconPressed;
				Application.LoadLevel("StartScreen");
			}
		}
		if(GUI.Button(new Rect(Screen.width-(Screen.width/7.7f),Screen.height/9,Screen.width/7,Screen.height/7),currentButton))//Play/pause button
		{	
			if (Time.timeScale == 0)
			{
				Time.timeScale = 1;
				currentButton = pauseButton;
				
			}
			
			else if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				currentButton = playButton;

			}

		}
	}
}		
	
