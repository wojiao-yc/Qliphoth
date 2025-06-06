using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMagic : MonoBehaviour
{
    private MagicBehaviour eca;
    void Start()
    {
        eca = GetComponentInParent<MagicBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eca.SetInRange();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            eca.NotInRange();
        }
    }
}
