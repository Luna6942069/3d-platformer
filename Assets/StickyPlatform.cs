using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cunt")
        {
            collision,gameObject.transform.SetParent(transform);
        }
    }

}
