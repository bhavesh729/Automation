# Automation

CodedUI  
HtmlButton submitButton = new HtmlButton(parent);
acceptBtn.SearchProperties.Add("Id", "authenticationSubmitButton", "InnerText", "Confirm");
                
TestLeft
IWebElement submitButton = parent.Find<IWebElement>( 
new WebBrowserPattern() {}.Add("Id","authenticationSubmitButton").Add("InnerText","Confirm");

Selenium
var submitButton = driver.FindElement(By.Id("authenticationSubmitButton");
