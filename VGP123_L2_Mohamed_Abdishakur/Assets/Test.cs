using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Entered: " + collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision Exited: " + collision.gameObject.name);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision Stayed: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collision2D collision)
    {
        Debug.Log("Trigger Entered: " + collision.gameObject.name);
    }

    private void OnTriggerExit2D(Collision2D collision)
    {
        Debug.Log("Trigger Exited: " + collision.gameObject.name);
    }

    private void OnTriggerStay2D(Collision2D collision)
    {
        Debug.Log("Trigger Stayed: " + collision.gameObject.name);
    }

}
