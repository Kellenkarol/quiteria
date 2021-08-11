using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    public GameObject lista;

    public void AbrirLista()
    {
        lista.SetActive(true);
    }

    public void FecharLista()
    {
        lista.SetActive(false);
    }
}
