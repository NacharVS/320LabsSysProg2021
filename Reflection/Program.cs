using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllName = @"/Users/201913/Projects/320LabsSysProg2021/UnitsClasses/bin/Debug/netcoreapp3.1/UnitsClasses.dll";

            Assembly asm = Assembly.LoadFrom(dllName);

            Type buildingType = asm.GetType("UnitsClasses.Building", true, true);
            Type catapultType = asm.GetType("UnitsClasses.Catapult", true, true);
            Type battleType = asm.GetType("UnitsClasses.Battle", true, true);

            // Get Info
            Console.WriteLine($"Type: {buildingType.AssemblyQualifiedName}");

            Console.WriteLine($"Members:");
            foreach (MemberInfo memberInfo in buildingType.GetMembers())
            {
                Console.WriteLine($"  {memberInfo.DeclaringType} {memberInfo.MemberType} {memberInfo.Name}");
            }

            Console.WriteLine($"Methods:");
            foreach (MethodInfo method in catapultType.GetMethods())
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
            object building = Activator.CreateInstance(buildingType, "Building", 100);
            object catapult = Activator.CreateInstance(catapultType);
            object battle = Activator.CreateInstance(battleType);

            MethodInfo fightMethod = battleType.GetMethod("Fight", new Type[] {catapultType, buildingType });

            fightMethod.Invoke(battle, new object[] {catapult, building });
        }

    }
}
