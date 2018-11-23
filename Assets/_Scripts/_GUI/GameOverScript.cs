using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    public GameObject RetryScreen;

    public void activateRetryGUI() {
        RetryScreen.SetActive(true);
    }

	// Use this for initialization
	void Start () {
        if (RetryScreen == null) {
            Debug.Log("Retry screen is undefined");
        }
    }

    private void Awake() {
        SceneManager.instance.SavedPlayer.Health.DeathDelegate += activateRetryGUI;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
