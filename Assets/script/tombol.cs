using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start () {
		
	}
	public void scene(string scene){
		Application.LoadLevel (scene);
	}
	public void scale(float scale){
		transform.localScale = new Vector2 (1/scale,1*scale);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
