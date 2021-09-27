using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_trap : MonoBehaviour
{
    private float z;
    public float velocidade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationTrap();
    }
    private void rotationTrap()
    {
        z=z+Time.deltaTime*velocidade;
        transform.rotation=Quaternion.Euler(0, 0, z);
    }
}
