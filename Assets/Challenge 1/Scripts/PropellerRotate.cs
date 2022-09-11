using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{

    private Vector3 propellerRotate = new Vector3 (0, 0, 5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make propeller Rotate along Z axis only
        transform.Rotate(propellerRotate);
    }
}
