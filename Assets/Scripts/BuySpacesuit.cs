using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuySpacesuit : MonoBehaviour
{

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI suitText;
    // Start is called before the first frame update
    public void purcahse()
    {
        if (CharacterStore.spacesuitCount == 1)
        {
            if (!CharacterStore.blueSuit)
            {
                if (CharacterStore.totalCoins >= 5)
                {
                    CharacterStore.blueSuit = true;
                    CharacterStore.totalCoins -= 5;
                    coinsText.text = "Coins: " + CharacterStore.totalCoins;
                    suitText.text = "Owned";
                    CharacterStore.goodSuit = true;

                }
            }
        }
         else if (CharacterStore.spacesuitCount == 2)
        {
            if (!CharacterStore.greenSuit)
            {
                if (CharacterStore.totalCoins >= 5)
                {
                    CharacterStore.greenSuit = true;
                    CharacterStore.totalCoins -= 5;
                    coinsText.text = "Coins: " + CharacterStore.totalCoins;
                    suitText.text = "Owned";
                    CharacterStore.goodSuit = true;

                }
            }
        }
        else if (CharacterStore.spacesuitCount == 3)
        {
            if (!CharacterStore.purpleSuit)
            {
                if (CharacterStore.totalCoins >= 5)
                {
                    CharacterStore.purpleSuit = true;
                    CharacterStore.totalCoins -= 5;
                    coinsText.text = "Coins: " + CharacterStore.totalCoins;
                    suitText.text = "Owned";
                    CharacterStore.goodSuit = true;

                }
            }
        }
       
    }
}
