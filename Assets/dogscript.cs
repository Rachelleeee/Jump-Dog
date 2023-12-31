using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogscript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public LogicScript logic;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && alive){
        myRigidbody.velocity = Vector2.up *jumpStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        alive = false;
    }
}
