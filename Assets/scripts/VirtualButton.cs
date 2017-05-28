using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualButton : MonoBehaviour {

	public delegate void VirtualButtonClicked ();
	public event VirtualButtonClicked OnButtonClicked;

	void Start () {
		
	}

	void Update () {
		
	}

	public void NotifyButtonClicked () {
	
		if (OnButtonClicked != null) {
			OnButtonClicked ();
		}
	}
}
