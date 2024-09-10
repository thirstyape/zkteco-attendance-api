﻿namespace zkteco_attendance_api;

/// <summary>
/// Defines commands that are available on ZKTeco devices.
/// </summary>
internal enum Commands
{
	/// <summary>
	/// Received an unknown response from the ZKTeco device.
	/// </summary>
	Unknown = 0,

	/// <summary>
	/// Establishes a connection with a ZKTeco device.
	/// </summary>
	Connect = 1_000,

	/// <summary>
	/// Stops an active connection to a ZKTeco device.
	/// </summary>
	Disconnect = 1_001,

	/// <summary>
	/// Activates a ZKTeco device for use.
	/// </summary>
	EnableDevice = 1_002,

	/// <summary>
	/// Blocks a ZKTeco device from being used.
	/// </summary>
	DisableDevice = 1_003,

	/// <summary>
	/// Reboots a ZKTeco device.
	/// </summary>
	Restart = 1_004,

	/// <summary>
	/// Turns a ZKTeco device off.
	/// </summary>
	PowerOff = 1_005,

	/// <summary>
	/// Places a ZKTeco device into the sleep or idle mode.
	/// </summary>
	Sleep = 1_006,

	/// <summary>
	/// Returns a ZKTeco device from the sleep or idle mode to active mode.
	/// </summary>
	WakeUp = 1_007,

	/// <summary>
	/// Logs into a ZKTeco device with the provided password.
	/// </summary>
	Authenticate = 1_102,

	/// <summary>
	/// The command executed as expected.
	/// </summary>
	Success = 2_000,

	/// <summary>
	/// An error occurred during command execution.
	/// </summary>
	Error = 2_001,

	/// <summary>
	/// Return data is available after executing the command.
	/// </summary>
	Data = 2_002,

	/// <summary>
	/// The session needs to be authenticated.
	/// </summary>
	Unauthorized = 2_005
}
