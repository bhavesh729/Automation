# Automation


Selenium var loginButton = driver.FindElement(By.Id("authenticationSubmitButton");

CodedUI  HtmlButton loginButton = new HtmlButton(parent);
         acceptBtn.SearchProperties.Add("Id", "authenticationSubmitButton", "InnerText", "Confirm");
                
TestLeft IWebElement loginButton = parent.Find<IWebElement>( 
        new WebBrowserPattern() {}.Add("Id","authenticationSubmitButton").Add("InnerText","Confirm");
