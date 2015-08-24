﻿namespace Discord
{
    public class DiscordClientConfig
	{
		/// <summary> Max time in milliseconds to wait for the web socket to connect. </summary>
		public int ConnectionTimeout { get; set; } = 5000;
		/// <summary> Max time in milliseconds to wait for the voice web socket to connect. </summary>
		public int VoiceConnectionTimeout { get; set; } = 10000;
		/// <summary> Gets or sets the time (in milliseconds) to wait after an unexpected disconnect before reconnecting. </summary>
		public int ReconnectDelay { get; set; } = 1000;
		/// <summary> Gets or sets the time (in milliseconds) to wait after an reconnect fails before retrying. </summary>
		public int FailedReconnectDelay { get; set; } = 10000;
		/// <summary> Gets or sets the time (in milliseconds) to wait when the websocket's message queue is empty before checking again. </summary>
		public int WebSocketInterval { get; set; } = 100;
		/// <summary> Enables or disables the internal message queue. This will allow SendMessage to return immediately and handle messages internally. Messages will set the IsQueued and HasFailed properties to show their progress. </summary>
		public bool UseMessageQueue { get; set; } = false;
		/// <summary> Gets or sets the time (in milliseconds) to wait when the message queue is empty before checking again. </summary>
		public int MessageQueueInterval { get; set; } = 100;

		public DiscordClientConfig() { }
    }
}