using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeJetpack : MonoBehaviour
{
    public Image character;
    public Sprite redWhite;
    public Sprite redGreen;
    public Sprite redPurple;
    public Sprite blueWhite;
    public Sprite blueGreen;
    public Sprite bluePurple;
    public Sprite greenWhite;
    public Sprite greenGreen;
    public Sprite greenPurple;
    public Sprite purpleWhite;
    public Sprite purpleGreen;
    public Sprite purplePurple;
    public CharacterStore charactervars;
    public TextMeshProUGUI purchase;
    public void ChangeJetpacks()
    {
        if (CharacterStore.jetpackCount < 2)
        {
            CharacterStore.jetpackCount += 1;
        }
        else
        {
            CharacterStore.jetpackCount = 0;
        }





        if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = redWhite;
            if (!CharacterStore.whiteJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }

        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = blueWhite;
            if (!CharacterStore.whiteJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = greenWhite;
            if (!CharacterStore.whiteJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = purpleWhite;
            if (!CharacterStore.whiteJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }



        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = redGreen;
            if (!CharacterStore.greenJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = blueGreen;
            if (!CharacterStore.greenJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = greenGreen;
            if (!CharacterStore.greenJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = purpleGreen;
            if (!CharacterStore.greenJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }


        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = redPurple;
            if (!CharacterStore.purpleJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = bluePurple;
            if (!CharacterStore.purpleJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = greenPurple;
            if (!CharacterStore.purpleJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = purplePurple;
            if (!CharacterStore.purpleJetpack)
            {
                purchase.text = "Purchase Jetpack";
                CharacterStore.goodPack = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodPack = true;
            }
        }
    }
}
