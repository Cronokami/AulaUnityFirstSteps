using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlavancaAction : MonoBehaviour
{
    public GameObject porta;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(porta);
    }
}
