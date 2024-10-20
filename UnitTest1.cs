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
            public void Test1()// ���� ����������� ������ � ������
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
            public void Test2()// ���� ����������� ������, �� ������������� ������
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
            public void Test3()// ���� ������������� ������, �� ����������� ������
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
            public void Test4()// �������� ������
            {
                password = "Fake_Account1";
                login = "qwefakeaccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login); // ���� ������
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password); // ���� ������
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click(); // ������������, ������� � �����
                System.Threading.Thread.Sleep(10000); // ���� �������� ��������
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(100000);
                IWebElement NewLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div/div[1]/div[2]/button"));
                NewLetter.Click(); // �������� ������ ������
                System.Threading.Thread.Sleep(10000);
                IWebElement Receiver = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div[1]/div/div[2]/div/div/div/div/div/div/input"));
                Receiver.SendKeys("Quessssstion@protonmail.com"); // ��������� ���� ����������
                System.Threading.Thread.Sleep(5000);
                IWebElement Theme = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div[1]/div/div[3]/div/div/input"));
                Theme.SendKeys("Test"); // ��������� ���� ����
                var iframeElement = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div/section/div[1]/div[1]/div/div/iframe"));
                driver.SwitchTo().Frame(iframeElement);
                var element = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[1]"));
                element.SendKeys("��� �����"); // ��������� �����
                driver.SwitchTo().DefaultContent();                                             
                System.Threading.Thread.Sleep(5000);
                IWebElement SendLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/footer/div/div[1]/button[1]"));
                SendLetter.Click(); //���������� ������
                System.Threading.Thread.Sleep(5000);
             }

            [Test]
            public void Test5()  // �������� ������� � ������������ ���������� ������, �������� ������ ����������
            {
                password = "Fake_Account2";
                login = "Quessssstion@protonmail.com";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login); // ���� ������
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password); // ���� ������
                System.Threading.Thread.Sleep(5000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click(); // ������������, ������� � �����
                System.Threading.Thread.Sleep(8000); // ���� �������� ��������
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(100000);
                var Letters = driver.FindElements(By.CssSelector("body > div.app-root > div.flex.flex-row.flex-nowrap.h-full > div > div > div > div.flex.flex-column.flex-1.flex-nowrap.reset4print > div > div > div > main > div > div > div > div > div > div.items-column-list-container.h-full.overflow-auto.flex.flex-column.flex-nowrap.w-full > div"));

                // ��������� �� ������� ������ � �������� ��� ����������
                foreach (var Letter in Letters)
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    IWebElement unreadElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'unread') and .//span[text()='������������� �����']]")));

                    if (unreadElement != null)
                    {
                        Console.WriteLine("������� �������� �������������.");
                        IWebElement LetterIneed = driver.FindElement(By.CssSelector("body > div.app-root > div.flex.flex-row.flex-nowrap.h-full > div > div > div > div.flex.flex-column.flex-1.flex-nowrap.reset4print > div > div > div > main > div > div > div > div > div > div.items-column-list-container.h-full.overflow-auto.flex.flex-column.flex-nowrap.w-full > div > div:nth-child(2) > div"));
                        LetterIneed.Click();// ������� � ������
                        System.Threading.Thread.Sleep(5000);

                        IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/main/div/div/section/div/div[3]/div/div/div/article/div[1]/div[4]/div[2]/button[1]"));
                        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);

                        var iframeElement = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div/section/div[1]/div[1]/div/div/iframe"));
                        driver.SwitchTo().Frame(iframeElement); // ������������� � ���� ��� ���������
                        IWebElement message = driver.FindElement(By.XPath("//*[@id=\"rooster-editor\"]/div[1]"));
                        message.SendKeys("111"); // ���������� ����� ���������
                        driver.SwitchTo().DefaultContent();
                        System.Threading.Thread.Sleep(5000);

                        WebDriverWait waits = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        IWebElement sendButton = waits.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[span[text()='���������']]")));
                        sendButton.Click();
                        System.Threading.Thread.Sleep(5000);
                    }
                    else 
                    { 
                        Console.WriteLine("!!!������!!!������ ������ �� ���������� ��� �������������"); 
                    }
                }
            }
            [Test]
            public void Test6()// ��������� ������
            {
                password = "Fake_Account1";
                login = "qwefakeaccount@proton.me";
                driver.Url = test_url;
                System.Threading.Thread.Sleep(10000);
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/div[2]/div[1]/div/div/input"));
                LoginButton.SendKeys(login); // ���� ������
                IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
                Password.SendKeys(password); // ���� ������
                System.Threading.Thread.Sleep(1000);
                IWebElement Access = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[1]/main/div[1]/div[2]/form/button"));
                Access.Click(); // ������������, ������� � �����
                System.Threading.Thread.Sleep(10000);
                IWebElement Mail = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/main/div/div[2]/ul/li[1]/button/div/div[2]"));
                Mail.Click();
                System.Threading.Thread.Sleep(50000); // ���� �������� ��������
                IWebElement NewNameLetter = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/main/div/div/div/div/div/div[3]/div/div[1]/div"));
                NewNameLetter.Click();// ��������� ������ � ����� �����������
                System.Threading.Thread.Sleep(10000); // ���� �������� ��������
                var iframeElement = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/main/div/div/section/div/div[3]/div/div/div/article[2]/div[2]/div/iframe"));
                driver.SwitchTo().Frame(iframeElement); // ������������� � ���� ��� ���������
                IWebElement message = driver.FindElement(By.CssSelector("#proton-root > div > div > div:nth-child(1)"));
                string NewName = message.GetAttribute("innerText");
                Console.WriteLine(NewName);
                driver.SwitchTo().DefaultContent();

                IWebElement SettingsButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[2]/div/div/div/header/div[2]/ul/li[2]/button"));
                SettingsButton.Click();
                IWebElement AllSettingsButton = driver.FindElement(By.XPath("//*[@id=\"drawer-app-proton-settings\"]/div[2]/div/div[3]/div/div/a[1]"));
                AllSettingsButton.Click();
                System.Threading.Thread.Sleep(10000); // ���� �������� ��������

                IWebElement AccountSettings = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/div[1]/div[4]/nav/ul/ul[1]/li[5]/a"));
                AccountSettings.Click();
                IWebElement NameChange = driver.FindElement(By.XPath("//*[@id=\"account\"]/div[1]/div[2]/div[2]/div/button"));
                NameChange.Click();
                IWebElement NewNameInput = driver.FindElement(By.XPath("//*[@id=\"displayName\"]"));//������ ����� ���, ������� �������� � ������
                NewNameInput.SendKeys(NewName);
                IWebElement SaveSettings = driver.FindElement(By.XPath("/html/body/div[4]/dialog/form/div[3]/button[2]"));//��������� ���������
                SaveSettings.Click();
                System.Threading.Thread.Sleep(10000); // ���� �������� ��������
                IWebElement ActualName = driver.FindElement(By.XPath("//*[@id=\"account\"]/div[1]/div[2]/div[2]/div/div"));
                string ActualNamE = ActualName.GetAttribute("innerText");
                if (ActualNamE == NewName)// �����������, ������� �� �������� ���������
                {
                    Console.WriteLine("����������. ��� ��������!");
                }
                else 
                {
                    Console.WriteLine("!!! ������ !!! ��� �������� �������.");
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
