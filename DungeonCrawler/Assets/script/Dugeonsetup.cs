

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dugeonsetup : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject westExit;
    public GameObject eastExit;

    public bool northOn;
    public bool southOn;
    public bool eastOn;
    public bool westOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (northOn == false) {
            this.northExit.SetActive(false);
        }
    }
}
