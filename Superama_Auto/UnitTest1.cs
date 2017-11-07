using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Support.UI;

namespace Superama_Auto
{
    [TestClass]
    public class UnitTest1
    {

        AppiumDriver<AndroidElement> _driver;
        DesiredCapabilities cap = new DesiredCapabilities();

        [TestMethod]
        public void ConexionInicial()
        {
            cap.SetCapability("deviceName", "51_pulgadas");
            cap.SetCapability("platformVersion", "6.0.0");
            cap.SetCapability("appActivity", "com.grability.core.ui.activities.MainActivity");
            cap.SetCapability("appPackage", "com.superama.internals");
            cap.SetCapability("platformName", "Android");


        }

        [TestMethod]
        public void InicioSesion()
        {
            ConexionInicial();
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap, TimeSpan.FromSeconds(180));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(180));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("com.superama.internals:id/imageView_categories")));
            _driver.FindElementById("com.superama.internals:id/circleImageView_menu").Click();
            _driver.FindElementById("com.superama.internals:id/textView_nameUser").Click();
            // aqui se diligencian los campos usuario y password
            _driver.FindElementById("com.superama.internals:id/editText_email").SendKeys("jeysson.barba@grability.com");
            _driver.FindElementById("com.superama.internals:id/ediText_password").SendKeys("abcde123");
            _driver.FindElementById("com.superama.internals:id/button_sign_in");
            _driver.Quit();
        }

        [TestMethod]
        public void OlvideMiContrasena()
        {
            ConexionInicial();
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap, TimeSpan.FromSeconds(180));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(180));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("com.superama.internals:id/imageView_categories")));
            _driver.FindElementById("com.superama.internals:id/circleImageView_menu").Click();
            _driver.FindElementById("com.superama.internals:id/textView_nameUser").Click();
            //Aqui se da clic en olvide mi contraseña
            _driver.FindElementById("com.superama.internals:id/editText_email").SendKeys("jeysson.barba@grability.com");
            _driver.FindElementById("com.superama.internals:id/textView_recover_password").Click();
            //Aqui se define el correo y se da clic en recordar contraseña
            _driver.FindElementById("com.superama.internals:id/ediText_email").SendKeys("jeysson.barba@grability.com");
            _driver.FindElementById("com.superama.internals:id/button_recover_password").Click();
            _driver.Quit();
        }

        [TestMethod]
        public void Registro()
        {
            ConexionInicial();
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap, TimeSpan.FromSeconds(180));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(180));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("com.superama.internals:id/imageView_categories")));
            _driver.FindElementById("com.superama.internals:id/circleImageView_menu").Click();
            _driver.FindElementById("com.superama.internals:id/textView_nameUser").Click();
            // aqui se da clic en la pestaña correspondiente
            _driver.FindElementByClassName("android.widget.TextView").Click();
            // aqui se definen los dos primeros datos y se da clic para abrir los siguientes campos
            _driver.FindElementById("com.superama.internals:id/ediText_email").SendKeys("jeysson.barba@grability.com");
            _driver.FindElementById("com.superama.internals:id/ediText_password").SendKeys("Classname123");
            _driver.FindElementById("com.superama.internals:id/sign_up_button").Click();
            // aqui se visualizan otros campos que corresponden con el registro
            _driver.FindElementById("com.superama.internals:id/ediText_name").SendKeys("Jeysson");
            _driver.FindElementById("com.superama.internals:id/ediText_lastname").SendKeys("Barba");
            _driver.FindElementById("com.superama.internals:id/ediText_birthday").SendKeys("05/06/1995");
            _driver.Quit();
        }
    }
}
