using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SwapGear : MonoBehaviour
{
    [Header("Panels")]
    public GameObject WarframePanel;
    public GameObject MainWeaponPanel;
    public GameObject SecondaryWeaponPanel;
    public GameObject MeleeWeaponPanel;
    private bool WFPanelOpen = false;
    private bool MainPanelOpen = false;
    private bool SecondaryPanelOpen = false;
    private bool MeleePanelOpen = false;

    [Header("Warframe")]
    public GameObject WarframeMagIcon;
    public GameObject WarframeMagName;
    public GameObject WarframeRevenantIcon;
    public GameObject WarframeRevenantName;

    [Header("MainWeapon")]
    public GameObject MainWeaponArcaPlasmorIcon;
    public GameObject MainWeaponArcaPlasmorName;
    public GameObject MainWeaponFelarxIcon;
    public GameObject MainWeaponFelarxName;

    [Header("SecondaryWeapon")]
    public GameObject SecondaryWeaponEpitapheIcon;
    public GameObject SecondaryWeaponEpitapheName;
    public GameObject SecondaryWeaponLaetumIcon;
    public GameObject SecondaryWeaponLaetumName;

    [Header("MeleeWeapon")]
    public GameObject MeleeWeaponKronenPrimeIcon;
    public GameObject MeleeWeaponKronenPrimeName;
    public GameObject MeleeWeaponCerataIcon;
    public GameObject MeleeWeaponCerataName;



    private void Update()
    {
        if (WFPanelOpen==false)
        {
            WarframePanel.SetActive(false);
        }
        if (MainPanelOpen==false)
        {
            MainWeaponPanel.SetActive(false);
        }

        if (SecondaryPanelOpen==false)
        {
            SecondaryWeaponPanel.SetActive(false);
        }
        if (MeleePanelOpen==false)
        {
            MeleeWeaponPanel.SetActive (false);
        }
    }

    public void SwitchPanel(string Name)
    {
        switch(Name)
        {
            case "WarframePanel":
                WFPanelOpen = true;
                WarframePanel.SetActive(true);
                MainWeaponPanel.SetActive(false);
                SecondaryWeaponPanel.SetActive(false);
                MeleeWeaponPanel.SetActive(false);
                break;

            case "MainWeaponPanel":
                MainPanelOpen = true;
                WarframePanel.SetActive(false);
                MainWeaponPanel.SetActive(true);
                SecondaryWeaponPanel.SetActive(false);
                MeleeWeaponPanel.SetActive(false);
                break ;

            case "SecondaryWeaponPanel":
                SecondaryPanelOpen = true;
                WarframePanel.SetActive(false);
                MainWeaponPanel.SetActive(false);
                SecondaryWeaponPanel.SetActive(true);
                MeleeWeaponPanel.SetActive(false);
                break ;

            case "MeleeWeaponPanel":
                MeleePanelOpen = true;
                WarframePanel.SetActive(false);
                MainWeaponPanel.SetActive(false);
                SecondaryWeaponPanel.SetActive(false);
                MeleeWeaponPanel.SetActive(true);
                break ;

                default:
                break ;

        }
    }


    public void Equip(string name)
    {
        switch(name)
        {
            case "MagPrime":
                WarframeMagIcon.SetActive(true);
                WarframeMagName.SetActive(true);
                WarframeRevenantIcon.SetActive(false);
                WarframeRevenantName.SetActive(false);
                WFPanelOpen = false;
                break ;

            case "RevenantPrime":
                WarframeMagIcon.SetActive(false);
                WarframeMagName.SetActive(false);
                WarframeRevenantIcon.SetActive(true);
                WarframeRevenantName.SetActive(true);
                WFPanelOpen = false;
                break ;


            case "TenetArcaPlasmor":
                MainWeaponArcaPlasmorIcon.SetActive(true);
                MainWeaponArcaPlasmorName.SetActive(true);
                MainWeaponFelarxIcon.SetActive(false);
                MainWeaponFelarxName.SetActive(false);
                MainPanelOpen = false;
                break ;

            case "Felarx":
                MainWeaponArcaPlasmorIcon.SetActive(false);
                MainWeaponArcaPlasmorName.SetActive(false);
                MainWeaponFelarxIcon.SetActive(true);
                MainWeaponFelarxName.SetActive(true);
                MainPanelOpen = false;
                break ;

            case "Epitaphe":
                SecondaryWeaponEpitapheIcon.SetActive(true);
                SecondaryWeaponEpitapheName.SetActive(true);
                SecondaryWeaponLaetumIcon.SetActive(false);
                SecondaryWeaponLaetumName.SetActive(false);
                SecondaryPanelOpen = false;
                break ;

            case "Laetum":
                SecondaryWeaponEpitapheIcon.SetActive(false);
                SecondaryWeaponEpitapheName.SetActive(false);
                SecondaryWeaponLaetumIcon.SetActive(true);
                SecondaryWeaponLaetumName.SetActive(true);
                SecondaryPanelOpen = false;
                break ;

            case "KronenPrime":
                MeleeWeaponKronenPrimeIcon.SetActive(true);
                MeleeWeaponKronenPrimeName.SetActive(true);
                MeleeWeaponCerataIcon.SetActive(false);
                MeleeWeaponCerataName.SetActive(false);
                MeleePanelOpen = false;
                break ;

            case "Cerata":
                MeleeWeaponKronenPrimeIcon.SetActive(false);
                MeleeWeaponKronenPrimeName.SetActive(false);
                MeleeWeaponCerataIcon.SetActive(true);
                MeleeWeaponCerataName.SetActive(true);
                MeleePanelOpen = false;
                break;





        }
    }
        
}
