using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
                MasterData.count++;
                SceneManager.LoadScene("DungeonRoom");

            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
        }
    }

    

    
}
