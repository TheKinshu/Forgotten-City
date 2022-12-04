using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophies : MonoBehaviour
{
    // Start is called before the first frame update
    private bool achieved;
    private Animator trophieAnimation;

    void Start()
    {
        trophieAnimation = GetComponent<Animator>();
        achieved = false;
        setAchieved(achieved);
    }

    // Update is called once per frame
    public void setAchieved(bool ach)
    {
        trophieAnimation.SetBool("achieve", ach);
    }
}
