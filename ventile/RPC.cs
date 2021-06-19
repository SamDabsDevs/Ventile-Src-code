using DiscordRPC;
using System;
using System.Threading;
using Ventile_Client.Properties;

namespace Ventile_Client
{
	internal class RPC
	{
		public DiscordRpcClient client = new DiscordRpcClient("832806990953840710");

		public static bool initialized;

		public RPC()
		{
		}

		public void Deinitialize()
		{
			if (Ventile.Default.RpcE)
			{
				Thread.Sleep(150);
				this.client.Dispose();
			}
		}

		public void Home()
		{
			RichPresence richPresence;
			DateTime utcNow;
			if (Ventile.Default.RpcE)
			{
				try
				{
					if (!Ventile.Default.rpcButton)
					{
						DiscordRpcClient discordRpcClient = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("Idling In Launcher...");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp);
						Assets asset = new Assets();
						asset.set_LargeImageKey("logo");
						asset.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset);
						Button[] buttonArray = new Button[1];
						Button button = new Button();
						button.set_Label("Ventile's Server");
						button.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray[0] = button;
						richPresence.set_Buttons(buttonArray);
						discordRpcClient.SetPresence(richPresence);
					}
					else
					{
						DiscordRpcClient discordRpcClient1 = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("Idling In Launcher...");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp1 = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp1.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp1);
						Assets asset1 = new Assets();
						asset1.set_LargeImageKey("logo");
						asset1.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset1);
						Button[] buttonArray1 = new Button[2];
						Button button1 = new Button();
						button1.set_Label(Ventile.Default.rpcButtonText);
						button1.set_Url(Ventile.Default.rpcButtonLink);
						buttonArray1[0] = button1;
						Button button2 = new Button();
						button2.set_Label("Ventile's Server");
						button2.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray1[1] = button2;
						richPresence.set_Buttons(buttonArray1);
						discordRpcClient1.SetPresence(richPresence);
					}
				}
				catch
				{
					this.Toast("Rich Presence", "There was an error with RPC");
				}
			}
		}

		public void InGame()
		{
			RichPresence richPresence;
			DateTime utcNow;
			if (Ventile.Default.RpcE)
			{
				try
				{
					if (!Ventile.Default.rpcButton)
					{
						DiscordRpcClient discordRpcClient = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("In the Game!");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp);
						Assets asset = new Assets();
						asset.set_LargeImageKey("logo");
						asset.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset);
						Button[] buttonArray = new Button[1];
						Button button = new Button();
						button.set_Label("Ventile's Server");
						button.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray[0] = button;
						richPresence.set_Buttons(buttonArray);
						discordRpcClient.SetPresence(richPresence);
					}
					else
					{
						DiscordRpcClient discordRpcClient1 = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("In the Game!");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp1 = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp1.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp1);
						Assets asset1 = new Assets();
						asset1.set_LargeImageKey("logo");
						asset1.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset1);
						Button[] buttonArray1 = new Button[2];
						Button button1 = new Button();
						button1.set_Label(Ventile.Default.rpcButtonText);
						button1.set_Url(Ventile.Default.rpcButtonLink);
						buttonArray1[0] = button1;
						Button button2 = new Button();
						button2.set_Label("Ventile's Server");
						button2.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray1[1] = button2;
						richPresence.set_Buttons(buttonArray1);
						discordRpcClient1.SetPresence(richPresence);
					}
				}
				catch
				{
					this.Toast("Rich Presence", "There was an error with RPC");
				}
			}
		}

		public void Initialize()
		{
			RichPresence richPresence;
			DateTime utcNow;
			if (Ventile.Default.RpcE)
			{
				this.client = new DiscordRpcClient("832806990953840710");
				Thread.Sleep(100);
				this.client.Initialize();
				try
				{
					if (!Ventile.Default.rpcButton)
					{
						DiscordRpcClient discordRpcClient = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("Idling In Launcher...");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp);
						Assets asset = new Assets();
						asset.set_LargeImageKey("logo");
						asset.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset);
						Button[] buttonArray = new Button[1];
						Button button = new Button();
						button.set_Label("Ventile's Server");
						button.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray[0] = button;
						richPresence.set_Buttons(buttonArray);
						discordRpcClient.SetPresence(richPresence);
					}
					else
					{
						DiscordRpcClient discordRpcClient1 = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("Idling In Launcher...");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp1 = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp1.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp1);
						Assets asset1 = new Assets();
						asset1.set_LargeImageKey("logo");
						asset1.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset1);
						Button[] buttonArray1 = new Button[2];
						Button button1 = new Button();
						button1.set_Label(Ventile.Default.rpcButtonText);
						button1.set_Url(Ventile.Default.rpcButtonLink);
						buttonArray1[0] = button1;
						Button button2 = new Button();
						button2.set_Label("Ventile's Server");
						button2.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray1[1] = button2;
						richPresence.set_Buttons(buttonArray1);
						discordRpcClient1.SetPresence(richPresence);
					}
				}
				catch
				{
					this.Toast("Rich Presence", "There was an error with RPC");
				}
			}
		}

		public void Settings()
		{
			RichPresence richPresence;
			DateTime utcNow;
			if (Ventile.Default.RpcE)
			{
				try
				{
					if (!Ventile.Default.rpcButton)
					{
						DiscordRpcClient discordRpcClient = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("Changing Settings...");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp);
						Assets asset = new Assets();
						asset.set_LargeImageKey("logo");
						asset.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset);
						Button[] buttonArray = new Button[1];
						Button button = new Button();
						button.set_Label("Ventile's Server");
						button.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray[0] = button;
						richPresence.set_Buttons(buttonArray);
						discordRpcClient.SetPresence(richPresence);
					}
					else
					{
						DiscordRpcClient discordRpcClient1 = this.client;
						richPresence = new RichPresence();
						richPresence.set_Details("Changing Settings...");
						richPresence.set_State(Ventile.Default.LineRPC);
						Timestamps timestamp1 = new Timestamps();
						utcNow = DateTime.UtcNow;
						timestamp1.set_Start(new DateTime?(utcNow.AddSeconds(1)));
						richPresence.set_Timestamps(timestamp1);
						Assets asset1 = new Assets();
						asset1.set_LargeImageKey("logo");
						asset1.set_LargeImageText(Ventile.Default.Version);
						richPresence.set_Assets(asset1);
						Button[] buttonArray1 = new Button[2];
						Button button1 = new Button();
						button1.set_Label(Ventile.Default.rpcButtonText);
						button1.set_Url(Ventile.Default.rpcButtonLink);
						buttonArray1[0] = button1;
						Button button2 = new Button();
						button2.set_Label("Ventile's Server");
						button2.set_Url("https://discord.gg/mCyHtD9twt");
						buttonArray1[1] = button2;
						richPresence.set_Buttons(buttonArray1);
						discordRpcClient1.SetPresence(richPresence);
					}
				}
				catch
				{
					this.Toast("Rich Presence", "There was an error with RPC");
				}
			}
		}

		public void Toast(string title, string msg)
		{
			(new Toast()).showToast(title, msg);
		}
	}
}