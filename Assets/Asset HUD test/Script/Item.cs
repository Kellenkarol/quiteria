using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int id, indice;
    public TextMesh nome;
    public TextMesh qtd;
    public GameObject objeto;
    public bool destroy;
    public Texture2D imagem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //nome = objeto.transform.nome;
    }
}
