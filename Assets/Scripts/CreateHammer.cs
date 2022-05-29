using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHammer : MonoBehaviour
{
    public GameObject hammer;
    public float speed;
    public float timeBetweenThrows;
    public AudioClip throwSound;

    float timeToNextThrow = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeToNextThrow -= Time.deltaTime;
        if (timeToNextThrow <= 0.0f)
        {
            timeToNextThrow = timeBetweenThrows;
            GameObject obj = Instantiate(hammer, transform.position + new Vector3(0.0f, 0.25f, -0.25f), transform.rotation);
            //obj.transform.localScale -= new Vector3(0.8f, 10.0f, 0.8f);
            obj.transform.Rotate(0, 90, 0);
            Quaternion rot = transform.rotation;
            Debug.Log(rot);
            if (rot[3] > 0)
            {
                obj.GetComponent<Rigidbody>().velocity = new Vector3(speed, speed * 2.0f, 0.0f);
            }
            else if (rot[3] < 0)
            {
                obj.GetComponent<Rigidbody>().velocity = new Vector3(-speed, speed * 2.0f, 0.0f);
            }

            //AudioSource.PlayClipAtPoint(throwSound, transform.position);
        }
    }
}
