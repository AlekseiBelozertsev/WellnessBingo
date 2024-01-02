namespace WellnessBingo
{
    public class Prompt
    {
        public bool response;

        public void UserPrompt(bool isFinished) {
            Console.WriteLine("Do you wish to proceed? Y/N");
            string result = Console.ReadLine();
            System.Console.WriteLine(result);
        }
    };
}