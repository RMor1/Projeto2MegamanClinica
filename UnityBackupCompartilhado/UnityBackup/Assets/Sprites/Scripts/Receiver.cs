using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public int lives = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.CompareTag("Explosion"))
        {
            lives--;
        }
        if (lives <= 0) Destroy(gameObject);

    }
}
