using UnityEngine;
using UnityEngine.UI;

public class KillogSetup : MonoBehaviour
{
    public GameObject AssaultRifleImage;
    public GameObject ShotgunImage;

    public Text EnnemyText;

    public void Setup(string ID, int weaponID)
    {
        if(weaponID == 0)
        {
            AssaultRifleImage.SetActive(true);
            ShotgunImage.SetActive(false);
        }
        else if (weaponID == 1)
        {
            ShotgunImage.SetActive(true);
            AssaultRifleImage.SetActive(false);
        }
        if(ID == "cube")
        {
            EnnemyText.text = "Cube";
            EnnemyText.color = Color.cyan;
        }
        else if(ID == "cube_boss")
        {
            EnnemyText.text = "RED CUBE";
            EnnemyText.color = Color.red;
        }
    }
}
