using Jint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunJavascript5
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsEngine = new Engine();
            jsEngine.Execute(JSCode.JS_CRYPTO);
            jsEngine.Execute(JSCode.AES_CALL);
            String result = jsEngine.GetValue("encryptedText").AsString();
            Console.WriteLine(result);
            Console.ReadKey(false);
        }
    }
}
