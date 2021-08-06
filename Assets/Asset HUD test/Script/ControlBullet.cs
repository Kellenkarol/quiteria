using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidade;
    public int damage;

    //public ControlCube player;
    // Start is called before the first frame update
    void Awake(){

        rb = GetComponent<Rigidbody2D>();
        //player = GameObject.Find("ControlCube").GetComponent<ControlCube>();
        
        
    }

    void Start()
    {
        
   
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
	{
		rb.velocity = new Vector2(-velocidade, 0);
	}

    public void OnCollisionEnter2D(Collision2D other){
		
		if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
            ControlCube.instance.TakeDamage(damage);
            
        }
        if(other.gameObject.tag == "Finish"){
            Debug.Log("Destroyed");
            Destroy(gameObject);

        }
    }
}
