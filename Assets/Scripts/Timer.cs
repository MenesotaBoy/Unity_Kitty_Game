using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    [SerializeField] PlayerController player ;
    
    // Use this for initialization
    void Start () {
        player.score = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
