using System;

namespace Throw
{
    class MainApp
    {
        static void DoSomething(int arg)
		{
			if (arg < 10)
			{
				Console.WriteLine($"arg: {arg}");
			}
			else
			{
				throw new Exception($"arg가 10보다 큰 ({arg}) 입니다.");
			}
		}		
		
		static void Main(string[] args)
        {
			try
			{
				DoSomething(1);
                DoSomething(9);
                DoSomething(11);
            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
        }
    }
}
