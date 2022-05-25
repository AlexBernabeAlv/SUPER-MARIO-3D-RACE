using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateBulletBills : MonoBehaviour
{

    public GameObject bulletBill;
    public float runSpeed;
    GameObject[] obj;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "LEVEL1") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL2") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL3")
        {
            obj = new GameObject[6];
            for (int i = 0; i < 6; ++i)
            {
                if (i % 2 == 0)
                {
                    obj[i] = (GameObject)Instantiate(bulletBill, new Vector3(-16.75f, 0.25f, 66.5f + i * 5), bulletBill.transform.rotation);
                    obj[i].transform.Rotate(0, 0, 0);
                }
                else
                {

                    obj[i] = (GameObject)Instantiate(bulletBill, new Vector3(16.75f, 0.25f, 42f + (i - 1) * 5), bulletBill.transform.rotation);
                    obj[i].transform.Rotate(0, 180, 0);
                }
                obj[i].transform.parent = transform;
                //transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL4")
        {
            obj = new GameObject[6];
            for (int i = 0; i < 6; ++i)
            {
                if (i % 2 == 0)
                {
                    obj[i] = (GameObject)Instantiate(bulletBill, new Vector3(-7.2f - i * 1.3f, 0.7f, 93.44f), bulletBill.transform.rotation);
                    obj[i].transform.localScale += new Vector3(0.04f, 0.04f, 0.04f);
                    obj[i].transform.Rotate(0, 90, 0);
                }
                else
                {

                    obj[i] = (GameObject)Instantiate(bulletBill, new Vector3(7.2f + (i - 1) * 1.3f, 0.7f, 93.44f), bulletBill.transform.rotation);
                    obj[i].transform.localScale += new Vector3(0.04f, 0.04f, 0.04f);
                    obj[i].transform.Rotate(0, 90, 0);
                }
                obj[i].transform.parent = transform;
                //transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL5") { }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
