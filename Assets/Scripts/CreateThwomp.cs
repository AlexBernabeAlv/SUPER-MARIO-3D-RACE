using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateThwomp : MonoBehaviour
{
    public GameObject thwomp;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            if (i % 2 == 0) obj = (GameObject)Instantiate(thwomp, new Vector3(-3.0f, 3.0f, 80.0f), thwomp.transform.rotation);
            else obj = (GameObject)Instantiate(thwomp, new Vector3(3.0f, 3.0f, 80.0f), thwomp.transform.rotation);
            obj.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
