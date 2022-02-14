using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllName = @"/Users/201913/Projects/320LabsSysProg2021/Core/bin/Debug/Core.dll";

            Assembly asm = Assembly.LoadFrom(dllName);

            Type archerType = asm.GetType("Core.Units.Archer", true, true);
            Type warriorType = asm.GetType("Core.Units.Warrior", true, true);
            Type battleType = asm.GetType("Core.Battle", true, true);

            // Get Info
            Console.WriteLine($"Type: {archerType.AssemblyQualifiedName}");

            Console.WriteLine($"Members:");
            foreach (MemberInfo memberInfo in archerType.GetMembers())
            {
                Console.WriteLine($"\t{memberInfo.DeclaringType} {memberInfo.MemberType} {memberInfo.Name}");
            }

            Console.WriteLine($"Methods:");
            foreach (MethodInfo method in warriorType.GetMethods())
            {
                Console.Write($"\t{method.ReturnType} {method.Name} (");
                foreach (ParameterInfo param in method.GetParameters())
                {
                    Console.Write($"{param.ParameterType.Name} {param.Name}, ");
                }
                Console.WriteLine(" )");
            }

            object archer = Activator.CreateInstance(archerType, "Bib");
            object warrior = Activator.CreateInstance(warriorType, "Bob");
            object battle = Activator.CreateInstance(battleType);

            MethodInfo fightMethod = battleType.GetMethod("Fight", new Type[] { archerType, warriorType });

            Console.WriteLine(fightMethod.Invoke(battle, new object[] { archer, warrior }));
        }
    }
}
