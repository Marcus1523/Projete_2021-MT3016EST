using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Fundo_infinito : MonoBehaviour
{

    public MeshRenderer mr;
    public float speed; //varial da velocidade do background e float pois podemos colocar numero quebrado
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0); //pega o material/foto do background e define a velocidade 
        // += soma/acrescenta com o anterior
        // deltaTime para que ela n fica ocilando
    }
}
