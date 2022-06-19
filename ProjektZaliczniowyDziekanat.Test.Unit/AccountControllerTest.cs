using Microsoft.AspNetCore.Mvc;
using Moq;
using ProjektZaliczeniowyDziekanat.Controllers;
using ProjektZaliczeniowyDziekanat.DAL.Models;
using ProjektZaliczeniowyDziekanat.Interfaces;
using Xunit;

namespace ProjektZaliczniowyDziekanat.Test.Unit
{
    public class AccountControllerTest
    {
        Mock<IObslugaAccount> obslugaAccountStub = new Mock<IObslugaAccount>();

        [Fact]
        public void LoginWykladowcy_BrakOdwolania_ZwracaBadRequest()
        {
            //Arrange
            AccountController controller = new AccountController(obslugaAccountStub.Object);
            WykladowcaLogowanie loginWykladowcy = new WykladowcaLogowanie() { Login = "login", Haslo = "haslo" };
            //Act

            var result = controller.LoginWykladowcy(loginWykladowcy.Login, loginWykladowcy.Haslo);
            //Assert

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void LoginStudenta_BrakOdwolania_ZwracaBadRequest()
        {
            //Arrange
            AccountController controller = new AccountController(obslugaAccountStub.Object);
            StudentLogowanie loginStudenta = new StudentLogowanie() { Login = "login", Haslo = "haslo" };
            //Act

            var result = controller.LoginStudenta(loginStudenta.Login, loginStudenta.Haslo);
            //Assert

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void LoginAdmina_BrakOdwolania_ZwracaBadRequest()
        {
            //Arrange
            AccountController controller = new AccountController(obslugaAccountStub.Object);
            Admin loginAdmina = new Admin() { Login = "login", Haslo = "haslo" };
            //Act

            var result = controller.LoginAdmina(loginAdmina.Login, loginAdmina.Haslo);
            //Assert

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void Logout_PustaSesja_ZwracaRedirectToAction()
        {
            AccountController controller = new AccountController(obslugaAccountStub.Object);

            var result = controller.Logout();

            Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
