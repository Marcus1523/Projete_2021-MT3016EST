using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodMaoMenu : MonoBehaviour
{

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

        //dentro da Scene instruções:
         if(Input.GetKeyDown("b")) //botão voltar
        {
            SceneManager.LoadScene("menu");
        }

        //dentro da Scene instruções:
         if(Input.GetKeyDown("b")) //botão voltar
        {
            SceneManager.LoadScene("menu");
        }

    
    }
}
