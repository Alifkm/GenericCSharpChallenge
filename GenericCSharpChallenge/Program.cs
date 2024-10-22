namespace GenericCSharpChallenge
{

    internal class Program
    {
        static void Main(string[] args)
        {
            EmailTask emailTask = new EmailTask()
            {
                Message = "Hello, ini messagenya nih",
                Recipient = "Gue@gmail.com"
            };

            ReportTask reportTask = new ReportTask()
            {
                ReportName = "Gue"
            };

            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());
        }
    }

}