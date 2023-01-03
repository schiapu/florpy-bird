using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D myRigidbody;
    [SerializeField]
    private float birdSpeed = 5;
    private bool isAlive = true;

    public LogicController logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicController>();
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        //Input.GetKeyDown(KeyCode.Space)
        if (keyboard.spaceKey.wasPressedThisFrame && isAlive)
        {
            myRigidbody.velocity = Vector3.up * birdSpeed;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logic.GameOver();
    }
}
