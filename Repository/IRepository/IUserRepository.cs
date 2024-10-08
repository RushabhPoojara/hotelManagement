namespace Demo_Asp_DotNetCoreWebAPI;

public interface IUserRepository
{
    bool IsUniqueUser(string username);

    Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);

    Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
}
