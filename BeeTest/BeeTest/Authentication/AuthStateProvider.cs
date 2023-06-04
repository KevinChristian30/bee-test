using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using NuGet.Protocol;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace BeeTest.Authentication
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public AuthStateProvider(ProtectedSessionStorage sessionStorage)
        {
            this._sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
                var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

                if (userSession == null) return await Task.FromResult(new AuthenticationState(_anonymous));

                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Email, userSession.Email),
                    new Claim(ClaimTypes.Role, userSession.Role)
                }, "Auth"));

                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            } catch
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }
    
        public async Task UpdateAuthenticationState(UserSession userSession)
        {
            ClaimsPrincipal claimsPrincipal;

            if (userSession != null)
            {
                await _sessionStorage.SetAsync("UserSession", userSession);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Email, userSession.Email),
                    new Claim(ClaimTypes.Role, userSession.Role),
                }));
            } else
            {
                await _sessionStorage.DeleteAsync("UserSession");
                claimsPrincipal = _anonymous;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    
        public static bool IsAuthenticated(AuthenticationState authState)
        {
            return authState.User.Identity.IsAuthenticated;
        }

        public static bool IsAuthorizedAs(AuthenticationState authState, string role)
        {
            return authState.User.IsInRole(role);
        }

        public static void AllowAuthorizedOnly(AuthenticationState authState, NavigationManager navigationManager)
        {
            if (!IsAuthenticated(authState))
            {
                navigationManager.NavigateTo("/login", true);
            }
        }

        public static string GetCurrentUserEmail(AuthenticationState authState)
        {
            var user = authState.User;

            if (!IsAuthenticated(authState)) return "Not Authenticated";

            var userEmail = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);

            return userEmail.Value;
        }

        public static void AllowAdminOnly(AuthenticationState authState, NavigationManager navigationManager)
        {
            if (!IsAuthenticated(authState) ||
                !IsAuthorizedAs(authState, "Admin"))
            {
                navigationManager.NavigateTo("/", true);
            }
        }

        public static void AllowParticipantOnly(AuthenticationState authState, NavigationManager navigationManager)
        {
            if (!IsAuthenticated(authState) ||
               !IsAuthorizedAs(authState, "Participant"))
            {
                navigationManager.NavigateTo("/", true);
            }
        }
    }
}
