using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	public float speed = 9f;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	MovePlayer();
    }
    
    void MovePlayer()
    {
    	float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    	float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    	
    	transform.Translate(x,0,z);
    }
}
