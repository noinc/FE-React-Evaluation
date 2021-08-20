namespace NoInc.Services
{
    /// <summary>
    /// Interface for Jwt Authentication
    /// </summary>
    public interface IJwtAuthenticationManager
    {
        /// <summary>
        /// Create a jwt authentication token for the specified username (the caller
        /// is responsible to ensure the user is allowed to be authorized)
        /// </summary>
        string CreateAuthenticationToken(string username);
    }
}