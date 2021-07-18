using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class pausa : MonoBehaviour {

	// Use this for initialization

	bool pausado=false;

	public void Pause() {
		if (!pausado) {

			Time.timeScale = 0;
			pausado = true;
		} else {

			Time.timeScale = 1;
			pausado=false;
		}
	}

}
