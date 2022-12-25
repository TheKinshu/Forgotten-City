using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophies : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool achieved = false;
    [SerializeField] private int slotNum;
    private Animator trophieAnimation;

    void Start()
    {
        trophieAnimation = GetComponent<Animator>();

        setAchieved(achieved);
    }

    private void Update()
    {
        trophieAnimation.SetBool("achieve", achieved);
    }

    // Update is called once per frame
    public void setAchieved(bool ach)
    {
        achieved = ach;
    }

    public void setSlot(int num)
    {
        slotNum = num;
    }

    public bool getAchieved()
    {
        return achieved;
    }
}
