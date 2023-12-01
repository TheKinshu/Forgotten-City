using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scavenger : MonoBehaviour
{
    [SerializeField] private treasure[] items;
    [SerializeField] private bool complete;
    [SerializeField] private int counter;
    [SerializeField] private GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        counter = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!complete)
        {
            counter = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].getCollected())
                {
                    items[i].GetComponent<Renderer>().enabled = false;
                    counter++;
                }
            }
            if (counter == items.Length)
            {
                complete = true;
                openDoor();
            }

        }
    }
    private void openDoor()
    {
        Time.timeScale = 0;
        door.SetActive(true);
    }

    public string getTotalItems() 
    {
        return items.Length.ToString();
    }

    public string getCounter()
    {
        return counter.ToString();
    }
}
