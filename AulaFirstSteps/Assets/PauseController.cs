using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AtivaPausa();
        }
    }

    public void AtivaPausa()
    {
        if (PauseMenu.activeSelf)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
