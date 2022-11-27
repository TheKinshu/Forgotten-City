using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private trophies slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12, slot13, slot14, slot15, slot16;
    private Dictionary<trophies, bool> inventorySlots = new Dictionary<trophies, bool>();

    void Start()
    {
        inventorySlots.Add(slot1, false);
        inventorySlots.Add(slot2, false);
        inventorySlots.Add(slot3, false);
        inventorySlots.Add(slot4, false);
        inventorySlots.Add(slot5, false);
        inventorySlots.Add(slot6, false);
        inventorySlots.Add(slot7, false);
        inventorySlots.Add(slot8, false);
        inventorySlots.Add(slot9, false);
        inventorySlots.Add(slot10, false);
        inventorySlots.Add(slot11, false);
        inventorySlots.Add(slot12, false);
        inventorySlots.Add(slot13, false);
        inventorySlots.Add(slot14, false);
        inventorySlots.Add(slot15, false);
        inventorySlots.Add(slot16, false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
