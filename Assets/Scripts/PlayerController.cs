using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 20;
    void Update()
    {
        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
