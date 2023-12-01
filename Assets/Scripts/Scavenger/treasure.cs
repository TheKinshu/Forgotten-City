using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasure : MonoBehaviour
{
    [SerializeField] private bool collected;
    [SerializeField] private bool inCollider;
    void Start()
    {
        collected = false;
        inCollider = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inCollider)
        { collected = true; }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            inCollider = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            inCollider = false;
    }

    public bool getCollected()
    {
        return collected;
    }
    public void remove()
    {
        Object.Destroy(this);
    }

}
