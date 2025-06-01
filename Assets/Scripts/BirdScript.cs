using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Creating Reference to the Rigidbody2D Component (Slot to store the Rigidbody2D Component from inspector to slot)
    public Rigidbody2D rb;
    public LogicScript logicScript;
    public bool isDead = false;

    // Creating a variable to store the jump force with a default value of 5
    public float jumpForce = 12;

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Checking if the Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space) == true && isDead == false)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        if (this.transform.position.y < -17)
        {
            logicScript.gameOver();
            isDead = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isDead = true;
    }
}
