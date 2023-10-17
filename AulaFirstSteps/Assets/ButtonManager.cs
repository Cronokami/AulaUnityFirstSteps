using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public string CenaJogo1;
    public void Jogar()
    {
        SceneManager.LoadScene(CenaJogo1);
    }
}
