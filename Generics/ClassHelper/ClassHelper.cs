using System;
using System.Linq;
using System.Reflection;

namespace Generics
{
    public static class ClassHelper<T> where T : class
    {
        public static string ObterNomeClasse() =>
            typeof(T).Name;

        public static MethodInfo ObterMetodoPorNome(string nome) =>
            typeof(T)
            .GetMethods()
            .FirstOrDefault(p => p.Name.Equals(nome, StringComparison.Ordinal))!;
    }
}
