using System;
using System.IO;
using ContactsAppBLL;
using System.Reflection;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {

        public string testPath()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(location) + @"\Test";
        }

        public Project PrepareProject()
        {
            var project = new Project();
            var contact = new Contact();
            contact.Name = "Alexey";
            contact.Surname = "Andreyanov";
            contact.BirthDate = new DateTime(1999, 4, 1, 4, 2, 4);
            contact.Email = "andreyanov1999@gmail.com";
            contact.PhoneNumber.Number = "79964157005";
            contact.idVK = "Mlocker";
            project.Contacts.Add(contact);
            return project;
        }

        [Test]
        public void SaveToFile_CorrectProject_CorrectSave()
        {
            //Setup
            var sourceProject = PrepareProject();
            var testDataFolder = testPath();
            var actualFileName = testDataFolder + @"\data.json";
            var expectedFileName = testDataFolder + @"\data.json";

            if (File.Exists(actualFileName))
            {
                File.Delete(actualFileName);
            }

            //Act
            ProjectManager.SaveToFile(sourceProject, actualFileName);
            var isFileExist = File.Exists(actualFileName);
            NUnit.Framework.Assert.AreEqual(true, isFileExist);
            //Assert
            var actualFileContent = File.ReadAllText(actualFileName);
            var expectedFileContent = File.ReadAllText(expectedFileName);
            NUnit.Framework.Assert.AreEqual(expectedFileContent, actualFileContent);
        }

        [Test]
        public void LoadFromFile_CorrectProject_CorrectLoad()
        {
            //setup
            var sourceProject = PrepareProject();
            var loadFileName = testPath() + @"\data.json";

            //Act
            var LoadedProject = ProjectManager.LoadFromFile(loadFileName);

            //Assert
            Assert.AreEqual(LoadedProject.Contacts[0].Surname, sourceProject.Contacts[0].Surname);
            Assert.AreEqual(LoadedProject.Contacts[0].Name, sourceProject.Contacts[0].Name);
            Assert.AreEqual(LoadedProject.Contacts[0].BirthDate, sourceProject.Contacts[0].BirthDate);
            Assert.AreEqual(LoadedProject.Contacts[0].Email, sourceProject.Contacts[0].Email);
            Assert.AreEqual(LoadedProject.Contacts[0].idVK, sourceProject.Contacts[0].idVK);
            Assert.AreEqual(LoadedProject.Contacts[0].PhoneNumber.Number, sourceProject.Contacts[0].PhoneNumber.Number);
        }

        [Test]
        public void LoadFromFile_MissingFile_CorrectCreateEmptyProject()
        {
            //Setup
            var loadFileName = testPath() + @"\datanull.json";

            //Act
            var LoadedProject = ProjectManager.LoadFromFile(loadFileName);

            //Assert
            if (LoadedProject.Contacts.Count != 0) throw new ArgumentException();
        }
    }
}