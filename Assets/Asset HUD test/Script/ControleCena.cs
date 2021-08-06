using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControleCena : MonoBehaviour
{
    public static ControleCena instance;
    public GameObject inimigo;
    public List<GameObject> listaInimigo;
    public float tempoSpawnInimigo;
    public Transform[] PontosdeSpawn;

    private void Awake(){
        instance = this;
    }

    void Start(){
        InvokeRepeating("StartSpawnInimigo", tempoSpawnInimigo, tempoSpawnInimigo);
        
    }

    void Update(){

        
    }

    void StartSpawnInimigo(){

        int PontosSpawnIndex = Random.Range(0, PontosdeSpawn.Length);
        GameObject tempInimigo = Instantiate(inimigo, PontosdeSpawn[PontosSpawnIndex].position, PontosdeSpawn[PontosSpawnIndex].rotation);
        listaInimigo.Add(tempInimigo);
    }
   
}
