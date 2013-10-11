#region Name space
using System; 
#endregion

namespace SingletonDesignPattern
{
    // This Class is to Implement the Functionalities of Singleton Class
    class Implementation
    {
        private static void Main(string[] args)
        {
            Singleton.Instance.Show();//Display using instance
            Singleton.Instance.Show();
            Console.ReadKey();
        }
    }
}
