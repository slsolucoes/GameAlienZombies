using UnityEngine;
using System.Collections;

public class Colider : MonoBehaviour {

	// Use this for initialization
	void Start () {
    
    }
    // Update is called once per frame
    void Update () {
	    
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(gameObject.name + " just collided with " + col.gameObject.name);
        if (col.gameObject.name == "Chao")
        {
            Destroy(col.gameObject);
        }
    }

}
