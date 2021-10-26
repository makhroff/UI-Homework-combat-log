using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    //SORRY
    //FOR THE
    //HARD CODE

    [SerializeField] private GameObject Controller;
    [SerializeField] private GameObject cam;

    [SerializeField] private GameObject AssaultRifle;
    [SerializeField] private GameObject Shotgun;

    [SerializeField] private GameObject Canvas;

    private bool isActive = true;
    public bool assaultrifleSelected = false;
    public bool shotgunSelected = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Controller.SetActive(false);
            cam.SetActive(true);
            Canvas.SetActive(true);
            isActive = true;
        }
        if (Input.GetKey(KeyCode.Alpha1) && isActive)
            SelectWeapon(0);
        else if (Input.GetKey(KeyCode.Alpha2) && isActive)
            SelectWeapon(1);
    }
    public void SelectWeapon(int index)
    {
        if(index == 0)
        {
            Canvas.SetActive(false);
            cam.SetActive(false);
            Controller.SetActive(true);
            Invoke("IfAssaultRifle", 0.1f); 
        }
        else if(index == 1)
        {
            Canvas.SetActive(false);
            cam.SetActive(false);
            Controller.SetActive(true);
            Invoke("IfShotgun", 0.1f);
        }
        isActive = false;
    }
    private void IfAssaultRifle()
    {
        AssaultRifle.SetActive(true);
        Shotgun.SetActive(false);
        assaultrifleSelected = true;
        shotgunSelected = false;
}
    private void IfShotgun()
    {
        AssaultRifle.SetActive(false);
        Shotgun.SetActive(true);
        assaultrifleSelected = false;
        shotgunSelected = true;
    }
}
