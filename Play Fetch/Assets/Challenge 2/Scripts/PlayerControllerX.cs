using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDelay = 0;

    // Update is called once per frame
    void Update()
    {
      //  fireDelay -= 0.1f;
        // On spacebar press, send dog
        if (!Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        fireDelay = 1; 
        }
       // Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
       if (fireDelay >= 0) {
        fireDelay -= Time.deltaTime;
       }
       // fireDelay = 10.0f;
    }
}

