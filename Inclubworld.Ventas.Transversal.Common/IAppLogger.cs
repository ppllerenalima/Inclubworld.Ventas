using System;

namespace Inclubworld.Ventas.Transversal.Common
{
    public interface IAppLogger<T>
    {
        void LogInformation(String message, params object[] args);
        void LogWarning(String message, params object[] args);
        void LogError(String message, params object[] args);
    }
}
