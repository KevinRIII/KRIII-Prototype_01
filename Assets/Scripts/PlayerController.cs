using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // decleration of Player Reference
    

    // decleration of player's Speed Variable
    public float Speed = 15.0f;

    // Update is called once per frame
    void Update()
    {
        // allows player to move
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
