using API.Services;
using BusinessObjects.Models;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs
{
	public class NotificationHub : Hub
	{
		public readonly static List<UserConnection> _Connection = new List<UserConnection>();
		private readonly ShareDBService _shareDBService;

		public async Task JoinSpecificNotification(UserConnection conn)
		{
			try
			{

				await Groups.AddToGroupAsync(Context.ConnectionId, conn.ChatRoom);

				await Clients.Group(conn.ChatRoom).SendAsync("JoinSpecificNotification", "admin", $"{conn.UserName} has joined");
			}
			catch (Exception ex)
			{
				await Clients.Caller.SendAsync("onError", "You failed to join the chat room!" + ex.Message);
			}
		}

		public async Task SendNotification(string userId)
		{
			if (_shareDBService.connection.TryGetValue(Context.ConnectionId, out UserConnection conn))
			{
				await Clients.Group(userId).SendAsync("ReceiveNotification", conn.UserName, "You have new notification");
			}
		}
	}
}
