using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float bufferLength = 1.0f;
    private float buffer;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > buffer)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            buffer = Time.time + bufferLength; // Buffer is equal to the current time plus 1 second, meaning the player can send a dog again after the current time has passed the buffer
        }
    }
}
