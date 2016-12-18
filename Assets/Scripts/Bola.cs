using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bola : MonoBehaviour {

    GameObject prefab;
    public GUIText hihi;
	// Use this for initialization
	void Start () {
        prefab = Resources.Load("Bola") as GameObject;
        
	}

    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            Text ThisText = GameObject.FindWithTag("scoring").GetComponent<Text>() as Text;
            
            Object.Destroy(projectile, 3.0f);
            Vector3 v = transform.position ;
            if(Screen.height/2 >= Input.mousePosition.y)
            { 
                v.y = v.y+ Input.mousePosition.y-Screen.height/2;
            }
            else
            {
               
                v.y = v.y + Input.mousePosition.y-Screen.height/2;
            }
            if (Screen.width / 2 >= Input.mousePosition.x)
            {
                
                v.x = v.x+Input.mousePosition.x - Screen.width / 2;
            }
            else
            {
                
                v.x = v.x+Input.mousePosition.x - Screen.width / 2;
            }


            projectile.transform.position = v + Camera.main.transform.forward * 300;

            
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity  = Camera.main.transform.forward * 2000;
            
        }
        

    }
}
