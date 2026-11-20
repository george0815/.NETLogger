using Terminal.Gui.App;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using System.Globalization;







namespace NETLogger
{

    /// <summary> 
    /// Entry point for program. 
    /// Iniializes settings and starts the Terminal.Gui interface. 
    /// </summary>
    /// <author> George Hunter S.</author> 
    /// <created>Nov, 2026</created> 


    class Program
    {

        public static async Task Main(string[] args)
        {



            using IApplication app = Application.Create();
            app.Init();


            using Window window = new() { Title = "Test" };

            Label label = new()
            {

                Text = "Hello world!",
                X = Pos.Center(),
                Y = Pos.Center()

            };
            window.Add(label);

            app.Run(window);








        }










    }


}
