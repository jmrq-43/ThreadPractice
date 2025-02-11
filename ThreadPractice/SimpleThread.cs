namespace ThreadPractice;

public class SimpleThread
{
    public static void SayHelloThread()
    {
        Thread thread1 =  new Thread(SayHello1);
        Thread thread2 = new Thread(SayHello2);
        thread1.Start();
        thread2.Start();
    }

    private static void  SayHello1()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("hello Froma SayHello1");
            Thread.Sleep(100);
        }
    }

    private static void SayHello2()
    {
        for (int i = 0; i < 100;  i++)
        {
            Console.WriteLine("hello Froma SayHello2");
            Thread.Sleep(100);
        }
    }
}