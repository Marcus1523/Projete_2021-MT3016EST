using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonDialogue : MonoBehaviour
{
    private float horizontalOffset = 0.2f;
    private float verticalOffset = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        // this.transform.lo
        this.transform.localPosition = new Vector3(horizontalOffset, verticalOffset, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
