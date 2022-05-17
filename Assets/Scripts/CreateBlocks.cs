using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{
    public GameObject block;

    // Start is called before the first frame update
    void Start() {
        for(int i = 0; i < 25; ++i) {
            GameObject obj = (GameObject) Instantiate(block, new Vector3(i-12.0f, 0.35f, 20.0f), block.transform.rotation);
            obj.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
