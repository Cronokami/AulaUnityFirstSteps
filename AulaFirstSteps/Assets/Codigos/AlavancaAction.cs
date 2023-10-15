using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaAction : MonoBehaviour
{
    public GameObject porta;
    AudioSource somDePorta;
    private void Start()
    {
        somDePorta = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(porta);
        somDePorta.enabled = true;
    }
}
