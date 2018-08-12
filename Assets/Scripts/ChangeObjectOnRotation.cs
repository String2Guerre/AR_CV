using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeObjectOnRotation : MonoBehaviour {

    public GameObject cube;
    public GameObject sphere;
    public GameObject topFace;


    // Use this for initialization
    void Start () {
        sphere.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {
        if ((topFace.transform.rotation.eulerAngles.x <= 60f || topFace.transform.rotation.eulerAngles.x >= 300f) 
            && (topFace.transform.rotation.eulerAngles.z <= 60f || topFace.transform.rotation.eulerAngles.z >= 300f))
        {
            Debug.Log("Désactive cube");
            cube.SetActive(false);
            sphere.SetActive(true);
        }
        else
        {
            Debug.Log("Désactive sphère");
            cube.SetActive(true);
            sphere.SetActive(false);
        }
	}

}
