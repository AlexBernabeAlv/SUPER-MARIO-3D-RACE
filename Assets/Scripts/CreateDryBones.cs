using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateDryBones : MonoBehaviour
{

    public GameObject dryBones;
    public float runSpeed = 2f;
    public float turnSpeed = 90f;
    GameObject[] obj;
    bool changeDirection = false;
    int[] direction;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "LEVEL4")
        {
            obj = new GameObject[2];
            direction = new int[2];
            for (int i = 0; i < 2; ++i)
            {
                obj[i] = (GameObject)Instantiate(dryBones, new Vector3(-3.0f + 6f * i, -0.5f, 14f), dryBones.transform.rotation);
                obj[i].transform.Rotate(0, 180, 0);
                obj[i].transform.parent = transform;
                transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL1")
        {
            obj = new GameObject[4];
            direction = new int[4];
            for (int i = 0; i < 4; ++i)
            {
                if (i % 2 == 0)
                {
                    obj[i] = (GameObject)Instantiate(dryBones, new Vector3(-3.0f + i, -0.5f, 60.0f - i * 5), dryBones.transform.rotation);
                    obj[i].transform.Rotate(0, -90, 0);
                }
                else
                {
                    obj[i] = (GameObject)Instantiate(dryBones, new Vector3(3.0f - (i - 1), -0.5f, 60.0f - (i - 1) * 5), dryBones.transform.rotation);
                    obj[i].transform.Rotate(0, 90, 0);
                }
                obj[i].transform.parent = transform;
                transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            }
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL5")
        {
            //obj = new GameObject[4];
            //direction = new int[4];
            //for (int i = 0; i < 4; ++i)
            //{
            //    if (i % 2 == 0)
            //    {
            //        obj[i] = (GameObject)Instantiate(dryBones, new Vector3(-3.6f, -2f, 42f + i * 5), dryBones.transform.rotation);
            //        obj[i].transform.Rotate(0, -90, 0);
            //    }
            //    else
            //    {

            //        obj[i] = (GameObject)Instantiate(dryBones, new Vector3(3.6f, -2f, 42f + (i - 1) * 5), dryBones.transform.rotation);
            //        obj[i].transform.Rotate(0, 90, 0);
            //    }
            //    obj[i].transform.parent = transform;
            //    transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            //}
        }
        else if (SceneManager.GetActiveScene().name == "LEVEL2") { }
        else if (SceneManager.GetActiveScene().name == "LEVEL3")
        {
            obj = new GameObject[4];
            direction = new int[4];
            for (int i = 0; i < 4; ++i)
            {
                if (i % 2 == 0)
                {
                    obj[i] = (GameObject)Instantiate(dryBones, new Vector3(-8.0f, 0.7f + i * 0.55f, 85.0f + i * 4.0f), dryBones.transform.rotation);
                    obj[i].transform.Rotate(0, 90, 0);
                }
                else
                {
                    obj[i] = (GameObject)Instantiate(dryBones, new Vector3(8.0f, 0.7f + (i - 1) * 0.55f, 85.0f + (i - 1) * 4.0f), dryBones.transform.rotation);
                    obj[i].transform.Rotate(0, -90, 0);
                }
                obj[i].transform.parent = transform;
                transform.GetChild(i).gameObject.GetComponent<Animator>().SetBool("IsRunning", true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "LEVEL4")
        {
            for (int i = 0; i < obj.Length; ++i)
            {
                if (changeDirection)
                {
                    if (i % 2 == 0)
                    {
                        if (direction[i] == 0)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y <= 270)
                            {
                                obj[i].transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else if (direction[i] == 1)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y > 270)
                            {
                                obj[i].transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else if (direction[i] == 2)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y <= 90)
                            {
                                obj[i].transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else if (direction[i] == 3)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y <= 180)
                            {
                                obj[i].transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else direction[i] = 0;
                    }
                    else
                    {
                        if (direction[i] == 0)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y >= 90)
                            {
                                obj[i].transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else if (direction[i] == 1)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y < 90)
                            {
                                obj[i].transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else if (direction[i] == 2)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y >= 270)
                            {
                                obj[i].transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else if (direction[i] == 3)
                        {
                            if (obj[i].transform.rotation.eulerAngles.y >= 180)
                            {
                                obj[i].transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
                            }
                            else
                            {
                                changeDirection = false;
                                direction[i]++;
                            }
                        }
                        else direction[i] = 0;
                    }
                }
                else
                {
                    if (direction[i] == 0)
                    {
                        if (obj[i].transform.position.z > 9) obj[i].transform.Translate(-transform.forward * runSpeed * Time.deltaTime, Space.World);
                        else changeDirection = true;
                    }
                    else if (direction[i] == 1)
                    {
                        if (i % 2 == 0)
                        {
                            if (obj[i].transform.position.x > -8) obj[i].transform.Translate(-transform.right * runSpeed * Time.deltaTime, Space.World);
                            else changeDirection = true;
                        }
                        else
                        {
                            if (obj[i].transform.position.x < 8) obj[i].transform.Translate(transform.right * runSpeed * Time.deltaTime, Space.World);
                            else changeDirection = true;
                        }
                    }
                    else if (direction[i] == 2)
                    {
                        if (obj[i].transform.position.z < 14) obj[i].transform.Translate(transform.forward * runSpeed * Time.deltaTime, Space.World);
                        else changeDirection = true;
                    }
                    else if (direction[i] == 3)
                    {
                        if (i % 2 == 0)
                        {
                            if (obj[i].transform.position.x < -3) obj[i].transform.Translate(transform.right * runSpeed * Time.deltaTime, Space.World);
                            else changeDirection = true;
                        }
                        else
                        {
                            if (obj[i].transform.position.x > 3) obj[i].transform.Translate(-transform.right * runSpeed * Time.deltaTime, Space.World);
                            else changeDirection = true;
                        }
                    }
                    else direction[i] = 0;
                }
            }
        }
    }
}
