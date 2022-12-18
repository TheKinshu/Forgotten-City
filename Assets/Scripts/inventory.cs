using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class inventory : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private trophies slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9, slot10, slot11, slot12, slot13, slot14, slot15, slot16;
    private Dictionary<int, trophies> inventorySlots = new Dictionary<int, trophies>();

    private Scene currentScene;

    [SerializeField] private TextMeshProUGUI stageName;
    void Start()
    {
        defaultLoadInventory();
    }


    private void Update()
    {
        if (stageName.text != currentScene.name)
        {
            currentScene = SceneManager.GetActiveScene();
            stageName.text = currentScene.name;
        }

    }


    public void checkthis(trophies t)
    {
        Debug.Log(t == slot1);
    }



    // Update is called once per frame
    private void defaultLoadInventory()
    {
        currentScene = SceneManager.GetActiveScene();
        stageName.text = currentScene.name;
        inventorySlots.Add(1, slot1);
        inventorySlots.Add(2, slot2);
        inventorySlots.Add(3, slot3);
        inventorySlots.Add(4, slot4);
        inventorySlots.Add(5, slot5);
        inventorySlots.Add(6, slot6);
        inventorySlots.Add(7, slot7);
        inventorySlots.Add(8, slot8);
        inventorySlots.Add(9, slot9);
        inventorySlots.Add(10, slot10);
        inventorySlots.Add(11, slot11);
        inventorySlots.Add(12, slot12);
        inventorySlots.Add(13, slot13);
        inventorySlots.Add(14, slot14);
        inventorySlots.Add(15, slot15);
        inventorySlots.Add(16, slot16);
        for (int i = 1; i < inventorySlots.Count + 1; i++)
        {
            inventorySlots[i].setSlot(i);
        }
    }
}
