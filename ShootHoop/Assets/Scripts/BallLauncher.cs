using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {


    public GameObject ballPrefab;
    public float ballSpeed = 5.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreateGO();
        }
    }

    private void CreateGO()
    {
        GameObject instanse = Instantiate(ballPrefab);
        instanse.transform.position = transform.position;
        var rb = instanse.GetComponent<Rigidbody>();
        var camera = GetComponentInChildren<Camera>();
        rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
    }
}
