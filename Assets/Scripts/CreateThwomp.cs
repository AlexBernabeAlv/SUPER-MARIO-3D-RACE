using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateThwomp : MonoBehaviour
{
    public GameObject thwomp;

    // Start is called before the first frame update
    void Start()
    {

        if (SceneManager.GetActiveScene().name == "LEVEL1")
        {

            for (int i = 0; i < 2; ++i)
            {
                GameObject obj;
                if (i % 2 == 0) obj = (GameObject)Instantiate(thwomp, new Vector3(-3.0f, 3.0f, 80.0f), thwomp.transform.rotation);
                else obj = (GameObject)Instantiate(thwomp, new Vector3(3.0f, 3.0f, 80.0f), thwomp.transform.rotation);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL2")
        {
            for (int i = 0; i < 2; ++i)
            {
                GameObject obj;
                if (i % 2 == 0) obj = (GameObject)Instantiate(thwomp, new Vector3(-2.0f, 3.0f, 75.0f), thwomp.transform.rotation);
                else obj = (GameObject)Instantiate(thwomp, new Vector3(2.0f, 3.0f, 75.0f), thwomp.transform.rotation);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL3") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL4")
        {
            for (int i = 0; i < 4; ++i)
            {
                GameObject obj;
                if (i % 2 == 0) obj = (GameObject)Instantiate(thwomp, new Vector3(-7.0f, 5.0f, 21.0f + i * 12.5f), thwomp.transform.rotation);
                else obj = (GameObject)Instantiate(thwomp, new Vector3(7.0f, 5.0f, 21.0f + (i - 1) * 12.5f), thwomp.transform.rotation);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL5") { }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
