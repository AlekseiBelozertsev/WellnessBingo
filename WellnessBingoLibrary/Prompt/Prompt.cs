namespace WellnessBingo
{
    public class Prompt
    {
        private bool response;

        public bool Response
        {
            get { return response; }
            private set { response = value; }
        }

        public void UserPrompt(bool isFinished) {
            Console.WriteLine("Do you wish to proceed? Y/N");
            string result = Console.ReadLine();
            System.Console.WriteLine(result);
        }
    };
}