using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletDialogo : MonoBehaviour
{

     public GameObject dialogueObj;
     public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e")) //botão jogar
        {
            gameOver.SetActive(false); //"ativa" o canvas
        }
    }
}
