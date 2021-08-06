using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Sprite[] bar;
    public Image healthBarUI;

    private ControlCube player;
    // Start is called before the first frame update
    // void Awake()
    // {
    //     player = GameObject.Find("Player").GetComponent<ControlCube>();
    // }
    
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        player = GameObject.Find("ControlCube").GetComponent<ControlCube>();
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBarUI.sprite = bar[player.health];
        
    }
}
