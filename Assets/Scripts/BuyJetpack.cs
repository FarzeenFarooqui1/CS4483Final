using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyJetpack : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI jetPackText;
    // Start is called before the first frame update
    public void purcahse()
    {
        if (CharacterStore.jetpackCount == 1)
        {
            if (!CharacterStore.greenJetpack)
            {
                if (CharacterStore.totalCoins >= 5)
                {
                    CharacterStore.greenJetpack = true;
                    CharacterStore.totalCoins -= 5;
                    coinsText.text = "Coins: " + CharacterStore.totalCoins;
                    jetPackText.text = "Owned";
                    CharacterStore.goodPack = true;

                }
            }
        }
        else if (CharacterStore.jetpackCount == 2)
        {
            if (!CharacterStore.purpleJetpack)
            {
                if (CharacterStore.totalCoins >= 5)
                {
                    CharacterStore.purpleJetpack = true;
                    CharacterStore.totalCoins -= 5;
                    coinsText.text = "Coins: " + CharacterStore.totalCoins;
                    jetPackText.text = "Owned";
                    CharacterStore.goodPack = true;

                }
            }
        }
    }
}
