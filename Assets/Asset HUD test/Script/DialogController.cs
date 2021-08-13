using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.U2D;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class DialogController : MonoBehaviour
{
    public static DialogController instance;
    public TMP_Text nome;
    public TMP_Text texto;
    public Image imagem;
    private Sprite sprite;

    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }    
    }


    void Start()
    {
        imagem = GetComponent<Image>();
        nome.text = "Chupetinha";
        texto.text = "Chupetilson está doente foi pra casa ficar de home office, lalala. Take the Egg Masturbation";
        
        sprite = Resources.Load<Sprite>("jooj");

        imagem.sprite = sprite;

        // imagem.overrideSprite = sprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MakeDialog(int dialogID)
    {
        
    }
    
}
