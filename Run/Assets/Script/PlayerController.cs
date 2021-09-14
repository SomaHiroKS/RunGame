using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float move_speed;

    // Start is called before the first frame update
    void Start()
    {
        move_speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            this.transform.position += new Vector3(0, 0, move_speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            this.transform.position += new Vector3(0, 0, -move_speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            this.transform.position += new Vector3(-move_speed, 0, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            this.transform.position += new Vector3(move_speed, 0, 0f);
        }
    }
    }
