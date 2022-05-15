using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePiranha : MonoBehaviour
{
    public GameObject piranha;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            if (i % 2 == 0) obj = (GameObject)Instantiate(piranha, new Vector3(-9.0f, -0.5f, 60.0f), piranha.transform.rotation);
            else
            {
                obj = (GameObject)Instantiate(piranha, new Vector3(9.0f, -0.5f, 60.0f), piranha.transform.rotation);
                obj.transform.Rotate(0.0f, 180.0f, 0.0f);
            }
            obj.transform.parent = transform;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
