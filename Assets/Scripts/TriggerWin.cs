using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    [SerializeField] private GameObject trigger;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0;
        trigger.SetActive(true);
        Destroy(gameObject);
    }
}
