using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCoin : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "LEVEL1")
        {
            for (int i = 0; i < 12; ++i)
            {
                GameObject obj;
                if (i % 2 == 0) obj = (GameObject)Instantiate(coin, new Vector3(-3.0f, 1.0f, 30.0f + i), coin.transform.rotation);
                else obj = (GameObject)Instantiate(coin, new Vector3(3.0f, 1.0f, 30.0f + i), coin.transform.rotation);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL2") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL3") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL4") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL5") { }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
