using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScavengerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private GameObject scavEvent;
    private string totalItems;
    private string count;
    // Start is called before the first frame update
    void Start()
    {
        this.totalItems = scavEvent.GetComponent<Scavenger>().getTotalItems();
        this.count = "0";
        this.counter.text = count + "/" + totalItems;
    }

    // Update is called once per frame
    void Update()
    {
        this.counter.text = scavEvent.GetComponent<Scavenger>().getCounter() + "/" + totalItems;
    }
}
