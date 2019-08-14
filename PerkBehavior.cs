using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Perk
{
    PlusHp,
    PlusMS,
    PlusMana,
}
public class PerkBehavior : MonoBehaviour
{
    public Perk thisPerk = Perk.PlusHp;
    public PerkTreeBehavior tree;
    public bool isEnabled;
    private PerkBehavior requiredPerk;
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
        if (thisPerk.Equals(Perk.PlusMana)) { requiredPerk = tree.plusHp; }
        if (thisPerk.Equals(Perk.PlusMS)) { requiredPerk = tree.plusHp; }
    }

    public void RankUp()
    {
        if (tree.perkPoints > 0)
        {
            if (thisPerk.Equals(Perk.PlusHp))
            {
                tree.perkPoints -= 1;
                isEnabled = true;
                text.text = "Purchased!";
                if (thisPerk.Equals(Perk.PlusHp)) { PlusHitPointsFunction(); }
            }
            else if(requiredPerk.isEnabled == true)
            {
                tree.perkPoints -= 1;
                isEnabled = true;
                text.text = "Purchased!";

                //Enabling perk functions
                if (thisPerk.Equals(Perk.PlusMana)) { PlusManaFunction(); }
                if (thisPerk.Equals(Perk.PlusMS)) { PlusSpeedFunction(); }
            }
        }
    }

    private void PlusHitPointsFunction()
    {
        Debug.Log("Adding hit points!");
    }

    private void PlusSpeedFunction()
    {
        Debug.Log("Adding movement speed!");
    }

    private void PlusManaFunction()
    {
        Debug.Log("Adding mana points!");
    }
}
