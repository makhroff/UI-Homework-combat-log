using UnityEngine;
using UnityEngine.UI;

public class killlogManager : MonoBehaviour
{
    public Image killLogPrefab;
    public GameObject Panel;
    public void InstantiateKillLog(string ID, int weaponID)
    {
        Image killLogPrefabClone = Instantiate(killLogPrefab);

        killLogPrefabClone.GetComponent<KillogSetup>().Setup(ID, weaponID);

        killLogPrefabClone.transform.parent = Panel.transform;
        killLogPrefabClone.GetComponent<RectTransform>().sizeDelta = killLogPrefab.GetComponent<RectTransform>().sizeDelta;
        killLogPrefabClone.GetComponent<RectTransform>().localScale = killLogPrefab.GetComponent<RectTransform>().localScale;
        killLogPrefabClone.GetComponent<RectTransform>().position = killLogPrefab.GetComponent<RectTransform>().position;

        killLogPrefabClone.gameObject.SetActive(true);

        if (ID == "cube")
            Destroy(killLogPrefabClone.gameObject, 5f);     
        else
            Destroy(killLogPrefabClone.gameObject, 15f);
    }
}
