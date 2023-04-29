namespace asp_intro_hometask.Controllers
{
    public class HomeController
    {
        public string Index(int num, string num2)
        {
            return "This is home page - " + num + " " + num2;
        }

        public string Test()
        {
            return "This is a test action";
        }
    }
}
