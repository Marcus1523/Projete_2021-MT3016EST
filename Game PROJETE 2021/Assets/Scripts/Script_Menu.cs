using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //biblioteca para trocar de cena

public class Script_Menu : MonoBehaviour
{
    public string nomeDaCena1; //variavel para trocar de cena
   
    void Start() //só faz uma vez
    {
        
    }

    void Update() //faz mais de uma vez
    {
        
    }
    public void troca() //troca
    {
        SceneManager.LoadScene(nomeDaCena1); //linha de cod para trocar de cena
    }
 

}
