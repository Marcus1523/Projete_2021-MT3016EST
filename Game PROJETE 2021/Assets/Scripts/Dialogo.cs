using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    public Sprite profile;
    public string[] speechText;
    public string actorName;

    public LayerMask playerLayer;
    public float radious;

    private dialogoControle dc;

    private GameObject ballon = null;

    bool onRadius;

    //---------------------------------

    private void Start()
    {
        dc = FindObjectOfType<dialogoControle>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onRadius)
        {
            dc.Speech(profile, speechText, actorName);
            
        }
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);
        if (hit != null)
        {
            onRadius = true;
            if (ballon == null)
            {
                ballon = dc.GetFloatingBalloon();
                ballon.transform.SetParent(this.transform);
            }
        }
        else
        {
            if (ballon) {
                Destroy(ballon);
            }
            onRadius = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radious);
    }

}



