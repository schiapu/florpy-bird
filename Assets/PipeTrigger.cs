using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    public LogicController logic;
    public BirdController bird;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicController>();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer== 3 && bird.isAlive)
        {
            logic.AddScore(1);
        }
        
    }
}
