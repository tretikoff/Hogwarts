using System.Linq;
using Xunit;
using SignUp;
using Xunit.Abstractions;

namespace Test
{
    public class UserStorageServiceTest
    {
        private readonly UserStorageService _userStorageService;
        private readonly ITestOutputHelper _output;

        private readonly User _user = new User()
        {
            UserName = "Nikita",
            Password="VezdePobrito"
        };
        
        public UserStorageServiceTest(ITestOutputHelper output)
        {
            _output = output;
            _userStorageService = new UserStorageService();
            _userStorageService.CreateUser(_user);
        }

        [Fact]
        public void TestGetAllUsers()
        {
            var users = _userStorageService.GetUsers();
            var enumerable = users as User[] ?? users.ToArray();
            _output.WriteLine("Database contains {0} users", enumerable.Count());
            Assert.True(enumerable.Contains(_user));
        }
        
        [Fact]
        public void TestSave()
        {
            const string username = "LoadMe";
                        var loadUser = new User()
                        {
                            UserName = username,
                            Password = "please"
                        };
                        _userStorageService.CreateUser(loadUser);
                        var savedUser = _userStorageService.GetUsers();
                        Assert.True(savedUser != null);
        }
    }
}