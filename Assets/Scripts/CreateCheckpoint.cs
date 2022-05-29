using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCheckpoint : MonoBehaviour
{
    public GameObject checkpoint;
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "LEVEL1")
        {
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(4.5f - i * 9.0f, 1.65f, 30.0f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL2")
        {
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(6.0f - i * 12.0f, 1.65f, 58.5f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL3")
        {
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(0.5f - i * 5.0f, 1.65f, 43.5f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL4")
        {
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(4.5f - i * 9.0f, 1.65f, 70.0f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(8.0f - i * 16.0f, 1.65f, 70.0f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(12.0f - i * 24.0f, 1.65f, 70.0f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL5")
        {
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(4.5f - i * 9.0f, 1.65f, 28.0f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(4.0f - i * 8.0f, 1.65f, 59.4f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(9.0f - i * 18.0f, 1.65f, 59.4f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(14.0f - i * 28.0f, 1.65f, 59.4f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
            for (int i = 0; i < 2; ++i)
            {
                obj = (GameObject)Instantiate(checkpoint, new Vector3(6.0f - i * 12.0f, 1.65f, 103.0f), checkpoint.transform.rotation);
                obj.transform.Rotate(0, 0, (i - 1) * 180);
                obj.transform.parent = transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
