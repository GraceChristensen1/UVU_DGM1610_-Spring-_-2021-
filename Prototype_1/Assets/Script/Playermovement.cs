using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
  //Access Modifier, Data Type, Name
  public float speed = 30.0f;
  public float turnspeed =35.0f;
  
  public float hInput;
  public float fInput;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    // Gathers the inputs for the controls
      hInput = Input.GetAxis("Horizontal");
      fInput = Input.GetAxis("Vertical");
    // Makes the vehicle go forward and back
      transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
    // Makes the vehicle go left and right
      transform.Rotate(Vector3.up,turnspeed * hInput * Time.deltaTime);

    }
}
