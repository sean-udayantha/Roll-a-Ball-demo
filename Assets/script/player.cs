using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem;
public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=0;
    private Rigidbody rb;
    // private float movementX;
    // private float movementY;
    void Start()
    {
        rb=GetComponent<Rigidbody> ();
    }
//   private void OnMove(InputValue movementValue)
//     {
//         Vector2 movementVector = movementValue.Get<Vector2>();

//         movementX = movementVector.x;
//         movementY = movementVector.y;
//     }
    // Update is called once per frame
      void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
             GetComponent<Rigidbody>().AddForce(Vector3.up *10,ForceMode.VelocityChange);
             Debug.Log("pass space");
        }

       
    }
    
    void FixedUpdate()
    {

        float moveHorizontal =Input.GetAxis("Horizontal");
        float moveVertical =Input.GetAxis("Vertical");
        

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);
    }
}
