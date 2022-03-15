using System;
using System.Reflection;

namespace Refleksion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllName = @"/Users/nasur/source/repos/320LabsSysProg2021/Core/bin/Debug/netcoreapp3.1/Core.dll";

            Assembly asm = Assembly.LoadFrom(dllName);

            Type archerType = asm.GetType("Core.Archer", true, true);
            Type soldierType = asm.GetType("Core.Soldier", true, true);
            Type battleType = asm.GetType("Core.Battle", true, true);

            // Get Info
            Console.WriteLine($"Type: {archerType.AssemblyQualifiedName}");

            Console.WriteLine($"Members:");
            foreach (MemberInfo memberInfo in archerType.GetMembers())
            {
                Console.WriteLine($" {memberInfo.DeclaringType} {memberInfo.MemberType} {memberInfo.Name}");
            }

            Console.WriteLine($"Methods:");
            foreach (MethodInfo method in soldierType.GetMethods())
            {
                Console.Write($" {method.ReturnType} {method.Name} (");
                foreach (ParameterInfo param in method.GetParameters())
                {
                    Console.Write($"{param.ParameterType.Name} {param.Name}, ");
                }
                Console.WriteLine(" )");
            }

            object archer = Activator.CreateInstance(archerType, "Job", 1, 2);
            object warrior = Activator.CreateInstance(soldierType, "Sasha", 2, 3);
            object battle = Activator.CreateInstance(battleType);

            MethodInfo fightMethod = battleType.GetMethod("Fighting", new Type[] { archerType, soldierType });

            Console.WriteLine(fightMethod.Invoke(battle, new object[] { archer, warrior }));
        }
    }
}
