using UnityEngine;
using System.Collections;

public class onBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision col)
    {


        if (col.collider.name == "inside")
        {

            Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update () {
	
	}
}
