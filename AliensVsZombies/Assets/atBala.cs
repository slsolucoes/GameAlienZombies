using UnityEngine;
using System.Collections;

public class atBala : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject playerAlien;
        GameObject playerZombie;
        playerAlien = GameObject.Find("ArmaAlien");
        playerZombie = GameObject.Find("ArmaZombie");
        GetComponent<Rigidbody>().AddForce(playerAlien.transform.forward * 200);
        GetComponent<Rigidbody>().AddForce(playerZombie.transform.forward * 200);
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 1f);
	}
}
