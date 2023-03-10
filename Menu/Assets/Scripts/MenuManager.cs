using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public GameObject MainMenu;
    public GameObject MenuOptions;
    public GameObject LoadMission;
    public GameObject Loadout;

    public void Quit()
    {
        Application.Quit();
    }
    public void ButtonClicked(string _String)
    {

        if (_String == "Options")
        {
            MainMenu.SetActive(false);
            MenuOptions.SetActive(true);
        }
        if (_String == "Return Options")
        {
            MainMenu.SetActive(true);
            MenuOptions.SetActive(false);
        }
        if (_String == "LoadMission")
        {
            MainMenu.SetActive(false);
            LoadMission.SetActive(true);
        }
        if (_String == "Return LoadMission")
        {
            MainMenu.SetActive(true);
            LoadMission.SetActive(false);
        }
        if (_String == "Loadout")
        {
            MenuOptions.SetActive(false);
            Loadout.SetActive(true);
        }
        if (_String == "Return Loadout")
        {
            MenuOptions.SetActive(true);
            Loadout.SetActive(false);
        }

    }
}
