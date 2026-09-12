using JobFlow.Application.DTOs.Auth;

namespace JobFlow.Application.Interfaces;

public interface IAuthService
{
    Task<RegisterResponse> RegisterAsync(RegisterRequest request);
}