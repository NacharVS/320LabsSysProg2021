using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllName = @"D:\Users\gutuf\source\repos\320LabsSysProg2021\UnitsClasses\bin\Debug\netcoreapp3.1\UnitsClasses.dll";

            Assembly asm = Assembly.LoadFrom(dllName);

            Type type = asm.GetType("UnitsClasses.BattleUnit", true, true);

            // Get Info
            Console.WriteLine($"Type: {type.AssemblyQualifiedName}");

            Console.WriteLine($"Members:");
            foreach (MemberInfo memberInfo in type.GetMembers())
            {
                Console.WriteLine($"  {memberInfo.DeclaringType} {memberInfo.MemberType} {memberInfo.Name}");
            }

            Console.WriteLine($"Methods:");
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.Write($"  {method.ReturnType} {method.Name} (");
                foreach (ParameterInfo param in method.GetParameters())
                {
                    Console.Write($"{param.ParameterType.Name} {param.Name}, ");
                }
                Console.WriteLine(" )");
            }


            // Run
            //Option 1
            //object user = Activator.CreateInstance(type);
            //object user = Activator.CreateInstance(type, "Alex", 29);

            //MethodInfo methodDisplay = type.GetMethod("Display");
            //methodDisplay.Invoke(user, new object[] { });

            //MethodInfo methodPayment = type.GetMethod("Payment");
            //int sum = (int)methodPayment.Invoke(user, new object[] { 10, Type.Missing });
            //Console.WriteLine(sum);

            ////Option 2
            //ConstructorInfo ivanConstructor = type.GetConstructor(new Type[] { });
            //var ivan = ivanConstructor.Invoke(new object[] { });

            //var propertyInfo = type.GetProperty("Name");
            //var name = propertyInfo.GetValue(ivan);
            //Console.WriteLine(name);

            //propertyInfo.SetValue(ivan, "Ivan");
            //Console.WriteLine(propertyInfo.GetValue(ivan));
        }

    }
}
