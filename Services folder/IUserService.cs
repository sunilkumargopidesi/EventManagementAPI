using EventManagementAPI.DTOs_folder;

namespace EventManagementAPI.Services_folder
{
    public interface IUserService
    {
        Task<UserDto> RegisterAsync(RegisterUserDto registerDto);
        Task<string> LoginAsync(LoginDto loginDto);
        Task LogoutAsync();
        Task<UserDto> GetUserByIdAsync(int id);

    }
}
