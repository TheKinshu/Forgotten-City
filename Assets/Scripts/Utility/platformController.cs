using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    private int currentIndex = 0;
    [SerializeField] private int waitTime = 0;

    [SerializeField] private float speed = 10f;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(delay());
    }
    
    private IEnumerator delay()
    {
        while (true)
        {
            if (Vector2.Distance(waypoints[currentIndex].transform.position, transform.position) < .1f)
            {   
                currentIndex++;
                // check if index is out of bound
                if (currentIndex >= waypoints.Length)
                    currentIndex = 0;
                yield return new WaitForSeconds(waitTime);

            }
            else {
                yield return new WaitForSeconds(0);
            }
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentIndex].transform.position, Time.deltaTime * speed);

            
        }


    }
}
