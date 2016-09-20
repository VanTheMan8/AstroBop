using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RandomMaterialColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer r = GetComponent<Renderer>();
		r.material.color = new Color(
			0.8f + Random.value * 0.8f, 
			0.8f + Random.value * 0.8f, 
			0.8f + Random.value * 0.8f 
		);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
