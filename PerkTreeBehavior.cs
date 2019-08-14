using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkTreeBehavior : MonoBehaviour
{
    private bool perkTreeBool = false;
    public int perkPoints;
    public GameObject perkTreeOBJ;
    public PerkBehavior plusHp, plusMana, plusSpeed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PerkTree();
        }

        if (perkTreeBool)
        {
            perkTreeOBJ.SetActive(true);
        }
        else { perkTreeOBJ.SetActive(false); }
    }

    public void PerkTree()
    {
        perkTreeBool = !perkTreeBool;
    }
}
