using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int id, indice;
    protected TextMesh nome;
    protected TextMesh qtd;
    public GameObject objeto;
    public bool destroy;
    public Texture2D imagem;

    public Item()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //nome = objeto.transform.nome;
    }
}
