using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodMaoMenu : MonoBehaviour
{


      public GameObject gameOver;

    void Update()
    {

        //----------area de este das letras--------
        /*
        *
        *
        *
        */
        //--------------Scene menu-----------------
  
        if(Input.GetKeyDown("c")) //botão jogar
        {
            SceneManager.LoadScene("game1");
        }

        if(Input.GetKeyDown("x")) //botão instruções
        {
            SceneManager.LoadScene("instruções");
        }

        if(Input.GetKeyDown("z")) //botão Saiba Mais
        {
            SceneManager.LoadScene("saiba mais");
        }


        //dentro da Scene instruções e Saiba Mais
         if(Input.GetKeyDown("b")) 
        {
            SceneManager.LoadScene("menu");
        }

        //dotão reset gamever
         if(Input.GetKeyDown("p")) 
        {
            SceneManager.LoadScene("menu");
        }
          if(Input.GetKeyDown("r")) 
        {
            SceneManager.LoadScene("menu");
        }

        if(Input.GetKeyDown("e")) //
        {
            gameOver.SetActive(false);
        }



    
    }
}
