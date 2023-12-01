using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wireManager : MonoBehaviour
{
    [SerializeField] private Button wire1, wire2, wire3, wire4, wire5, wire6;
    [SerializeField] private string wire1Safety;
    [SerializeField] private string wire2Safety;
    [SerializeField] private string wire3Safety;
    [SerializeField] private string wire4Safety;
    [SerializeField] private string wire5Safety;
    [SerializeField] private string wire6Safety;
    [SerializeField] private int numWires;
    [SerializeField] private GameObject game, triggerObject, winPanel;
    private Dictionary<Button, string> wireStates = new Dictionary<Button, string>();
    private void Start()
    {
        wireStates.Add(wire1, wire1Safety);
        wireStates.Add(wire2, wire2Safety);
        wireStates.Add(wire3, wire3Safety);
        wireStates.Add(wire4, wire4Safety);
        wireStates.Add(wire5, wire5Safety);
        wireStates.Add(wire6, wire6Safety);
    }

    private void Awake()
    {
        wire1.onClick.AddListener(delegate { changeState(wire1); });
        wire2.onClick.AddListener(delegate { changeState(wire2); });
        wire3.onClick.AddListener(delegate { changeState(wire3); });
        wire4.onClick.AddListener(delegate { changeState(wire4); });
        wire5.onClick.AddListener(delegate { changeState(wire5); });
        wire6.onClick.AddListener(delegate { changeState(wire6); });
    }

    private void changeState(Button test)
    {

        if (wireStates[test] == "boom")
        {
            Debug.Log("boom frogs");
            game.SetActive(false);
            Time.timeScale = 1;
        }
        else if (wireStates[test] == "safe")
        {
            test.interactable = false;
            numWires -= 1;
            if (numWires == 0)
            {
                game.SetActive(false);
                winPanel.SetActive(true);

                Destroy(triggerObject);
            }
        }
    }
}
