using UnityEngine;
using System.Collections;

public class buttonManager : MonoBehaviour {
	/*

	public void nextButton1(){
		Application.LoadLevel ("2");
	}
	public void nextButton2(){
		Application.LoadLevel ("3");
	}
	public void nextButton3(){
		Application.LoadLevel ("4");
	}
	public void nextButton4(){
		Application.LoadLevel ("5");
	}
	public void previousButton2(){
		Application.LoadLevel ("1");
	}
	public void previousButton3(){
		Application.LoadLevel ("2");
	}
	public void previousButton4(){
		Application.LoadLevel ("3");
	}
	public void previousButton5(){
		Application.LoadLevel ("4");
	}
*/



	public void fadebutton(){
		GameObject.Find ("RawImage").GetComponent<Animator> ().SetTrigger("fade");
		StartCoroutine ("waitandswitch");
	}

	IEnumerator waitandswitch(){
		yield return new WaitForSeconds (1f);
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}
	public void fadebutton2(){
		GameObject.Find ("RawImage").GetComponent<Animator> ().SetTrigger("fade");
		StartCoroutine ("waitandswitch1");
	}
	
	IEnumerator waitandswitch1(){
		yield return new WaitForSeconds (1f);
		int i = Application.loadedLevel;
		Application.LoadLevel(i - 1);
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
