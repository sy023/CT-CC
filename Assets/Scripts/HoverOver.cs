using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour
{
    public GameObject HoverPanel;
    public void Start()
    {
        HoverPanel.SetActive(false);
    }

    public void OnMouseOver()
    {
        HoverPanel.SetActive(true);

    }
    public void OnMouseExit()
    {
        HoverPanel.SetActive(false);

    }
}
