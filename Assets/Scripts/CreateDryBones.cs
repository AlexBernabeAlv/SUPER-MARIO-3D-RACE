using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDryBones : MonoBehaviour {

    public GameObject dryBones;

    // Start is called before the first frame update
    void Start() {
        GameObject obj = (GameObject)Instantiate(dryBones, new Vector3(-3.0f, -0.5f, 14.0f), dryBones.transform.rotation);
        obj.transform.parent = transform;
    }

    // Update is called once per frame
    void Update() {
        
    }
}
