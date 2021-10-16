using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIRO : MonoBehaviour
{

    public float speed;
    private float timeDestroy;
     private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
         rig = GetComponent<Rigidbody2D>(); 
        timeDestroy = 1.0f; // 1 segundo
        Destroy(gameObject, timeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
}
