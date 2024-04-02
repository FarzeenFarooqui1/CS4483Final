using System.Collections;
using System.Collections.Generic;
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

        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = blueWhite;

        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = greenWhite;
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 0)
        {
            character.sprite = purpleWhite;
        }



        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = redGreen;
        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = blueGreen;
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = greenGreen;
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 1)
        {
            character.sprite = purpleGreen;
        }


        else if (CharacterStore.spacesuitCount == 0 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = redPurple;
        }
        else if (CharacterStore.spacesuitCount == 1 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = bluePurple;
        }
        else if (CharacterStore.spacesuitCount == 2 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = greenPurple;
        }
        else if (CharacterStore.spacesuitCount == 3 && CharacterStore.jetpackCount == 2)
        {
            character.sprite = purplePurple;

        }
    }
}
