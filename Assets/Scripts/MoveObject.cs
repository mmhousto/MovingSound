using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public int objectSpeed;
    public Vector3 direction; //camelCase
    public bool goingRight = false;
    public float bounds = 30;

    private int health = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("I AM CALLED ON START!", gameObject);
        goingRight = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        // Moves object in a direction
        transform.Translate(direction * objectSpeed * Time.deltaTime); // Frame independent

        // Rotates object on an axis
        transform.Rotate(Vector3.up, 50 * Time.deltaTime);

        if(transform.position.x >= bounds && goingRight)
        {
            goingRight = false;
            objectSpeed = -objectSpeed;
        }
        else if(transform.position.x <= -bounds && goingRight == false)
        {
            goingRight = true;
            objectSpeed = -objectSpeed;
        }
    }

    void MyMethod()
    {

    }
}
