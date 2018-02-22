using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {
    public Char SavedPlayer;
    //will handle transitions between levels & main menu
    //as well as tracking player

    void LoadScene() {
        Instantiate(SavedPlayer, new Vector3(0, 0, 0), new Quaternion());
        //will require variables like scene type, scaling variable etc. 
    }

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
