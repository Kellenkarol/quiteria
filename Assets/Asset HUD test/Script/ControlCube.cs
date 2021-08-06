using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCube : MonoBehaviour
{
    public static ControlCube instance;
    private Rigidbody2D rb;
    public Slider healthBar;
    private Vector2 direcao;
    public float velocidade;
    public int health;

    protected JoyButton joybutton;
    protected Joystick joystick;

    // Start is called before the first frame update
    void Awake(){

         if (instance == null)
            instance = this;

        healthBar = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();

    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(joystick.Horizontal * velocidade, joystick.Vertical * velocidade);

        //InputPersonagem();
        //transform.Translate(direcao * velocidade * Time.deltaTime);
        healthBar.value = health;
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Life:" + health);
    }

    // void InputPersonagem()
    // {
    //     direcao = Vector2.zero;

    //     if (Input.GetKey(KeyCode.UpArrow))
    //     {
    //         direcao += Vector2.up;
    //     }
    //     if (Input.GetKey(KeyCode.DownArrow))
    //     {
    //         direcao += Vector2.down;
    //     }
    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         direcao += Vector2.left;
    //     }
    //     if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         direcao += Vector2.right;
    //     }
    // }

    

    
}
