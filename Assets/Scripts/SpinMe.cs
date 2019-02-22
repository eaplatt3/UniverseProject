using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMe : MonoBehaviour
    {

    public int spd = 10;

    public Transform trgt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(trgt.transform.position, trgt.transform.up, spd*Time.deltaTime);   
    }
}
