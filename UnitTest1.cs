using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace TestProject_2
{
    public class Tests
    {
        public class Browser_ops
        {
            ChromeDriver driver;
            public void Init_Browser()
            {
                driver = new ChromeDriver();
            }
            public void Goto(string test_url)
            {
                driver.Url = test_url;
            }
            public void Close()
            {
                driver.Quit();
            }
            public ChromeDriver getDriver
            {
                get { return driver; }
            }
        }
        class TestProject2
        {
            string test_url = "https://account.proton.me/login";
            string? password { get; set; }
            string? login { get; set; }
            string? letter { get; set; }
            string receiver { get; set; }        
            ChromeDriver driver;


            [SetUp]
            public void Tests()
            {
                driver = new ChromeDriver ("C:\\Users\\37529\\Downloads\\chromedriver-win64\\chromedriver-win64\\");
            }
            [Test]
            public void Test1()// ввод правильного логина и пароля
            {
                password = "Fake_Account1";
                login = "qwefakeaccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));                
                LoginButton.SendKeys(login);                
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password);
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click();
                System.Threading.Thread.Sleep(10000);
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(50000);
                IWebElement NewLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div/div[1]/div[2]/button"));
                NewLetter.Click();
                System.Threading.Thread.Sleep(10000);

            }        
            [Test]
            public void Test2()// ввод правильного логина, но неправильного пароля
            {
                password = "Fake_Account7";
                login = "qwefakeaccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login);
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password);
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click();
                System.Threading.Thread.Sleep(10000);
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
            }
            [Test]
            public void Test3()// ввод неправильного логина, но правильного пароля
            {
                password = "Fake_Account1";
                login = "qwefakeccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login);
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password);
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click();
                System.Threading.Thread.Sleep(10000);
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
            }
            [Test]
            public void Test4()// отправка письма
            {
                password = "Fake_Account1";
                login = "qwefakeaccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login); // ввод логина
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password); // ввод пароля
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click(); // подтверждаем, заходим в почту
                System.Threading.Thread.Sleep(10000); // ждем загрузку страницы
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(100000);
                IWebElement NewLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div/div[1]/div[2]/button"));
                NewLetter.Click(); // создание нового письма
                System.Threading.Thread.Sleep(10000);
                IWebElement Receiver = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div[1]/div/div[2]/div/div/div/div/div/div/input"));
                Receiver.SendKeys("Quessssstion@protonmail.com"); // заполняем поле получателя
                System.Threading.Thread.Sleep(5000);
                IWebElement Theme = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div[1]/div/div[3]/div/div/input"));
                Theme.SendKeys("Test"); // заполняем поле темы
                var iframeElement = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div/section/div[1]/div[1]/div/div/iframe"));
                driver.SwitchTo().Frame(iframeElement);
                var element = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[1]"));
                element.SendKeys("Ваш текст"); // добавляем текст
                driver.SwitchTo().DefaultContent();                                             
                System.Threading.Thread.Sleep(5000);
                IWebElement SendLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/footer/div/div[1]/button[1]"));
                SendLetter.Click(); //отправляем письмо
                System.Threading.Thread.Sleep(5000);
             }

            [Test]
            public void Test5()  // проверка наличия и соответствия содержания письма, отправка нового псевдонима
            {
                password = "Fake_Account2";
                login = "Quessssstion@protonmail.com";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login); // ввод логина
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password); // ввод пароля
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click(); // подтверждаем, заходим в почту
                System.Threading.Thread.Sleep(8000); // ждем загрузку страницы
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(100000);
                var Letters = driver.FindElements(By.CssSelector("body > div.app-root > div.flex.flex-row.flex-nowrap.h-full > div > div > div > div.flex.flex-column.flex-1.flex-nowrap.reset4print > div > div > div > main > div > div > div > div > div > div.items-column-list-container.h-full.overflow-auto.flex.flex-column.flex-nowrap.w-full > div"));

                // Пройдемся по каждому письму и проверим его содержимое
                foreach (var Letter in Letters)
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    IWebElement unreadElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'unread') and .//span[text()='Непрочитанная почта']]")));

                    if (unreadElement != null)
                    {
                        Console.WriteLine("Элемент является непрочитанным.");
                        IWebElement LetterIneed = driver.FindElement(By.CssSelector("body > div.app-root > div.flex.flex-row.flex-nowrap.h-full > div > div > div > div.flex.flex-column.flex-1.flex-nowrap.reset4print > div > div > div > main > div > div > div > div > div > div.items-column-list-container.h-full.overflow-auto.flex.flex-column.flex-nowrap.w-full > div > div:nth-child(2) > div"));
                        LetterIneed.Click();// заходим в письмо
                        System.Threading.Thread.Sleep(5000);

                        IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/main/div/div/section/div/div[3]/div/div/div/article/div[1]/div[4]/div[2]/button[1]"));
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);

                        var iframeElement = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div/section/div[1]/div[1]/div/div/iframe"));
                        driver.SwitchTo().Frame(iframeElement); // переключаемся в поле для сообщения
                        IWebElement message = driver.FindElement(By.XPath("//*[@id=\"rooster-editor\"]/div[1]"));
                        message.SendKeys("111"); // отправляем новый псевдоним
                        driver.SwitchTo().DefaultContent();
                        System.Threading.Thread.Sleep(5000);

                        WebDriverWait waits = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        IWebElement sendButton = waits.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[span[text()='Отправить']]")));
                        sendButton.Click();
                        System.Threading.Thread.Sleep(5000);
                    }
                    else 
                    { 
                        Console.WriteLine("!!!ОШИБКА!!!Нужное письмо не отображено как непрочитанное"); 
                    }
                }
            }
            [Test]
            public void Test6()// получение письма
            {
                password = "Fake_Account1";
                login = "qwefakeaccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login); // ввод логина
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password); // ввод пароля
                System.Threading.Thread.Sleep(1000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click(); // подтверждаем, заходим в почту
                System.Threading.Thread.Sleep(10000);
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(50000); // ждем загрузку страницы
                IWebElement NewNameLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/main/div/div/div/div/div/div[3]/div/div[1]/div"));
                NewNameLetter.Click();// открываем письмо с новым псевдонимом
                System.Threading.Thread.Sleep(10000); // ждем загрузку страницы
                var iframeElement = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/main/div/div/section/div/div[3]/div/div/div/article[2]/div[2]/div/iframe"));
                driver.SwitchTo().Frame(iframeElement); // переключаемся в поле для сообщения
                IWebElement message = driver.FindElement(By.CssSelector("#proton-root > div > div > div:nth-child(1)"));
                string NewName = message.GetAttribute("innerText");
                Console.WriteLine(NewName);
                driver.SwitchTo().DefaultContent();

                IWebElement SettingsButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/header/div[2]/ul/li[2]/button"));
                SettingsButton.Click();
                IWebElement AllSettingsButton = driver.FindElement(By.XPath("//*[@id=\"drawer-app-proton-settings\"]/div[2]/div/div[3]/div/div/a[1]"));
                AllSettingsButton.Click();
                System.Threading.Thread.Sleep(10000); // ждем загрузку страницы

                IWebElement AccountSettings = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[1]/div[4]/nav/ul/ul[1]/li[5]/a"));
                AccountSettings.Click();
                IWebElement NameChange = driver.FindElement(By.XPath("//*[@id=\"account\"]/div[1]/div[2]/div[2]/div/button"));
                NameChange.Click();
                IWebElement NewNameInput = driver.FindElement(By.XPath("//*[@id=\"displayName\"]"));//вводим новое имя, которое прислали в письме
                NewNameInput.SendKeys(NewName);
                IWebElement SaveSettings = driver.FindElement(By.XPath("/html/body/div[4]/dialog/form/div[3]/button[2]"));//сохраняем настройки
                SaveSettings.Click();
                System.Threading.Thread.Sleep(10000); // ждем загрузку страницы
                IWebElement ActualName = driver.FindElement(By.XPath("//*[@id=\"account\"]/div[1]/div[2]/div[2]/div/div"));
                string ActualNamE = ActualName.GetAttribute("innerText");
                if (ActualNamE == NewName)// уведомление, удалось ли изменить псевдоним
                {
                    Console.WriteLine("Поздравляю. Имя изменено!");
                }
                else 
                {
                    Console.WriteLine("!!! ОШИБКА !!! Имя осталось прежним.");
                }
            }

            [TearDown]
            public void close_Browser()
            {
                driver.Quit();
            }
            }
    }
}
