using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morrer : MonoBehaviour
{

    public GameObject gameOver;
  
    public GameObject deletar;

    void Start()
    {
       // gameOver = GetComponent<GameObject>();
    }

    void Update()
    {
        if (Input.GetKeyDown("r")) //vai para a aba menu
        { 
        SceneManager.LoadScene("menu");
        } 
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 15)
        {
            gameOver.SetActive(true); //"ativa" o canvas
            Destroy(this.deletar);
        }
    }
 
}
