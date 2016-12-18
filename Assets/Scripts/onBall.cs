using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class onBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision col)
    {


        if (col.collider.name == "inside")
        {
            var distance = Vector3.Distance(Camera.main.transform.position, transform.position);
            //Text ThisText = GameObject.FindWithTag("scoring").GetComponent<Text>() as Text;
            //Debug.Log(ThisText.text.ToString());
            //int i;
            //int.TryParse(ThisText.text.ToString(), out i);
            //ThisText.text = (i+1).ToString();
            //ThisText.text = distance.ToString();

            Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update () {
	
	}
}
