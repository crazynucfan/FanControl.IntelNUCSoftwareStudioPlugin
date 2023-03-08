# FanControl.IntelNUCSoftwareStudioPlugin

WARNING - This code is experimental and you use at your own risk

I found the Intel NUC Software Studio app for controlling fans a little too basic, and the fan curves too reactive to short changes in CPU temperature, so wanted to let Fan Control control the fans instead

I've tested this with the Intel NUC 11 Extreme i9 model (NUC11BTMi9), I expect it will probably work with other 11 Extremes, and with some tweaking newer models too

# Requirements
- Intel NUC Software Studio installed
- Fan Control
- Drop the provided dlls in the plugin directory and restart Fan Control

# Limitations
- You must set all the fan curves (CPU, System 1 and 2) with Fan Control or none of them, you can't just set the System 2 fan with this and leave the CPU alone, its all or nothing
- I've conservatively coded defaults of 25% fan speed everywhere, but you can customise to taste in fan control

# Bits of info for people who want to make the code better
- Intel NUC Software Studio app talks to a "Intel NUC Software Studio Service" running all the time in Windows Services
- When I looked at the strings in the app, I saw some references to WCF endpoints
- Loaded the WCF endpoints locally: http://localhost:43568/NssService/service/PerformanceTuning for instance
 - It might be the case that these endpoints are on different ports on each machine, in which case it needs to be made configurable
- I couldn't get half of the endpoints to do anything, it seems as if you need to set three fan profiles consistently when accessing these APIs, I just tried different things until it worked
- Found one endpoint that effectively just lets me set the fan speed, all the magic happens in StaticFanController.cs
- If you close Fan Control, you can go back to your normal profiles set in the NUC app
- This code is perfect garbage and zero time has been spent making it nice to work with, I stopped when it seemed to be working
Tips for fan settings
- CPU fan should be left on a minimum duty, I've found 25% works and is not audible, anything less than this and it stalls and you get "pulsing" as it spins back up to speed
- Case fans can go to zero, I make everything start to spin up once the CPU or GPU is 65C or above
- 100% duty makes these fans go to 5000rpm, the CPU gets to 4000 but they sound horrible, so wouldn't recommend that, max 2000 on both case and CPU seems to get air through the case just fine

I don't plan on making any more changes to this, but with a bit of love it could be turned into a fully fledged plugin like: https://github.com/Rem0o/FanControl.DellPlugin
