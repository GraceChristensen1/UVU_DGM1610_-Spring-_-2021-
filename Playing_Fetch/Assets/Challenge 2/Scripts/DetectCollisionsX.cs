using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //destroy ball when in contact with other ie. dog
        Destroy(gameObject);
    }
}
