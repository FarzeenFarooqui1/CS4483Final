using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeSuit : MonoBehaviour
{
    // Start is called before the first frame update
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
    public void ChangeSpacesuit()
    {
        if (CharacterStore.spacesuitCount < 3 ) 
        {
            CharacterStore.spacesuitCount += 1;
        } else
        {
            CharacterStore.spacesuitCount = 0;
        }





        if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = redWhite;
            if (!CharacterStore.redSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }

        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = blueWhite;

            if (!CharacterStore.blueSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            } else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }
            
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = greenWhite;
            if (!CharacterStore.greenSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }

        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = purpleWhite;
            if (!CharacterStore.purpleSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }

        }



        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = redGreen;
            if (!CharacterStore.redSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }

        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = blueGreen;
            if (!CharacterStore.blueSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = greenGreen;
            if (!CharacterStore.greenSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = purpleGreen;
            if (!CharacterStore.purpleSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }
        }
        
        
        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = redPurple;
            if (!CharacterStore.redSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }

        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = bluePurple;
            if (!CharacterStore.blueSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = greenPurple;
            if (!CharacterStore.greenSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }
        }
        else if (CharacterStore.spacesuitCount ==3 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = purplePurple;
            if (!CharacterStore.purpleSuit)
            {
                purchase.text = "Purchase Suit";
                CharacterStore.goodSuit = false;
            }
            else
            {
                purchase.text = "Owned";
                CharacterStore.goodSuit = true;
            }

        }

    }
}
