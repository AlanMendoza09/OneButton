using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM: MonoBehaviour
{

    private UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision) { 
        if (collision.gameObject.tag == "Player")
            {
            uiManager.WinScreen();
            Time.timeScale = 0;
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            uiManager.LoseScreen();
            Time.timeScale = 0;
        }
    }
}
