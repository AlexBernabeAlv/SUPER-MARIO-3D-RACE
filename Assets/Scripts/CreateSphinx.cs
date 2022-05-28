using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateSphinx : MonoBehaviour
{
    public GameObject sphinx;
    GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "LEVEL5")
        {
            obj = new GameObject[4];
            for (int i = 0; i < 4; ++i)
            {
                if (i % 2 == 0) obj[i] = (GameObject)Instantiate(sphinx, new Vector3(-8.0f, -1.0f, 30.0f + i * 10), sphinx.transform.rotation);
                else
                {
                    obj[i] = (GameObject)Instantiate(sphinx, new Vector3(8.0f, -1.0f, 30.0f + i * 10), sphinx.transform.rotation);
                    obj[i].transform.Rotate(0, 180, 0);
                }
                obj[i].transform.parent = transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
