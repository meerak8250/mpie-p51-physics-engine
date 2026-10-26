using UnityEngine;

public class bowlingBowl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float power = 0f;
    public float turnSpeed = 50f;
    public float rotation = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Get the horizontal input axis (A/D keys or Left/Right arrow keys)
       transform.Translate(Vector3.right*Input.GetAxis("Horizontal")*-5f*Time.deltaTime);

    // W/S keys for power when ball is thrown 
    power += Input.GetAxis("Vertical")*100f*Time.deltaTime;

    if (Input.GetKey (KeyCode.Q))
        {
            rotation = -turnSpeed * Time.deltaTime; 
        }
        else if (Input.GetKey (KeyCode.E))
        {
            rotation = turnSpeed * Time.deltaTime; 
        }
    }
void FixedUpdate()
{
    //   spacebar to throw the ball
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Rigidbody rb = GetComponent<Rigidbody> ();
        
        rb.AddForce (new Vector3(0, 0 , -power));
        rb.AddTorque (new Vector3 (0.0f, 0.0f, rotation));
    }

    }
    
}
