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
    private bool isMoving;
    private Vector3 hold;
    // Start is called before the first frame update
    void Start()
    {
        this.rb.position = hold;
        print(MasterData.whereDidIComeFrom);
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
        this.isMoving = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Exit"))
        {
            if (other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
                hold = -1 * (GameObject.FindGameObjectWithTag("Exit").transform.position);
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
                hold = -1 * (GameObject.FindGameObjectWithTag("Exit").transform.position);
            }
            else if (other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
                hold = -1 * (GameObject.FindGameObjectWithTag("Exit").transform.position);
            }
            else if (other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
                hold = -1 * (GameObject.FindGameObjectWithTag("Exit").transform.position);
            }
            print("I hit an exit");

            SceneManager.LoadScene("DungeonRoom");
            
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !isMoving)
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
            this.isMoving = true;

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && !isMoving)
            {

                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
                this.isMoving = true;
                

            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && !isMoving)
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            this.isMoving = true;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && !isMoving)
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            this.isMoving = true;

        }
    }

    

    
}
