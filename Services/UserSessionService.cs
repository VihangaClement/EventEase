// Services/UserSessionService.cs
using System;
using Microsoft.AspNetCore.Components;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public bool IsLoggedIn { get; private set; }
        public string? CurrentUserName { get; private set; }

        // Evento para notificar componentes quando o estado de login muda
        public event Action? OnChange;

        public void Login(string userName)
        {
            IsLoggedIn = true;
            CurrentUserName = userName;
            NotifyStateChanged();
        }

        //Logoff
        public void Logout()
        {
            IsLoggedIn = false;
            CurrentUserName = null; // Limpa o nome de usuário
            NotifyStateChanged();   // Notifica que o estado mudou
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

