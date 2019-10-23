using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

   public void QuitGame()
   {
	   Application.Quit ();
	   Debug.Log ("Quit");
   }
    
	public void StartGame()
	{
		SceneManager.LoadScene("SampleScene");
	}
}
