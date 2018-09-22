using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void PlayButton(string newGame){
		SceneManager.LoadScene(newGame);
	}

	public void QuitButton(){
		Application.Quit();
	}
}
