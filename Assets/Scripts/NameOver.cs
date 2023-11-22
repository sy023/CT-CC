using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameOver : MonoBehaviour
{
    public GameObject NamePanel;
    public void Start()
    {
        NamePanel.SetActive(false);
    }

    public void OnMouseOver()
    {
        NamePanel.SetActive(true);

    }
    public void OnMouseExit()
    {
        NamePanel.SetActive(false);

    }
}
