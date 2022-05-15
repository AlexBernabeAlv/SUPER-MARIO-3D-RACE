using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCoin : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 12; ++i)
        {
            GameObject obj;
            if (i % 2 == 0) obj = (GameObject)Instantiate(coin, new Vector3(-3.0f, 1.0f, 30.0f +i), coin.transform.rotation);
            else obj = (GameObject)Instantiate(coin, new Vector3(3.0f, 1.0f, 30.0f+i), coin.transform.rotation);
            obj.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
