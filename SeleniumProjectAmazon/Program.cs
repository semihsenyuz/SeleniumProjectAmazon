using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumProjectAmazon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.amazon.com.tr/";

            //Linke gider
            driver.Navigate().GoToUrl(link);

            //Çerezler Kabul Edilir
            driver.FindElement(By.Id("sp-cc-accept")).Click();
            //Giriş Butonu Tıklanır
            driver.FindElement(By.Id("a-autoid-2-announce")).Click();
            //Kullanıcı Adı Yazılır
            driver.FindElement(By.Id("ap_email")).SendKeys("+905316609913");
            driver.FindElement(By.Id("continue")).Click();
            //Sifre Yazılır
            driver.FindElement(By.Id("ap_password")).SendKeys("546363");
            driver.FindElement(By.Id("signInSubmit")).Click();
            //Bilgisayar Seçeneği Secilir
            driver.FindElement(By.XPath(".//*[@id='searchDropdownBox']/option[4]")).Click();
            //MSI yazılır
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("msi");
            //Arama Butonuna Basılır
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            //ikinci sayfa açılır
            driver.FindElement(By.XPath(".//*[@class='a-pagination']/li[3]")).Click();
            //ikinci ürün seçilir ve favorilere eklenir.
            driver.FindElement(By.XPath(".//*[@class='s-desktop-width-max s-desktop-content s-opposite-dir sg-row']/div/div/span[3]/div[2]/div[2]")).Click();
            driver.FindElement(By.Id("wishlistButtonStack")).Click();
            driver.Navigate().GoToUrl(@"https://www.amazon.com.tr/hz/wishlist/ls/11XGMOYH9IT4H/ref=nav_wishlist_lists_1");
            //Ürün Listeden Kaldırılır
            driver.FindElement(By.Id("delete-button-IJ91JAOULNXFL")).Click();





        }
    }
}
