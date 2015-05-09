using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeTest
{
public class Person
{
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = birthDate;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int SkillLevel { get; set; }
}

    public class JavaScriptInteractionObj
    {
        public Person m_theMan = null;

        [JavascriptIgnore]
        public ChromiumWebBrowser m_chromeBrowser { get; set; }

        public JavaScriptInteractionObj()
        {
            m_theMan = new Person("Bat", "Man", DateTime.Now);
        }

        [JavascriptIgnore]
        public void SetChromeBrowser(ChromiumWebBrowser b)
        {
            m_chromeBrowser = b;
        }

        public string SomeFunction()
        {
            return "yippieee";
        }

        public string GetPerson()
        {
            var p1 = new Person( "Bruce", "Banner", DateTime.Now );

            string json = JsonConvert.SerializeObject(p1);

            return json;
        }

        public string ErrorFunction()
        {
            return null;
        }

        public string GetListOfPeople()
        {
            List<Person> peopleList = new List<Person>();

            peopleList.Add(new Person("Scooby", "Doo", DateTime.Now));
            peopleList.Add(new Person("Buggs", "Bunny", DateTime.Now));
            peopleList.Add(new Person("Daffy", "Duck", DateTime.Now));
            peopleList.Add(new Person("Fred", "Flinstone", DateTime.Now));
            peopleList.Add(new Person( "Iron", "Man", DateTime.Now));

            string json = JsonConvert.SerializeObject(peopleList);

            return json;
        }

        public void ExecJSFromWinForms()
        {
            var script = "document.body.style.backgroundColor = 'red';";

            m_chromeBrowser.ExecuteScriptAsync(script);
        }

        public void TestJSCallback(IJavascriptCallback javascriptCallback)
        {
            using (javascriptCallback)
            {
                javascriptCallback.ExecuteAsync("Hello from winforms and C# land!");
            }
        }
    }
}