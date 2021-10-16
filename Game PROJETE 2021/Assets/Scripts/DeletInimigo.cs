using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletInimigo : MonoBehaviour
{

   public GameObject deletar;

  //  public GameObject tiro;

  private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

     private void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.gameObject.layer == 16)
        {
             Debug.Log("colidindo");
            Destroy(this.deletar);
        }
    }
 
    private void OnParticleCollision(GameObject other){
        if(other.gameObject.layer == 16)
        {
          Debug.Log("colidindo");
            Destroy(gameObject);
        }
    }

}
