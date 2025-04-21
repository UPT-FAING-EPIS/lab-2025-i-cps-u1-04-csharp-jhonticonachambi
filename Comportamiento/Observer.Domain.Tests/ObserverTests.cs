using NUnit.Framework;
using Observer.Domain;

namespace Observer.Domain.Tests
{
    public class ObserverTests
    {
        [Test]
        public void WhenSubjectStateChanges_ObserversAreNotified()
        {
            var subject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("Observer 1");
            var observer2 = new ConcreteObserver("Observer 2");
            
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            
            using (var consoleOutput = new ConsoleOutput())
            {
                subject.State = "New State";
                Assert.IsTrue(consoleOutput.GetOutput().Contains("Observer 1 received message: New State"));
                Assert.IsTrue(consoleOutput.GetOutput().Contains("Observer 2 received message: New State"));
            }
        }
    }
    
    // Helper class to capture console output
    public class ConsoleOutput : System.IDisposable
    {
        private System.IO.StringWriter stringWriter;
        private System.IO.TextWriter originalOutput;
        
        public ConsoleOutput()
        {
            stringWriter = new System.IO.StringWriter();
            originalOutput = System.Console.Out;
            System.Console.SetOut(stringWriter);
        }
        
        public string GetOutput()
        {
            return stringWriter.ToString();
        }
        
        public void Dispose()
        {
            System.Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}