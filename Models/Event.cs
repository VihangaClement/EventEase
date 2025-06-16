// Models/Event.cs
using System;

namespace EventEaseApp.Models
{
    public record Event(int Id, string Name, DateTime Date, string Location);
}