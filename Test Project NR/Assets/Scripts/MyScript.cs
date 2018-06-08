using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MyScript : MonoBehaviour {

    public float Hitpoints;
    public float mySpeed = 5f;
    public FirstPersonController myController;
	// Use this for initialization
	void Start () {
        Hitpoints = 100f;
	}
	
	// Update is called once per frame
	void Update () {

        //Hitpoints = Hitpoints - 1f;
        //mycontroller.WalkSpeed = MySpeed;
        if (Input.GetKeyDown(KeyCode.Escape)) {
            print("I have quit");
            Application.Quit();

        }

    }
}
