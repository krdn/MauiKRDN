namespace Krdn.Maui.ApplicationCore.Interfaces;

/// <summary>
/// 이 유형을 사용하면 ASP.NET Core 로깅 유형에 직접 의존할 필요가 없습니다.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IAppLogger<T>
{
    void LogInformation(string message, params object[] args);
    void LogWarning(string message, params object[] args);
}
