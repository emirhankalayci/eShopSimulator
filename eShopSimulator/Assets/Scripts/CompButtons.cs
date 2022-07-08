using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompButtons : MonoBehaviour
{
    #region Gameobjects
    [SerializeField] GameObject DesktopPage;
    [SerializeField] GameObject KrediPage;
    [SerializeField] GameObject FamazonPage;
    [SerializeField] GameObject KumarPage;
    [SerializeField] GameObject GelistirPage;
    #endregion

    #region Giriþ Butonlarý
    public void whenKrediClicked()
    {
        DesktopPage.SetActive(false);
        KrediPage.SetActive(true);
    }

    public void whenFamazonClicked()
    {
        DesktopPage.SetActive(false);
        FamazonPage.SetActive(true);
    }

    public void whenKumarClicked()
    {
        DesktopPage.SetActive(false);
        KumarPage.SetActive(true);
    }
    public void whenGelistirClicked()
    {
        DesktopPage.SetActive(false);
        GelistirPage.SetActive(true);
    }
    #endregion

    #region Çýkýþ Butonlarý
    public void whenKrediBackClicked()
    {
        DesktopPage.SetActive(true);
        KrediPage.SetActive(false);
    }

    public void whenFamazonBackClicked()
    {
        DesktopPage.SetActive(true);
        FamazonPage.SetActive(false);
    }

    public void whenKumarBackClicked()
    {
        DesktopPage.SetActive(true);
        KumarPage.SetActive(false);
    }
    public void whenGelistirBackClicked()
    {
        DesktopPage.SetActive(true);
        GelistirPage.SetActive(false);
    }
    #endregion
}
