using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

    GameObject prefab;
	// Use this for initialization
	void Start () {
        prefab = Resources.Load("Bola") as GameObject;
	}

    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            Object.Destroy(projectile, 3.0f);
            projectile.transform.position = transform.position + Camera.main.transform.forward * 300;
            
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 800;
            
        }
        

    }
}
