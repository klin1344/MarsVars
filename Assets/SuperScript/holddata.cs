using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class holddata : MonoBehaviour {

    public List<Rock> rockContainer = new List<Rock>();

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
