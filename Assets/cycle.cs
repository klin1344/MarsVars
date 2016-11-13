using UnityEngine;
using System.Collections;

public class cycle : MonoBehaviour {


    public Light sun;
   
    void Start()
    {
        
    }

    void Update()
    {
        sun.transform.RotateAround(Vector3.zero, Vector3.right, 5f * Time.deltaTime);
        sun.transform.LookAt(Vector3.zero);
    }

   

}
