using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class translevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision col)
    {
        //Application.LoadLevel(1);
        SceneManager.LoadScene("Interior", LoadSceneMode.Additive);
    }
}
