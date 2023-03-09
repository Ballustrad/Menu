using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    [Header("Panels")]
    public GameObject MagDescription;
    public GameObject RevenantDescription;
    public GameObject TenetArcaPlasmorDescription;
    public GameObject FelarxDescription;
    public GameObject EpitapheDescription;
    public GameObject LaetumDescription;
    public GameObject KronenPrimeDescription;
    public GameObject CerataDescription;

    [Space]
    public SwapGear swapGear;
    public void CloseDescription()
    {
        MagDescription.SetActive(false);
        RevenantDescription.SetActive(false);
        TenetArcaPlasmorDescription.SetActive(false);
        FelarxDescription.SetActive(false);
        EpitapheDescription.SetActive(false);
        LaetumDescription.SetActive(false);
        KronenPrimeDescription.SetActive(false);
        CerataDescription.SetActive(false);
    }
    public void SwapeDescription(string name)
    {
        swapGear.WarframePanel.SetActive(false);
        swapGear.MainWeaponPanel.SetActive(false);
        swapGear.SecondaryWeaponPanel.SetActive(false);
        swapGear.MeleeWeaponPanel.SetActive(false);
        switch(name)
        {
            case "MagPrime":
                MagDescription.SetActive(true);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(false);
                break;

            case "RevenantPrime":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(true);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(false);
                break;

            case "ArcaPlasmor":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(true);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(false);
                break;

            case "Felarx":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(true);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(false);
                break;

            case "Epitaphe":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(true);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(false);
                break;

            case "Laetum":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(true);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(false);
                break;

            case "KronenPrime":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(true);
                CerataDescription.SetActive(false);
                break;

            case "Cerata":
                MagDescription.SetActive(false);
                RevenantDescription.SetActive(false);
                TenetArcaPlasmorDescription.SetActive(false);
                FelarxDescription.SetActive(false);
                EpitapheDescription.SetActive(false);
                LaetumDescription.SetActive(false);
                KronenPrimeDescription.SetActive(false);
                CerataDescription.SetActive(true);
                break;

            default:
                break;

        }
    }

}
