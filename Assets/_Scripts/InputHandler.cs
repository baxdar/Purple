using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour {
    public Text DebugDisplay;

    public class IndividualInput {
        public IndividualInput(string InputCode) {
            inputcode = InputCode;
        }
        public string inputcode;
        
    }

	void Start () {
        if (DebugDisplay == null)
            Debug.Log("");
	}
	
	void Update () {
		
	}
}
