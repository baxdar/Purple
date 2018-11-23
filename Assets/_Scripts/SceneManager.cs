using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {
    public Char SavedPlayer;
    public List<GameObject> UI;
    public List<GameObject> Weapons;
    //will handle transitions between levels & main menu
    //as well as tracking player
    //maybe level generation too? prob should be a different script

    private static SceneManager _instance;

    //This is the public reference that other classes will use
    public static SceneManager instance {
        get {
            //If _instance hasn't been set yet, we grab it from the scene
            //This will only happen the first time this reference is used.
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<SceneManager>();
            return _instance;
        }
    }

    void LoadScene() {
        //Instantiate(SavedPlayer, new Vector3(0, 0, 0), new Quaternion());
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
