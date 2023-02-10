using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerControls playerControlsScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControlsScript = GameObject.Find("Player").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlsScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    
    }
}
