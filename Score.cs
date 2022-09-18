using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
	int hits = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void OnCollisionEnter(Collision other)
    {
    	if(other.gameObject.tag != "Hit")
    	{
    		hits++;
    		Debug.Log("collide times : " + hits);
    	}
    	
    	if(other.gameObject.tag == "Finish" && hits == 0)
    	{
    		SceneManager.LoadScene("SampleScene");
    	}
    }    
}
