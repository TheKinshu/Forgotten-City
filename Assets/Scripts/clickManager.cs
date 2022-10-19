using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickManager : MonoBehaviour
{
    [SerializeField] private Camera cam;

    public clickManager()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if(hit)
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                clickable?.click();
            }
        }   
    }
}
