using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{

    public static bool ShopMenuOpen = false;
    public GameObject ShopMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ShopMenuUI.SetActive(true);
            ShopMenuOpen = true;

        }
        if (ShopMenuOpen = true && Input.GetKeyDown(KeyCode.Escape))
        {
            ShopMenuUI.SetActive(false);
            ShopMenuOpen = false;
        }
    }
}
