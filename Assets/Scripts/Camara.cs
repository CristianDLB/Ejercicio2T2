using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform megaman;
    void Start()
    {
        
    }
    void Update()
    {
        var x = megaman.position.x + 4f;
        var y = megaman.position.y;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
